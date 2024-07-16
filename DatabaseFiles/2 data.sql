use RecipeWebsiteDB
go

delete mealrecipe
delete RecipeStatus
delete Stat
delete MealStaff
delete CourseMeal
delete RecipeStaff
delete CourseRecipe
delete CookbookRecipe
delete RecipeCuisine
delete staff
delete Cookbook
delete Course
delete meals
delete Cuisine
delete Ingredients
delete Directions 
delete DirectionStep
delete Recipe

go

insert Recipe(RecipeName, calories)
select 'Chocolate Chip Cookies', 150
union select 'Apple Yogurt Smoothie', 200
union select 'cheese Bread', 250
union select 'Butter Muffins', 300

;with x as(
        select DirectionNum = 1
        union select  2
        union select 3
        union select 4
        union select 5
        union select 6
        union select 7
        union select 8
)
-- getting an error when isnerting??
insert directionStep(DirectionStepNum)
select x.DirectionNum
from x

insert Directions(Direction, directionstepId, RecipeId)
select 'First combine sugar, oil and eggs in a bowl', dr.directionStepnum, r.recipeId 
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Chocolate Chip cookies'
        and dr.DirectionStepNum = 1
union select 'mix well', dr.directionStepnum, r.recipeId 
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Chocolate Chip cookies'
        and dr.DirectionStepNum = 2
union select 'add flour, vanilla sugar, baking powder and baking soda', dr.directionStepnum, r.recipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Chocolate Chip cookies'
        and dr.DirectionStepNum = 3
union select 'beat for 5 minutes', dr.directionStepnum, r.recipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Chocolate Chip cookies'
        and dr.DirectionStepNum = 4
union select 'add chocolate chips', dr.directionStepnum, r.recipeid  
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Chocolate Chip cookies'
        and dr.DirectionStepNum = 5
union select  'freeze for 1-2 hours', dr.directionStepnum, r.recipeid
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Chocolate Chip cookies'
        and dr.DirectionStepNum = 6
union select 'roll into balls and place spread out on a cookie sheet', dr.directionStepnum, r.recipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Chocolate Chip cookies'
        and dr.DirectionStepNum = 7
union select 'bake on 350 for 10 min.', dr.directionStepnum, r.recipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Chocolate Chip cookies'
        and dr.DirectionStepNum = 8
union select 'Peel the apples and dice', dr.directionStepnum, r.RecipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Apple Yogurt Smoothie'
        and dr.DirectionStepNum = 1
union select 'Combine all ingredients in bowl except for apples and ice cubes', dr.directionStepnum, r.recipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Apple Yogurt Smoothie'
        and dr.DirectionStepNum = 2
union select 'mix until smooth', dr.directionStepnum, r.recipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Apple Yogurt Smoothie'
        and dr.DirectionStepNum = 3
union select 'add apples and ice cubes', dr.directionStepnum, r.recipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Apple Yogurt Smoothie'
        and dr.DirectionStepNum = 4
union select 'pour into glasses.', dr.directionStepnum, r.recipeid   
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Apple Yogurt Smoothie'
        and dr.DirectionStepNum = 5
union select null, dr.directionStepnum, r.recipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Apple Yogurt Smoothie'
        and dr.DirectionStepNum = 6
union select null, dr.directionStepnum, r.recipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Apple Yogurt Smoothie'
        and dr.DirectionStepNum = 7
union select null, dr.directionStepnum, r.recipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Apple Yogurt Smoothie'
        and dr.DirectionStepNum = 7
union select 'Slit bread every 3/4 inch', dr.directionStepnum, r.RecipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Cheese Bread'
        and dr.DirectionStepNum = 1
union select 'Combine all ingredients in bowl', dr.directionStepnum, r.RecipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Cheese Bread'
        and dr.DirectionStepNum = 2
union select 'fill slits with cheese mixture', dr.directionStepnum, r.RecipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Cheese Bread'
        and dr.DirectionStepNum = 3
union select 'wrap bread into a foil and bake for 30 minutes.', dr.directionStepnum, r.RecipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Cheese Bread'
        and dr.DirectionStepNum = 4
