using CPUFramework;
using RecipeSystem;
using System.Data;
using System.Configuration;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
namespace RecipeTest

{
    public class RecipeTest
    {
        string connstring = ConfigurationManager.ConnectionStrings["devconnlive"].ConnectionString;
        string testconnstring = ConfigurationManager.ConnectionStrings["unittestconnlive"].ConnectionString;

        [SetUp]
        public void Setup()
        {
            DBmanager.SetConnectionString(connstring, true);
           // DBmanager.SetConnectionString(testconnstring, true);
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
            bizRecipe recipe = new();
            int recipeid = GetFirstRowFirstColumn("select top 1 recipeid from recipe");
            int cuisineid = GetFirstRowFirstColumn("select cuisineid from recipe r where r.recipeid = " + recipeid);
            int staffid = GetFirstRowFirstColumn("select staffid from recipe r where r.recipeid = " + recipeid);
            DateTime now = DateTime.Now;
            string name = "tea" + now.ToString();
            TestContext.WriteLine("insert new recipe " + recipeid + " " + name);
            int calories = 2;
            recipe.CuisineId = cuisineid;
            recipe.StaffId = staffid;  
            recipe.RecipeName = name;
            recipe.Calories = calories;
            
            recipe.Save();

            TestContext.WriteLine("new recipe cuisine id = " + cuisineid);
            TestContext.WriteLine("new recipe staff id  = " + staffid);
            TestContext.WriteLine("new recipe name = " + name);
            TestContext.WriteLine("new recipe calories is " + calories);

            int pkid = recipe.RecipeId;
            Assert.IsTrue(pkid > 0, "pk not updated in datatable");
            TestContext.WriteLine("recipename for reicpe with id " + recipeid + " is " + name);
        }

        [Test]
        public void InsertIngredient()
        {
            bizIngredients ing = new();
            int ingredientid = GetFirstRowFirstColumn("select top 1 ingredientsid from ingredients");
            DateTime now = DateTime.Now;
            string ingname = "nuts" + now.ToString();
            TestContext.WriteLine("insert new ingredient " + ingredientid + " " + ingname);
            ing.IngredientName = ingname;
            ing.Save();

            TestContext.WriteLine("New ingredient " + ingname);

            int pkid = ing.IngredientsId;
            Assert.IsTrue(pkid > 0, "pk not updated in datatable");
            TestContext.WriteLine("ingredient name for ingredient with id " + ingredientid + " is " + ingname);
        }
        

        private DataTable GetRecipeForDelete()
        {
            string sql = @"select top 1 *
from recipe r
left
join recipeingredient ri
on ri.recipeid = r.recipeid 
left
join CourseRecipeCourseMeal cm
on cm.recipeid = r.recipeid 
where ri.ingredientid is null
and cm.CourseRecipeId is null";
            DataTable dt = GetDataTable(sql);
            return dt;
        }
        [Test]  
        // there arent enough recipes in the db without ingredients to run all th versions of the delete tests. 
        //re-run data if this rest deos not run...
        public void DeleteRecipe()
        {
           DataTable dt = GetRecipeForDelete();
            int recipeid = 0;
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
            }
            Assume.That(recipeid > 0, "no recipes without ingredients in db, cant run");
            TestContext.WriteLine("existing recipe without ingredients' id with recipeid of = " + recipeid);
            TestContext.WriteLine("ensure that app can delete " + recipeid);
            bizRecipe recipe = new();
            recipe.Load(recipeid);
            recipe.Delete();
            DataTable dtafterdelete = GetDataTable("select recipeid from recipe where recipeid =" + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + " exists in db");
            TestContext.WriteLine("record with recipeid " + recipeid + "does not exist in db");
        }



