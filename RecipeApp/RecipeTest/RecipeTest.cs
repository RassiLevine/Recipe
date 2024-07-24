using CPUFramework;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;
using RecipeSystem;
using System.Data;
namespace RecipeTest
{
    public class RecipeTest
    {
        [SetUp]
        public void Setup()
        {
            DBmanager.SetConnectionString("Server=tcp:dev-rlevine.database.windows.net,1433;Initial Catalog=RecipeWebsiteDB;Persist Security Info=False;User ID=cpuadminRL;Password=Rassi0605!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
        }

        [Test]
        public void ChangeCalories()
        {
            int recipeid = GetRecipeId();
            string calories = SQLutility.GetFirstRowFirstColumn("select calories from recipe r where r.recipeid = " + recipeid).ToString();
            TestContext.WriteLine("calories for recipe " + recipeid + " is " + calories);
            int n = 0;
            bool b = int.TryParse(calories, out n);
            calories = (n + 1).ToString();
            TestContext.WriteLine("Change calories to " + calories);
            DataTable dt = Recipe.LoadRecipe(recipeid);
            dt.Rows[0]["calories"] = calories;
            Recipe.Save(dt);
            string newcalories = SQLutility.GetFirstRowFirstColumn("select calories from recipe where recipeid = " + recipeid).ToString();

            Assert.IsTrue(newcalories == calories, "calories for recipe with id (" + recipeid + ") = " + newcalories);
            TestContext.WriteLine("calories for recipe with id (" + recipeid + ") = " + newcalories);
        }

        [Test]
        public void InsertRecipe()
        {
            DataTable dt = Recipe.LoadRecipe(0);
            dt.Rows.Add();

            int recipeid = SQLutility.GetFirstRowFirstColumn("select top 1 recipeid from recipe");
            int cuisineid = SQLutility.GetFirstRowFirstColumn("select cuisineid from recipe r where r.recipeid = " + recipeid);
            cuisineid = 1;
            int staffid = SQLutility.GetFirstRowFirstColumn("select staffid from recipe r where r.recipeid = " + recipeid);
            staffid = 2;
            string recipename = dt.Rows[0]["recipename"].ToString();
            TestContext.WriteLine("recipename for recipe with id " + recipeid + " is " + recipename);
            DateTime now = new();
            recipename = "tea" + now.ToString();
            TestContext.WriteLine("insert recipe name for recipe with id " + recipeid + " to" + recipename);
            int calories = SQLutility.GetFirstRowFirstColumn("select calories from recipe where recipeid = " + recipeid);
            calories = 2;
            dt.Rows[0]["cuisineid"] = cuisineid;
            dt.Rows[0]["staffid"] = staffid;
            dt.Rows[0]["recipename"] = recipename;
            dt.Rows[0]["calories"] = calories;
            Recipe.Save(dt);
            DataTable dtnew = SQLutility.GetDataTable("select * from recipe r where recipeid = " + recipeid);
            TestContext.WriteLine("new recipe cuisine id = " + cuisineid);
            TestContext.WriteLine("new recipe staff id  = " + staffid);
            TestContext.WriteLine("new recipe name = " + recipename);
            TestContext.WriteLine("new recipe calories is " + calories);
            Assert.IsTrue(dt.Rows[0]["recipename"].ToString() == recipename, "recipename for recipe with id " + recipeid + " is " + recipename + "(" + dt.Rows[0]["recipename"].ToString() + ")");
            TestContext.WriteLine("recipename for reicpe with id " + recipeid + " is " + dt.Rows[0]["recipename"].ToString() + "(" + recipename + ")");
        }

    [Test]
        public void DeleteRecipe()
        {
            DataTable dt = SQLutility.GetDataTable("select top 1 recipeid from recipe r left join cuisine c on c.cuisineid = r.cuisineid where c.cuisineid is null");
            int recipeid = 0;
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
            }
            Assume.That(recipeid > 0, "no recipes without cuisine in db, cant run");
            TestContext.WriteLine("existing recipe without cuisine id with recipeid of = " + recipeid);
            TestContext.WriteLine("ensure that app can delete " + recipeid);
            Recipe.Delete(dt);
            DataTable dtafterdelete = SQLutility.GetDataTable("select * from recipe where recipe id = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + " exists in db");
            TestContext.WriteLine("record with recipeid" + recipeid + "does not exist in db");
        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetRecipeId();
            Assume.That(recipeid > 0, "no recipes in db, cant run test");
            TestContext.WriteLine("existing recipe with id = " + recipeid);
            TestContext.WriteLine("ensure that app loads recipe" + recipeid);
            DataTable dt = Recipe.LoadRecipe(recipeid);
            int loadedid = (int)dt.Rows[0]["recipeid"];
            Assert.IsTrue(loadedid == recipeid, loadedid + "<>" + recipeid);
            TestContext.WriteLine("loaded recipe(" + loadedid + ")" + recipeid);
        }

        [Test]
        public void GetCuisineList()
        {
            int cuisinecount = SQLutility.GetFirstRowFirstColumn("select total = count(*) from cuisine");
            Assume.That(cuisinecount > 0, "no cuisine in db, cant test");
            TestContext.WriteLine("num cuisine types in DB =" + cuisinecount);
            TestContext.WriteLine("ensure that number of rows returend by app matches" + cuisinecount);
            DataTable dt = Recipe.GetCuisineList();
            Assert.IsTrue(dt.Rows.Count == cuisinecount, "num rows returned by app (" + dt.Rows.Count + ")<>" + cuisinecount);
            TestContext.WriteLine("number of cuisine types returned by app = " + dt.Rows.Count);
        }

        [Test]
        public void GetStaffList()
        {
            int staffcount = SQLutility.GetFirstRowFirstColumn("select total = count(*) from staff");
            Assume.That(staffcount > 0, "no staff in db, cant test");
            TestContext.Write("num of staff in db = " + staffcount);
            TestContext.Write("ensure number of rows returned matches " + staffcount);
            DataTable dt = Recipe.GetStaffList();
            Assert.IsTrue(dt.Rows.Count == staffcount, "um rows returned (" + dt.Rows.Count + ")<>" + staffcount);
            TestContext.WriteLine("number of staff members returned = " + dt.Rows.Count);
        }


        private int GetRecipeId()
        {
           return SQLutility.GetFirstRowFirstColumn("select top 1 r.recipeid from Recipe r");
        }
    }
}