union select null, dr.directionStepnum, r.RecipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Cheese Bread'
        and dr.DirectionStepNum = 5
union select null, dr.directionStepnum, r.RecipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Cheese Bread'
        and dr.DirectionStepNum = 6
union select null, dr.directionStepnum, r.RecipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Cheese Bread'
        and dr.DirectionStepNum = 7
union select null, dr.directionStepnum, r.RecipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Cheese Bread'
        and dr.DirectionStepNum = 8

insert Ingredients(IngredientAmt, IngredientName, recipeid)
select '1 cup ', 'Sugar', r.recipeid from recipe r where r.RecipeName = 'Chocolate Chip cookies'
union select '1/2 cup', 'Oil', r.recipeid from recipe r where r.RecipeName = 'Chocolate Chip cookies'
union select '3', 'eggs', r.recipeid from recipe r where r.RecipeName = 'Chocolate Chip cookies'
union select '2 cup', 'flour', r.recipeid from recipe r where r.RecipeName = 'Chocolate Chip cookies'
union select '1 tbsp', 'vanilla sugar', r.recipeid from recipe r where r.RecipeName = 'Chocolate Chip cookies'
union select '2 tsp', 'baking powder', r.recipeid from recipe r where r.RecipeName = 'Chocolate Chip cookies'
union select '1/2', 'baking soda', r.recipeid from recipe r where r.RecipeName = 'Chocolate Chip cookies'
union select '1 cup', 'chocolate chips', r.recipeid from recipe r where r.RecipeName = 'Chocolate Chip cookies'
union select '2 cup', 'yogurt', r.recipeid from recipe r where r.RecipeName = 'Apple Yogurt Smoothie'
union select '2 tsp', 'sugar', r.recipeid from recipe r where r.recipename = 'Apple Yogurt Smoothie'
union select '3', ' granny smith apples', r.recipeid from recipe r where r.RecipeName = 'Apple Yogurt Smoothie'
union select '1/2 cup', 'orange juice', r.recipeid from recipe r where r.RecipeName = 'Apple Yogurt Smoothie'
union select '2 tbps', ' honey', r.recipeid from recipe r where r.RecipeName = 'Apple Yogurt Smoothie'
union select '5-6', 'ice cubes', r.recipeid from recipe r where r.RecipeName = 'Apple Yogurt Smoothie'
union select '1', 'club bread', r.recipeid from recipe r where r.RecipeName = 'Cheese Bread'
union select '4oz', 'butter', r.recipeid from recipe r where r.RecipeName = 'Cheese Bread'
union select '8oz', 'shredded cheese', r.recipeid from recipe r where r.RecipeName = 'Cheese Bread'
union select '2', 'cloves garlic', r.recipeid from recipe r where r.RecipeName = 'Cheese Bread'
union select '1/4 tsp', 'black pepper', r.recipeid from recipe r where r.RecipeName = 'Cheese Bread'
union select 'pinch', 'salt', r.recipeid from recipe r where r.RecipeName = 'Cheese Bread'
/*
;with x as(
        select Num = 1
        union select 2
        union select 3
        union select 4
        union select 5
        union select 6
        union select 7
        union select 8
        union select 9 
        union select .25
        union select .5
        union select .75
)
insert measurement(MeasurementNum, MeasurementType)
select 
*/
insert Cuisine(CuisineType)
select 'American'
union select 'French'
union select 'English'


;with x as(
    select recipeName = 'Chocolate Chip Cookies', cuisine = 'American'
    union select 'Apple Yogurt Smoothie', 'French'
    union select 'Cheese Bread', 'English'
)

insert RecipeCuisine(RecipeId, CuisineId)
select r.RecipeId, c.CuisineId
from x
join Recipe r
on r.RecipeName = x.recipeName
join Cuisine c
on c.CuisineType = x.cuisine

insert stat(stat)
select 'Draft'
union select 'Published'
union select 'Archived'