        [Test]
        public void DeleteById()
        {
            DataTable dt = GetRecipeForDelete();
            int recipeid = 0;
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
            }
            Assume.That(recipeid > 0, "no recipes without ingredients in db, cant run");
            TestContext.WriteLine("existing recipe without ingredients' id with recipeid of = " + recipeid);
            TestContext.WriteLine("ensure that app can delete " + recipeid);
            bizRecipe recipe = new();
            recipe.Delete(recipeid);
            DataTable dtafterdelete = GetDataTable("select recipeid from recipe where recipeid =" + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + " exists in db");
            TestContext.WriteLine("record with recipeid " + recipeid + "does not exist in db");
        }

        [Test]
        public void DeleteByDatatable()
        {
            DataTable dt = GetRecipeForDelete();
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
            DataTable dtafterdelete = GetDataTable("select recipeid from recipe where recipeid =" + recipeid);
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
            recipe.Load(recipeid);
            int loadedid = recipe.RecipeId;
            string recipename = recipe.RecipeName;
            Assert.IsTrue(loadedid == recipeid && recipename!="", loadedid + "<>" + recipeid + " RecipeName = " + recipename);
            TestContext.WriteLine("loaded recipe(" + loadedid + ") RecipeName = " + recipename);
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

        [Test]
        public void GetIngredientList()
        {
            int ingredientcount = GetFirstRowFirstColumn("select total = count(*) from ingredients");
            Assume.That(ingredientcount > 0, "no ingredients in db, cant test");
            TestContext.Write("num of ingredients in db = " + ingredientcount);
            TestContext.Write("ensure number of rows returned matches " + ingredientcount);
            bizIngredients ing = new();
            var lst = ing.GetList();

            Assert.IsTrue(lst.Count == ingredientcount, "num rows returned (" + lst.Count + ")<>" + ingredientcount);
            TestContext.WriteLine("number of staff members returned = " + lst.Count);
        }
        [Test]
        public void GetRecipeList()
        {
            int recipecount = GetFirstRowFirstColumn("select total = count(*) from recipe");
            Assume.That(recipecount > 0, "no recipe in db, cant test");
            TestContext.WriteLine("num recipe types in DB =" + recipecount);
            TestContext.WriteLine("ensure that number of rows returend by app matches" + recipecount);
            bizRecipe recipe = new();
            var lst = recipe.GetList();
            Assert.IsTrue(lst.Count == recipecount, "num rows returned by app (" + lst.Count + ")<>" + recipecount);
            TestContext.WriteLine("number of recipe types returned by app = " + lst.Count);
        }

        [Test]
        public void SearchRecipe()
        {
            string criteria = "a";
            int num = GetFirstRowFirstColumn("select total = count(*) from recipe where recipename like '%" + criteria + "%'");
            Assume.That(num > 0, "cant run - no match");
            TestContext.WriteLine(num + " recipes that match " + criteria);
            TestContext.WriteLine("ensure that recipe search returns " + num + " with criteria " + criteria);
            bizRecipe recipe = new();
            List<bizRecipe> lst = recipe.Search(criteria);

            int results = lst.Count;

            Assert.IsTrue(results == num, "results of recipe search does not match number of recipes " + results + "<>" + num);
            TestContext.WriteLine("number of rows returned by search is " + results);
        }

        [Test]
        public void SearchIngredients()
        {
            string criteria = "a";
            int num = GetFirstRowFirstColumn("select total = count(*) from ingredients where ingredientname like '%" + criteria + "%'");
            Assume.That(num > 0, "cant run - no match");
            TestContext.WriteLine(num + " ingredients that match " + criteria);
            TestContext.WriteLine("ensure that ingredient search returns " + num + " with criteria " + criteria);
            bizIngredients ing = new();
            List<bizIngredients> lst = ing.Search(criteria);

            int results = lst.Count;

            Assert.IsTrue(results == num, "results of recipe search does not match number of recipes " + results + "<>" + num);
            TestContext.WriteLine("number of rows returned by search is " + results);
        }

        //[Test]
        //public void zCheckIfDataBeingRefereshed()
        //{
        //    string query = "SELECT COUNT(*) FROM ingredients WHERE ingredientname LIKE '%almonds%'";
        //    int newnum = GetFirstRowFirstColumn(query);
        //    Assert.IsTrue(newnum > 0, "not picking up fresh data");
        //    TestContext.WriteLine("data being refreshed. new ingredient inserted has id " + newnum);
        //}


        //[TestCase("milk")]
        //public void InsertIngredientTest(string ingredientname)
        //{
        //    int ingredientid = GetFirstRowFirstColumn("select top 1 ingredientsid from ingredients");
        //    Assume.That(ingredientid > 0, "cant run test, no parties in db");
        //    TestContext.WriteLine("insert ingredient " + ingredientname);
        //    bizIngredients ing = new();
        //    ing.IngredientName = ingredientname;
        //    ing.Save();
        //    int pkid = ing.IngredientsId;

        //    Assert.IsTrue(pkid > 0, "pk not updated in datatable");
        //    TestContext.WriteLine("new ingredient added to datatable with id " + pkid);
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