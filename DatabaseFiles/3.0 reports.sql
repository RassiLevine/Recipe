-- SM Excellent! See comments, no need to resubmit.

use RecipeWebsiteDB
/*
Our website development is underway! 
Below is the layout of the pages on our website, please provide the SQL to produce the necessary result sets.

Note: 
a) When the word 'specific' is used, pick one record (of the appropriate type, recipe, meal, etc.) for the query. 
    The way the website works is that a list of items are displayed and then the user picks one and navigates to the "details" page.
b) Whenever you have a record for a specific item include the name of the picture for that item. That is because the website will always show a picture of the item.
*/

/*
Home Page
    One result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
*/

select Item = 'Recipe', Count = count(r.RecipeId)
from Recipe r
union select 'Meals',   count(m.mealsid)
from meals m
union select 'Cookbooks',  count(c.cookbookid)
from Cookbook c

/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. 
	Archived recipes should appear gray. Surround the archived recipe with <span style="color:gray">recipe name</span>
    In the resultset show the Recipe with its status, dates it was published and archived in mm/dd/yyyy format (blank if not archived), user, number of calories and number of ingredients.
    Tip: You'll need to use the convert function for the dates
*/
select 

RecipeName = 
case
when r.RecipeStatus = 'archived' then concat('<span style="color:gray">', r.RecipeName, '</span>')
else r.RecipeName
end,
DatePublished = isnull(convert(varchar, r.DatePublished,101),''), DateArchived = isnull(convert(varchar, r.DateArchived, 101),''),
s.UserName, r.Calories, NumIngredients = count(ri.ingredientId), r.RecipeStatus
from recipe r
join staff s
on r.StaffId = s.StaffId 
join RecipeIngredient ri
on ri.RecipeId = r.RecipeId
where r.RecipeStatus in('published', 'archived')
group by r.RecipeName, r.Calories, r.datearchived, r.datepublished,  r.RecipeStatus, s.UserName
order by r.RecipeStatus desc


/*
Recipe details page:
    Show for a specific recipe (three result sets):
        a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
        b) List of ingredients: show the measurement quantity, measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        c) List of prep steps sorted by sequence.
*/

select  r.recipename, r.calories, NumIng =  count(distinct ri.ingredientId), NumDir = count (distinct d.Direction)
from RecipeIngredient ri
join Recipe r
on r.RecipeId = ri.RecipeId
join Directions d
on r.RecipeId = d.RecipeId
where r.RecipeName = 'Chocolate Chip Cookies'
group by r.RecipeName, r.Calories, d.DirectionSequence

select Ingredients = concat(ri.ingredientamt, ' ', mt.MeasurementType, ' ', i.IngredientName)
from Ingredients i
join RecipeIngredient ri
on i.IngredientId = ri.ingredientId
join Recipe r
on r.RecipeId = ri.recipeId
left join measurementtype mt 
on mt.measurementTypeId = ri.MeasurementTypeId
where r.recipename = 'chocolate chip cookies'
order by ri.Ingredientsequence

select d.Direction
from Directions d
join Recipe r
on d.RecipeId = r.RecipeId
where r.RecipeName =  'Chocolate chip cookies'
order by d.DirectionSequence