;with x as(
        select recipe = 'chocolate Chip Cookies', recipeStatus = 'Draft'
        union select 'Apple Yogurt Smoothie', 'published'
        union select 'Cheese Bread', 'archived'
        union select 'Butter Muffins', 'Draft' 
)
insert RecipeStatus(RecipeId, StatId)
select distinct r.RecipeId, s.statid
from x
join recipe r
on x.recipe = r.RecipeName 
join stat s
on x.recipeStatus = s.Stat


insert Meals(MealName, active)
select 'Breakfast Bash', 1
union select 'Brunch', 0
union select 'Breakfast Treat',1

;with x as(
        select meal ='Breakfast Bash', recipe = 'Butter Muffins'
        union select 'Breakfast Bash', 'Cheese Bread'
        union select 'Breakfast Bash', 'Chocolate Chip Cookies'
        union select 'Brunch', 'Cheese Bread'
        union select 'Brunch', 'Apple Yogurt Smoothie'
        union select 'Breakfast Treat', 'Apple Yogurt Smoothie'
)

insert MealRecipe(recipeid, mealid)
select r.recipeId, m.MealId
from x
join meals m
on x.meal = m.MealName 
join recipe r
on x.recipe = r.recipename

insert Course(CourseType)
select 'Appetizer'
union select 'Main'
union select 'Side dish'
union select 'Dessert'

;with x as(
        select Meal = 'Breakfast Bash', Course = 'Appetizer'
        union select 'Breakfast Bash', 'Main'
        union select 'Breakfast Bash', 'Dessert'
        union select 'Brunch', 'Main'
        union select 'Brunch', 'Side Dish'
        union select 'Breakfast Treat', 'Side Dish'

)
insert CourseMeal(MealId, CourseId)
select m.MealId, c.CourseId
from x
join meals m
on m.MealName = x.Meal
join course c
on c.CourseType = x.Course


;with x as(
        select recipe = 'Chocolate Chip Cookies', Course = 'Dessert'
        union select 'Apple Yogurt Smoothie', 'Side Dish'
        union select 'Cheese Bread', 'Main'
        union select 'Butter Muffins', 'Appetizer'
)
insert CourseRecipe(CourseId, RecipeId)
select c.CourseId, r.RecipeId
from x
join recipe r
on r.RecipeName = x.recipe
join course c
on c.CourseType = x.Course

insert Cookbook(CookbookName, Price)
select 'Treats for Two', 30.00
union select 'Brunch Recipes', 25.00
union select 'Dinner in two', 32.00

;with x as(
        select Cookbook = 'Treats for Two', recipe = 'Chocolate Chip Cookies'
        union select 'Treats for Two', 'Apple Yogurt Smoothie'
        union select 'Brunch Recipes', 'Cheese Bread'
        union select 'Dinner in two', 'Cheese Bread' 
)
insert cookbookrecipe(CookbookId, recipeid)
select c.CookbookId, r.RecipeId
from x
join Cookbook c
on c.CookbookName = x.Cookbook
join Recipe r
on r.RecipeName = x.recipe
go

insert staff(StaffFirstName, StaffLastName, UserName)
select 'Jacklyn', 'Bee', 'JB1223'
union select 'John', 'Smith', 'JS2345'

;with x as(
        select recipe = 'Chocolate Chip Cookies', staffMemberFirst = 'Jacklyn', StaffMemberLast = 'Bee'
        union select 'Apple Yogurt Smoothie', 'Jacklyn', 'Bee'
        union select 'Cheese Bread', 'John', 'Smith'

)
insert RecipeStaff(RecipeId, StaffId)
select r.RecipeId, s.StaffId
from x
join Staff s
on x.staffMemberFirst = s.StaffFirstName
and x.StaffMemberLast = s.StaffLastName
join recipe r
on r.RecipeName = x.recipe 

;with x as(
        select Meal = 'Breakfast Bash', StaffFirst = 'Jacklyn', StaffLast = 'Bee'
        union select 'Brunch', 'John', 'Smith'
        union select 'Breakfast Treat', 'John', 'Smith'
)

insert MealStaff(mealid, StaffId)
select m.MealId, s.StaffId
from x
join meals m
on x.Meal = m.MealName
join staff s
on x.StaffFirst = s.StaffFirstName 
and x.StaffLast = s.StaffLastName
