using CPUFramework;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;
using RecipeSystem;
using System.Data;
using System.Configuration;
namespace RecipeTest
    
{
    public class RecipeTest
    {
        string connstring = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;
        string testconnstring = ConfigurationManager.ConnectionStrings["unittestconn"].ConnectionString;
        [SetUp]
        public void Setup()
        {
            DBmanager.SetConnectionString(connstring, true);
        }
        private DataTable GetDataTable(string sql)
        {
            DataTable dt = new();
            DBmanager.SetConnectionString(testconnstring, false);
            dt = SQLutility.GetDataTable(sql);
            DBmanager.SetConnectionString(connstring, false);
            return dt;
        }
        private int GetFirstRowFirstColumn(string sql)
        {
            int n = 0;
            DBmanager.SetConnectionString(testconnstring, false);
            n = SQLutility.GetFirstRowFirstColumn(sql);
            DBmanager.SetConnectionString(connstring, false);
            return n;
        }
        private void ExecuteSQL(string sql)
        {
            DBmanager.SetConnectionString(testconnstring, false);
            SQLutility.ExecuteSQL(sql);
            DBmanager.SetConnectionString(connstring, false);
        }
        [Test]
        public void ChangeCalories()
        {
            int recipeid = GetRecipeId();
            string calories = GetFirstRowFirstColumn("select calories from recipe r where r.recipeid = " + recipeid).ToString();
            TestContext.WriteLine("calories for recipe " + recipeid + " is " + calories);
            int n = 0;
            bool b = int.TryParse(calories, out n);
            calories = (n + 1).ToString();
            TestContext.WriteLine("Change calories to " + calories);
            DataTable dt = Recipe.LoadRecipe(recipeid);
            dt.Rows[0]["calories"] = calories;
            Recipe.Save(dt);
            string newcalories = GetFirstRowFirstColumn("select calories from recipe where recipeid = " + recipeid).ToString();

            Assert.IsTrue(newcalories == calories, "calories for recipe with id (" + recipeid + ") = " + newcalories);
            TestContext.WriteLine("calories for recipe with id (" + recipeid + ") = " + newcalories);
        }

        [Test]
        public void ChangeCaloriesToInvalidNumber()
        {
            int recipeid = GetRecipeId();
            string calories = GetFirstColumnFirstRowValueAsString("select calories from recipe r where r.recipeid = " + recipeid).ToString();
            TestContext.WriteLine("calories for recipe " + recipeid + " is " + calories);
            int n = 0;
            bool b = int.TryParse(calories, out n);
            calories = "0";
            TestContext.WriteLine("Change calories to " + calories);
            DataTable dt = Recipe.LoadRecipe(recipeid);
            dt.Rows[0]["calories"] = calories;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void ChangeRecipeNameToInvalidName()
        {
            int recipeid = GetRecipeId();
            Assume.That(recipeid > 0, "no recipe in db, cant run test");
            string recipename = GetFirstColumnFirstRowValueAsString("select top 1 recipename from recipe where recipeid <> " + recipeid);
            string recipenamecurrent = GetFirstColumnFirstRowValueAsString("select top 1 recipename from recipe where recipeid = " + recipeid);

            Assert.That(recipename != "", "cannot run test because there is no other recipe in table");
            TestContext.WriteLine("change recipename of recipe with recipeid " + recipeid + "from " + recipename + " to " + recipenamecurrent + " which is the name of a different recipe");
            DataTable dt = Recipe.LoadRecipe(recipeid);
            dt.Rows[0]["recipename"] = recipename;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void InsertRecipe()
        {
            DataTable dt = Recipe.LoadRecipe(0);
            dt.Rows.Add();

            int recipeid = GetFirstRowFirstColumn("select top 1 recipeid from recipe");
            int cuisineid = GetFirstRowFirstColumn("select cuisineid from recipe r where r.recipeid = " + recipeid);
            int staffid = GetFirstRowFirstColumn("select staffid from recipe r where r.recipeid = " + recipeid);
            string recipename = dt.Rows[0]["recipename"].ToString();
            DateTime now = DateTime.Now;
            string name = "tea" + now.ToString();
            recipename = name;
            TestContext.WriteLine("insert new recipe " + recipeid + " " + recipename);
            string calories = "2";
            dt.Rows[0]["cuisineid"] = cuisineid;
            dt.Rows[0]["staffid"] = staffid;  
            dt.Rows[0]["recipename"] = recipename;
            dt.Rows[0]["calories"] = calories;
            bizRecipe recipe = new();
            recipe.Save(dt);
            //DataTable dtnew = SQLutility.GetDataTable("select * from recipe r where recipeid = " + recipeid);
            TestContext.WriteLine("new recipe cuisine id = " + cuisineid);
            TestContext.WriteLine("new recipe staff id  = " + staffid);
            TestContext.WriteLine("new recipe name = " + recipename);
            TestContext.WriteLine("new recipe calories is " + calories);
            Assert.IsTrue(dt.Rows[0]["recipename"].ToString() == recipename, "recipename for recipe with id " + recipeid + " is " + recipename + "(" + dt.Rows[0]["recipename"].ToString() + ")");
            TestContext.WriteLine("recipename for reicpe with id " + recipeid + " is " + dt.Rows[0]["recipename"].ToString() + "(" + recipename + ")");
        }

        [Test]  
        ///need to add a recipe that doesnt have ingredients to be able to delete...
        public void DeleteRecipe()
        {
            DataTable dt = GetDataTable(@"select top 1 *
from recipe r
left
join recipeingredient ri
on ri.recipeid = r.recipeid 
left
join CourseRecipeCourseMeal cm
on cm.recipeid = r.recipeid 
where ri.ingredientid is null
and cm.CourseRecipeId is null");
            int recipeid = 0;
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
            }
            Assume.That(recipeid > 0, "no recipes without ingredients in db, cant run");
            TestContext.WriteLine("existing recipe without ingredients' id with recipeid of = " + recipeid);
            TestContext.WriteLine("ensure that app can delete " + recipeid);
            bizRecipe recipe = new();
            recipe.Delete(dt);
            DataTable dtafterdelete = GetDataTable("select * recipeid from recipe where recipeid =" + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + " exists in db");
            TestContext.WriteLine("record with recipeid " + recipeid + "does not exist in db");
        }

        [Test]
        public void DeleteRecipeWithDirections()
        {
            DataTable dt = GetDataTable("select top 1 r.recipeid from recipe r join directions d on r.recipeid = d.recipeid");
            int recipeid = 0;
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
            }
            Assume.That(recipeid > 0, "no recipes with directions in db, cant run");
            TestContext.WriteLine("existing recipe with directions id with recipeid of = " + recipeid);
            TestContext.WriteLine("ensure that app cannot delete " + recipeid);
            Exception ex = Assert.Throws<Exception>(()=> Recipe.Delete(dt)) ;
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void DeletePublishedRecipe()
        {
            string sql = @"
select top 1 recipeid 
from recipe 
where RecipeStatus = 'published'
";
            DataTable dt = GetDataTable(sql);
            int recipeid = 0;
            if(dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
            }
            Assume.That(recipeid > 0, "no recipes with status of 'published'");
            TestContext.WriteLine("existing recipe wth status of published with recipeid of " + recipeid);
            TestContext.WriteLine("ensure app cannot delete recipe " + recipeid);
            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void DeleteRecipeArchivedLessThanThirtyDays()
        {
            string sql = @"
select top 1 recipeid 
from recipe 
where Datediff(day, getdate(), datearchived) <30
";
            DataTable dt = GetDataTable(sql);
            int recipeid = 0;
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
            }
            Assume.That(recipeid > 0, "no recipes that are archived for less than 30 days");
            TestContext.WriteLine("existing recipe that is archived for less thatn 30 days " + recipeid);
            TestContext.WriteLine("ensure app cannot delete recipe " + recipeid);
            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));
            TestContext.WriteLine(ex.Message);

        }
        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetRecipeId();
            Assume.That(recipeid > 0, "no recipes in db, cant run test");
            TestContext.WriteLine("existing recipe with id = " + recipeid);
            TestContext.WriteLine("ensure that app loads recipe" + recipeid);
            bizRecipe recipe = new();
            DataTable dt = recipe.LoadRecipe(recipeid);
            int loadedid = (int)dt.Rows[0]["recipeid"];
            Assert.IsTrue(loadedid == recipeid, loadedid + "<>" + recipeid);
            TestContext.WriteLine("loaded recipe(" + loadedid + ")" + recipeid);
        }