/*
Meal list page:
    For all active meals, show the meal name, user that created the meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/


select m.MealName, s.UserName, NumCourses = count(distinct c.CourseId), NumRecipes = count(distinct r.RecipeId), Calories = sum(r.Calories)
from meals m
join Staff s
on s.StaffId = m.StaffId
join CourseMeal cm
on cm.MealsId = m.MealsId
join CourseRecipeCourseMeal cr
on cr.courseMealId = cm.CourseMealId
join Recipe r
on cr.RecipeId = r.recipeid
join course c 
on c.CourseId = cm.CourseId
where m.Active = 0
group by m.MealName, s.UserName, m.Active


/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
        b) List of all recipes: Result set should have one column, including the course type, whether the dish is serverd as main/side (if it's the main course), and recipe name. 
			Format for main course: CourseType: Main/Side dish - Recipe Name. 
            Format for non-main course: CourseType: Recipe Name
            Main dishes of the main course should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/
select m.MealName, s.UserName, m.DateCreated
from meals m
join staff s
on m.staffid = s.StaffId
where m.MealName = 'Breakfast Treat'

select recipe =  
    case 
    when c.CourseType = 'main' and cr.mainside = 'main' then concat('<b>', c.CourseType, ': Main Dish -', r.RecipeName, '</b>')
    when c.coursetype = 'main' and cr.mainside = 'side' then concat(c.CourseType, ': Side Dish -', r.RecipeName)
    else concat(c.CourseType, ': ', r.RecipeName)
    end
from recipe r
join CourseRecipeCourseMeal cr
on cr.RecipeId = r.RecipeId
join CourseMeal cm
on cm.CourseMealId = cr.courseMealId
join course c
on c.CourseId = cm.CourseId
join meals m
on cm.MealsId = m.MealsId
where m.MealName = 'Breakfast bash'
/*
Cookbook list page:
    Show all active cookbooks with author and number of recipes per book. Sorted by book name.
*/
select cb.CookbookName, author = concat(s.StaffFirstName, ' ',  s.StaffLastName), NumRecipes = count(r.RecipeId)
from Cookbook cb
join staff s
on cb.staffid = s.StaffId
join CookbookRecipe cbr
on cbr.CookbookId = cb.CookbookId
join recipe r
on cbr.recipeId = r.RecipeId
group by cb.CookbookName, cb.active, s.StaffFirstName, s.StaffLastName
having cb.active = 1
order by cb.CookbookName

/*
Cookbook details page:
    Show for specific cookbook:
    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  
        Note: User will click on recipe to see all ingredients and steps.
*/
select cb.CookbookName, s.UserName, cb.DateCreated, cb.Price, recipes = count(r.RecipeId)
from Cookbook cb
join staff s
on cb.staffid = s.StaffId
join CookbookRecipe cbr
on cbr.CookbookId = cb.CookbookId
join recipe r
on cbr.recipeId = r.RecipeId
where cb.CookbookName = 'dinner in two'
group by cb.CookbookName, s.UserName, cb.DateCreated, cb.Price

select cbr.seq, NumIng = count(distinct ri.recipeingredientId), NumSteps = count(distinct d.Direction), r.RecipeName, c.cuisinetype
from recipe r 
join CookbookRecipe cbr
on r.RecipeId = cbr.recipeId
join Cookbook cb
on cbr.CookbookId = cb.CookbookId
join cuisine c
on r.cuisineid = c.cuisineid
join RecipeIngredient ri
on r.RecipeId = ri.recipeid
join Ingredients i
on ri.ingredientid = i.IngredientId
join Directions d
on d.RecipeId = r.RecipeId
where CookbookName = 'Dinner in two'
group by cb.cookbookname, r.RecipeName, c.CuisineType, cbr.Seq
order by cbr.Seq


/*
April Fools Page:
    On April 1st we have a page with a joke cookbook. For that page provide the following.
    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name with the first letter capitalized and all others lower case.
        There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
        Note: ".jpg" file extension must be at the end of the reversed picture name EX: Recipe_Seikooc_pihc_etalocohc.jpg
    b) When the user clicks on any recipe they should see a spoof steps lists showing the step instructions for the LAST step of EACH recipe in the system. No sequence required.
        Hint: Use CTE
*/

select Recipe = 
concat(upper(substring(reverse(r.RecipeName), 1, 1)), substring((reverse(lower(r.RecipeName))), 2, len(r.RecipeName))),
pic=concat(substring(r.recipepic,1,7), upper(substring(reverse(r.RecipePic), 6, 1)), substring((reverse(lower(r.RecipePic))),  7, len(r.RecipePic)-12), '.jpeg')
from recipe r


;with x as(
select recID =  d.RecipeId, MaxDS = max(d.DirectionSequence)
from Directions d
group by d.RecipeId
)
select d.Direction
from x
join Directions d
on x.recID = d.RecipeId and d.DirectionSequence = x.MaxDS


