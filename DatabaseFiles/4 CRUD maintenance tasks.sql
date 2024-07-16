-- SM Excellent! 100% See comment, no need to resubmit.
use RecipeWebsiteDB
--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause using a unique value that identifies it, do not use the primary key.

--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.

delete cbr
from CookbookRecipe cbr
join Cookbook cb
on cb.CookbookId = cbr.CookbookId
join staff s 
on s.StaffId = cb.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'smith'

delete cb
from Cookbook cb
join staff s
on cb.StaffId = s.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'smith'

delete cr
from CourseRecipeCourseMeal cr
join recipe r
on cr.RecipeId = r.RecipeId
join staff s
on r.StaffId = s.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'smith'


delete cr 
from CourseMeal cm
join CourseRecipeCourseMeal cr
on cr.courseMealId = cm.CourseMealId
join meals m
on cm.MealsId = m.MealsId
join staff s
on s.StaffId = m.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'smith'

delete cm
from Meals m
join CourseMeal cm
on cm.MealsId = m.MealsId
join staff s
on s.StaffId = m.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'smith'

delete m
from meals m
join staff s
on s.StaffId = m.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'smith'

delete cbr
from recipe r
join CookbookRecipe cbr
on cbr.recipeId = r.RecipeId
join Staff s
on s.StaffId = r.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'smith'

delete ri
from RecipeIngredient ri
join recipe r
on r.RecipeId = ri.RecipeId
join Staff s
on s.StaffId = r.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'smith'

delete d
from directions d
join recipe r
on r.RecipeId = d.RecipeId
join Staff s
on s.StaffId = r.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'smith'

delete r
from recipe r
join Staff s 
on s.StaffId = r.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'smith'

delete s
from staff s
where s.StaffFirstName = 'John' and s.StaffLastName = 'smith'



--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.
insert recipe(RecipeName, Calories, CuisineId, StaffId, DatePublished, DateArchived)
select concat(r.RecipeName, '-clone'), r.Calories, r.CuisineId, r.StaffId, r.DatePublished, r.DateArchived
from recipe r
where r.RecipeName = 'Chocolate Chip Cookies'

;with x as(
    select recipeName = 'chocolate chip cookies-clone', d.direction, d.DirectionSequence
    from directions d
    join recipe r
    on r.RecipeId = d.RecipeId
    where r.RecipeName = 'chocolate chip cookies'
)
insert Directions(recipeid, Direction, DirectionSequence)
select r.recipeid, x.direction, x.DirectionSequence
from x
join recipe r
on r.RecipeName = x.recipeName


;with x as(
    select recipename = 'chocolate chip cookies-clone', ri.IngredientAmt, ri.ingredientId, 
    ri.IngredientSequence, ri.MeasurementTypeId
    from RecipeIngredient ri
    join recipe r 
    on r.RecipeId= ri.RecipeId
    where r.RecipeName = 'chocolate chip cookies'
)
insert RecipeIngredient(RecipeId, IngredientAmt, ingredientId, IngredientSequence, MeasurementTypeId)
select r.recipeid, x.IngredientAmt, x.ingredientId, x.IngredientSequence, x.MeasurementTypeId
from x
join recipe r
on r.recipename = x.recipename

/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/
insert Cookbook (CookbookName, Price, StaffId, Active)
select concat('Recipes by ', s.StaffFirstName, ' ', s.StaffLastName ), count(r.RecipeId)* 1.33, s.StaffId, 0
from staff s 
join recipe r
on s.StaffId = r.StaffId
group by s.StaffId,  s.StaffFirstName, s.StaffLastName
having s.StaffFirstName = 'Jacklyn' and s.StaffLastName = 'Bee'

insert CookbookRecipe (CookbookId, recipeId, Seq)
select cb.cookbookid, r.recipeid, ROW_NUMBER() over (order by r.RecipeName)
from recipe r 
join Staff s on r.StaffId = s.StaffId 
join Cookbook cb on cb.StaffId = s.StaffId
where s.StaffFirstName = 'Jacklyn' and s.StaffLastName = 'Bee'
and cb.CookbookName = concat('recipes by', s.StaffFirstName, s.StaffLastName)

/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/
update r
set r.Calories =  
case
when mt.measurementtype = 'oz' then (r.Calories - (2*ri.IngredientAmt))
when mt.measurementtype = 'Stick' then (r.Calories - (16*ri.IngredientAmt))
end
from recipe r
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
join Ingredients i
on ri.ingredientId = i.IngredientId
join measurementtype mt
on mt.measurementTypeId = ri.MeasurementTypeId
where i.IngredientName = 'butter'
/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
;with x as(
     select Avg =avg(datediff(hour, r.DateDraft, r.DatePublished))
     from recipe r
)
select r.RecipeName,
s.StaffFirstName, s.StaffLastName, Email = concat(substring(s.StaffFirstName, 1, 1), s.StaffLastName, '@heartyhearth.com'),
Alert = concat('Your recipe ', r.RecipeName, ' is sitting in draft for ', datediff(hour, r.DateDraft, GETDATE()), ' hours. That is ', 
datediff(hour, r.DateDraft, getdate()) - x.avg, ' more than the ', x.avg, ' hours all other recipes took to be published.')
from recipe r
cross join x
join staff s
on r.StaffId = s.StaffId
where datediff(hour, r.DateDraft, getdate())> x.Avg
and r.RecipeStatus = 'Draft'

/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and recieve a 25% discount, 
for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/
-- SM Tip: Convert the prices to 2 decimal places. Use sum() * .75
select EmailBody = 
concat(
	'Order cookbooks from HeartyHearth.com! We have ', count(*), ' for sale, average price is, ', avg(Price), '. 
	You can order them all and receive a 25% discount, for a total of ', sum(cb.price)- .25*sum(cb.Price), '. 
	Click <a href = www.heartyhearth.com/order/', newid(),'">here<a/> to order.'

)
from Cookbook cb
