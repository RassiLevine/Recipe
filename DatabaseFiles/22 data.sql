-- SM Excellent
use RecipeWebsiteDB
go
delete cookbookrecipe
delete courserecipecoursemeal
delete coursemeal
delete recipeingredient
delete measurementType
delete ingredients 
delete course
delete Directions
delete cookbook
delete recipe
delete cuisine
delete meals
delete staff
go

insert staff(StaffFirstName, StaffLastName, UserName)
select 'Jacklyn', 'Bee', 'JB1223'
union select 'John', 'Smith', 'JS2345'
union select 'Mike', 'Band', 'MB1122'

insert Cuisine(CuisineType)
select 'American'
union select 'French'
union select 'English'

insert Recipe(RecipeName, calories, cuisineId, staffid, datedraft, datepublished, datearchived)
select 'Chocolate Chip Cookies', 150, c.cuisineId, (select s.staffid from staff s where s.StaffFirstName = 'Jacklyn' and s.StaffLastName = 'Bee' ), '2024/01/01', null, null from cuisine c where c.CuisineType = 'American'
union select 'Apple Yogurt Smoothie', 200,c.cuisineId, (select s.staffid from staff s where s.StaffFirstName = 'Jacklyn' and s.StaffLastName = 'Bee' ),'2024/01/01', '2024/02/05','2024/02/09' from cuisine c where c.CuisineType = 'French'
union select 'cheese Bread', 250, c.cuisineId,(select s.staffid from staff s where s.StaffFirstName = 'John' and s.StaffLastName = 'Smith' ), '2024/01/02', '2024/02/05', null from cuisine c where c.CuisineType = 'English'
union select 'Butter Muffins', 300, c.cuisineId,(select s.staffid from staff s where s.StaffFirstName = 'John' and s.StaffLastName = 'Smith' ), '2024/02/02', null, '2024/02/05' from cuisine c where c.CuisineType = 'English'
union select 'Iced Coffee', 60, c.cuisineId, (select s.staffid from staff s where s.StaffFirstName = 'John' and s.StaffLastName = 'Smith'), '2024/01/01',null, null from cuisine c where c.CuisineType = 'American' 
insert measurementType(measurementType)
select 'cup'
union select 'pinch'
union select 'tsp'
union select 'tbsp'
union select 'oz'
union select 'g'

insert Ingredients( IngredientName)
select 'Sugar'
union select 'Oil'
union select 'eggs'
union select 'flour'
union select 'vanilla sugar'
union select 'baking powder'
union select 'baking soda'
union select 'chocolate chips'
union select 'yogurt'
union select 'granny smith apples'
union select 'orange juice'
union select 'honey'
union select 'ice cubes'
union select 'club bread'
union select 'butter'
union select 'shredded cheese'
union select 'cloves garlic'
union select 'black pepper'
union select 'salt'

;with x as(
    --chocolate chip cookies
    select  Ingredient = 'sugar', amt = 1, measurementType = 'cup', recipe = 'chocolate chip cookies', ingSequence = 1
    union select 'oil', .5, 'cup', 'chocolate chip cookies', 2
    union select 'eggs', 3, null, 'chocolate chip cookies', 3
    union select 'flour', 2, 'cup', 'chocolate chip cookies', 4
    union select 'vanilla sugar', 1, 'tbsp', 'chocolate chip cookies', 5
    union select 'baking powder', 2, 'tsp', 'chocolate chip cookies', 6
    union select 'baking soda', .5, 'tsp', 'chocolate chip cookies', 7
    union select 'chocolate chips', 1, 'cup', 'chocolate chip cookies', 8
    --apple yogurt smoothies
    union select 'yogurt', 2, 'cup', 'apple yogurt smoothie', 1
    union select 'sugar', 2, 'tsp', 'apple yogurt smoothie', 2 
    union select 'granny smith apples', 3, null, 'apple yogurt smoothie', 3
    union select 'orange juice', .5, 'cup', 'apple yogurt smoothie', 4
    union select 'honey', 2, 'tbsp', 'apple yogurt smoothie', 5
    union select 'ice cubes', 5, null, 'apple yogurt smoothie', 6
    --cheese bread
    union select 'club bread', 1, null, 'cheese bread', 1
    union select 'butter', 4, 'oz', 'cheese bread', 2
    union select 'shredded cheese', 8, 'oz', 'cheese bread', 3
    union select 'cloves garlic', 2, null, 'cheese bread', 4
    union select 'black pepper', .25, 'tsp', 'cheese bread', 5
    union select 'salt', 1, 'pinch', 'cheese bread', 6

)

insert RecipeIngredient(RecipeId, ingredientid, IngredientAmt, MeasurementTypeId, ingredientsequence)
select r.recipeid, i.IngredientsId,x.amt, mt.measurementTypeId, x.ingSequence
from  x
join Ingredients i
on x.Ingredient = i.IngredientName
join Recipe r
on r.recipename = x.recipe
left join measurementtype mt
on mt.measurementtype = x.measurementType