/*
For site administration page:
5 seperate reports
    a) List of how many recipes each user created per status. Show 0 if user has no recipes at all.
    b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
    c) For each user, show three columns: Total number of meals, Total Active meals, Total Inactive meals. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    d) For each user, show three columns: Total number of cookbooks, Total Active cookbooks, Total Inactive cookbooks. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    e) List of archived recipes that were never published, and how long it took for them to be archived.
*/
select NumRecipes = count(r.RecipeId), s.UserName, RecipeStatus = isnull(r.RecipeStatus,'')
from staff s
left join recipe r
on r.StaffId = s.StaffId
group by s.UserName, r.RecipeStatus

select NumRecipes = isnull(count(r.RecipeId), 0), s.UserName, avgDysToBePub = isnull(avg(datediff(day, r.DateDraft, r.DatePublished)),0)
from staff s
left join recipe r
on r.StaffId = s.StaffId
group by s.UserName

select s.UserName, TotalNumMeals = count(m.mealsid), 
TotalActive = sum(case 
                    when m.Active = 1 then 1
                    else 0
                    end),
TotalInActive = sum(case
                     when m.active = 0 then 1
                     else 0
                     end)
from Staff s
left join Meals m
on s.StaffId = m.StaffId
group by s.UserName

select s.UserName, TotalNumCookbooks = count(c.CookbookId), 
TotalActive = sum(case 
                    when c.Active = 1 then 1
                    else 0
                    end),
TotalInActive = sum(case
                     when c.active = 0 then 1
                     else 0
                     end)
from Staff s
left join Cookbook c
on s.StaffId = c.StaffId
group by s.UserName

select r.RecipeName, TimeToBeArchived = datediff(day, r.datedraft, r.datearchived)
from recipe r
where r.RecipeStatus = 'archived' and r.datepublished is null 

/*
For user dashboard page:
    a) For a specific user, show one result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
        Tip: If you would like, you can use a CTE to get the User Id once instead of in each union select
    b) List of the user's recipes, display the status and the number of hours between the status it's in and the one before that. Omit recipes in drafted status.
    
    OPTIONAL CHALLENGE QUESTION
    c) Show a list of cuisines and the count of recipes the user has per cuisine, 0 if none
        Hint: Start by writing a CTE to give you cuisines for which the user does have recipes. 
*/
select Recipes =  'Recipes', NumRecipes = count(r.RecipeId)
from staff s
join recipe r
on s.Staffid = r.StaffId 
join meals m
on m.StaffId = r.StaffId
join Cookbook c
on c.StaffId = s.StaffId
where s.UserName = 'JS2345'
union select Meals  =  'Meals', NumRecipes = count(m.MealsId)
from staff s
join recipe r
on s.Staffid = r.StaffId 
join meals m
on m.StaffId = r.StaffId
join Cookbook c
on c.StaffId = s.StaffId
where s.UserName = 'JS2345'
union select Cookbooks =  'cookbooks', NumRecipes = count(c.CookbookId)
from staff s
join recipe r
on s.Staffid = r.StaffId 
join meals m
on m.StaffId = r.StaffId
join Cookbook c
on c.StaffId = s.StaffId
where s.UserName = 'JS2345'

select r.recipename, r.recipestatus, 
HoursBtwnStatus = case
when r.RecipeStatus = 'published' then datediff(hour, r.datedraft, r.datepublished)
when r.RecipeStatus = 'archived' and r.datepublished is not null then datediff(hour, r.datepublished, r.datearchived)
when r.RecipeStatus = 'archived' and r.datepublished is null then datediff(hour, r.datedraft, r.datearchived)
end
from recipe r
join staff s
on r.staffid = s.StaffId
where s.UserName = 'JS2345'
and r.RecipeStatus <> 'Draft'

/*
;with x as(
select distinct Cusisine =  c.CuisineType
from cuisine c
left join recipe r
on r.CuisineId = c.CuisineId
left join staff s
on s.StaffId = r.StaffId
)
select x.Cusisine, NumRecipes = isnull(count(r.RecipeId), 0)
from cuisine c
left join x
on c.CuisineType = x.Cusisine
left join recipe r
on r.CuisineId = c.CuisineId
left join staff s
on s.StaffId = r.StaffId
where s.StaffFirstName = 'John'
and s.StaffLastName = 'Smith'
group by x.Cusisine
*/