        [Test]
        public void GetCuisineList()
        {
            int cuisinecount = GetFirstRowFirstColumn("select total = count(*) from cuisine");
            Assume.That(cuisinecount > 0, "no cuisine in db, cant test");
            TestContext.WriteLine("num cuisine types in DB =" + cuisinecount);
            TestContext.WriteLine("ensure that number of rows returend by app matches" + cuisinecount);
            DataTable dt = DataMaintenance.GetDataList("Cuisine");
            Assert.IsTrue(dt.Rows.Count == cuisinecount, "num rows returned by app (" + dt.Rows.Count + ")<>" + cuisinecount);
            TestContext.WriteLine("number of cuisine types returned by app = " + dt.Rows.Count);
        }

        [Test]
        public void GetStaffList()
        {
            int staffcount = GetFirstRowFirstColumn("select total = count(*) from staff");
            Assume.That(staffcount > 0, "no staff in db, cant test");
            TestContext.Write("num of staff in db = " + staffcount);
            TestContext.Write("ensure number of rows returned matches " + staffcount);
            DataTable dt = DataMaintenance.GetDataList("Staff");
            Assert.IsTrue(dt.Rows.Count == staffcount, "um rows returned (" + dt.Rows.Count + ")<>" + staffcount);
            TestContext.WriteLine("number of staff members returned = " + dt.Rows.Count);
        }

        //[Test]
        //public void SearchRecipe()
        //{
        //    string criteria = "a";
        //    int num = SQLutility.GetFirstRowFirstColumn("select total = count(*) from recipe where recipename like '%" + criteria + "%'");
        //    Assume.That(num > 0, "cant run - no match");
        //    TestContext.WriteLine(num + " recipes that match " + criteria);
        //    TestContext.WriteLine("ensure that recipe search returns " + num + " with criteria " + criteria);
        //    DataTable dt = Recipe.Search(criteria);
        //    int results = dt.Rows.Count;

        //    Assert.IsTrue(results == num, "results of recipe search does not match number of recipes " + results + "<>" + num);
        //    TestContext.WriteLine("number of rows returned by search is " + results);

        //}

        private int GetRecipeId()
        {
           return GetFirstRowFirstColumn("select top 1 r.recipeid from Recipe r");
        }

        private string GetFirstColumnFirstRowValueAsString(string sql)
        {
            string value = "";

            DataTable dt = GetDataTable(sql);
            if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
            {
                if (dt.Rows[0][0] != DBNull.Value)
                {

                    value = dt.Rows[0][0].ToString();
                }
            }
            return value;
        }
    }
}