;with x as(
    select recipe = 'chocolate chip cookies', direction = 'First combine sugar, oil and eggs in a bowl', DirectionSeq = 1
    union select 'chocolate chip cookies', 'mix well', 2
    union select 'chocolate chip cookies', 'add flour, vanilla sugar, baking powder and baking soda', 3
    union select 'chocolate chip cookies', 'beat for 5 minutes', 4
    union select 'chocolate chip cookies',  'add chocolate chips', 5
    union select 'chocolate chip cookies',  'freeze for 1-2 hours', 6
    union select 'chocolate chip cookies',  'roll into balls and place spread out on a cookie sheet', 7
    union select 'chocolate chip cookies',  'bake on 350 for 10 min.', 8
    union select 'apple yogurt smoothie', 'Combine all ingredients in bowl except for apples and ice cubes', 1
    union select 'apple yogurt smoothie', 'mix until smooth', 2
    union select 'apple yogurt smoothie', 'add apples and ice cubes', 3
    union select 'apple yogurt smoothie', 'pour into glasses.', 4
    union select 'cheese bread', 'Slit bread every 3/4 inch', 1
    union select 'cheese bread', 'Combine all ingredients in bowl', 2
    union select 'cheese bread', 'fill slits with cheese mixture', 3
    union select 'cheese bread', 'wrap bread into a foil and bake for 30 minutes.', 4
)
insert Directions(recipeid, direction, DirectionSequence)
select r.recipeid, x.direction, x.DirectionSeq
from x
left join recipe r
on r.recipename = x.recipe
order by r.recipeid


insert Meals(MealName, active, staffid)
select 'Breakfast Bash', 1, s.staffid from staff s where s.StaffFirstName = 'Jacklyn' and s.StaffLastName = 'Bee' 
union select 'Brunch', 0, s.staffid from staff s where s.StaffFirstName = 'Jacklyn' and s.StaffLastName = 'Bee' 
union select 'Breakfast Treat',1, s.staffid from staff s where s.StaffFirstName = 'John' and s.StaffLastName = 'Smith' 

;with x as(
 select seq = 1
 union select 2
 union select 3
 union select 4
)

insert Course(CourseType, coursesequence)
select 'Appetizer', x.seq from x where x.seq = 1
union select 'Main',x.seq from x where x.seq = 2
union select 'Side dish', x.seq from x where x.seq = 3
union select 'Dessert', x.seq from x where x.seq = 4

;with x as(
        select Meal = 'Breakfast Bash', Course = 'Appetizer'
        union select 'Breakfast Bash', 'Main'
        union select 'Breakfast Bash', 'Dessert'
        union select 'Brunch', 'Main'
        union select 'Brunch', 'Side Dish'
        union select 'Breakfast Treat', 'Side Dish'

)

insert CourseMeal(MealsId, CourseId)
select m.MealsId, c.CourseId
from x
join meals m
on m.MealName = x.Meal
join course c
on c.CourseType = x.Course

;with x as(
        select recipe = 'Chocolate Chip Cookies', Course = 'Dessert', mainside = 1
        union select 'Apple Yogurt Smoothie', 'Side Dish', 0
        union select 'Cheese Bread', 'Main', 1
        union select 'Butter Muffins', 'Appetizer', 0
)
insert CourseRecipeCourseMeal(CourseMealId, RecipeId, IsMain)
select cm.CourseMealId, r.RecipeId, x.mainside
from x
join recipe r
on r.RecipeName = x.recipe
join course c
on c.CourseType = x.Course
join CourseMeal cm
on cm.CourseId = c.CourseId

insert Cookbook(CookbookName, Price, StaffId, active)
select 'Treats for Two', 30.00, s.staffId, 1 from staff s where s.StaffFirstName = 'Jacklyn' and s.StaffLastName = 'Bee'
union select 'Brunch Recipes', 25.00, s.staffId, 0 from staff s where s.StaffFirstName = 'Jacklyn' and s.StaffLastName = 'Bee'
union select 'Dinner in two', 32.00, s.staffId, 1 from staff s where s.StaffFirstName = 'John' and s.StaffLastName = 'Smith'

;with x as(
        select Cookbook = 'Treats for Two', recipe = 'Chocolate Chip Cookies', Seq = 1
        union select 'Treats for Two', 'Apple Yogurt Smoothie', Seq = 2
        union select 'Brunch Recipes', 'Cheese Bread', Seq = 1
        union select 'Dinner in two', 'Cheese Bread' , Seq = 1
)
insert cookbookrecipe(CookbookId, recipeid, Seq)
select c.CookbookId, r.RecipeId, x.Seq
from x
join Cookbook c
on c.CookbookName = x.Cookbook
join Recipe r
on r.RecipeName = x.recipe


select * from cookbookrecipe
select * from courserecipecoursemeal
select * from coursemeal
select * from recipeingredient
select * from ingredients 
select * from course
select * from Directions
select * from cookbook
select * from meals
select * from recipe 
select * from cuisine
select * from staff
select * from measurementtype

select top 1 r.recipeid from recipe r
select * from recipe