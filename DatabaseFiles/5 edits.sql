/*
go
drop table if exists CookbookRecipe
drop table if exists CourseMeal
drop table if exists MealRecipe
drop table if exists meals
drop table if exists Driections
drop table if exists DirectionStep
drop table if exists recipeingredient
drop table if exists Ingredients
drop table if exists Recipe
drop table if exists cookbook
drop table if exists course
drop table if exists Cuisine
drop table if exists staff
*/

/*
;with seq as(
    select IngSequence = 1
    union select 2
    union select 3
    union select 4
    union select 5
    union select 6
    union select 7
    union select 8
)
insert RecipeIngredient(recipeid, ingredientId, IngredientSequence)
select r.RecipeId, i.IngredientId, x.IngSequence
from x
cross join recipe r
cross join Ingredients i
where r.RecipeName = 'chocolate chip cookies'
and i.IngredientName = 'sugar'
and x.IngSequence = 1
union select r.RecipeId, i.IngredientId, x.IngSequence
from x
cross join recipe r
cross join Ingredients i
where r.RecipeName = 'chocolate chip cookies'
and i.IngredientName = 'oil'
and x.IngSequence = 2
union select r.RecipeId, i.IngredientId, x.IngSequence
from x
cross join recipe r
cross join Ingredients i
where r.RecipeName = 'chocolate chip cookies'
and i.IngredientName = 'eggs'
and x.IngSequence = 3
union select r.RecipeId, i.IngredientId, x.IngSequence
from x
cross join recipe r
cross join Ingredients i
where r.RecipeName = 'chocolate chip cookies'
and i.IngredientName = 'flour'
and x.IngSequence = 4
union select r.RecipeId, i.IngredientId, x.IngSequence
from x
cross join recipe r
cross join Ingredients i
where r.RecipeName = 'chocolate chip cookies'
and i.IngredientName = 'vanilla sugar'
and x.IngSequence = 5
union select r.RecipeId, i.IngredientId, x.IngSequence
from x
cross join recipe r
cross join Ingredients i
where r.RecipeName = 'chocolate chip cookies'
and i.IngredientName = 'baking powder'
and x.IngSequence = 6
union select r.RecipeId, i.IngredientId, x.IngSequence
from x
cross join recipe r
cross join Ingredients i
where r.RecipeName = 'chocolate chip cookies'
and i.IngredientName = 'chocolate chips'
and x.IngSequence = 7
--next recipe
union select r.RecipeId, i.IngredientId, x.IngSequence
from x
cross join recipe r
cross join Ingredients i
where r.RecipeName = 'apple yogurt smoothie'
and i.IngredientName = 'yogurt'
and x.IngSequence = 1
union select r.RecipeId, i.IngredientId, x.IngSequence
from x
cross join recipe r
cross join Ingredients i
where r.RecipeName = 'apple yogurt smoothie'
and i.IngredientName = 'sugar'
and x.IngSequence = 2
union select r.RecipeId, i.IngredientId, x.IngSequence
from x
cross join recipe r
cross join Ingredients i
where r.RecipeName = 'apple yogurt smoothie'
and i.IngredientName = 'granny smith apples'
and x.IngSequence = 3
union select r.RecipeId, i.IngredientId, x.IngSequence
from x
cross join recipe r
cross join Ingredients i
where r.RecipeName = 'apple yogurt smoothie'
and i.IngredientName = 'honey'
and x.IngSequence = 4
union select r.RecipeId, i.IngredientId, x.IngSequence
from x
cross join recipe r
cross join Ingredients i
where r.RecipeName = 'apple yogurt smoothie'
and i.IngredientName = 'ice cubes'
and x.IngSequence = 5
-- next recipe
union select r.RecipeId, i.IngredientId, x.IngSequence
from x
cross join recipe r
cross join Ingredients i
where r.RecipeName = 'cheese bread'
and i.IngredientName = 'club bread'
and x.IngSequence = 1
union select r.RecipeId, i.IngredientId, x.IngSequence
from x
cross join recipe r
cross join Ingredients i
where r.RecipeName = 'cheese bread'
and i.IngredientName = 'butter'
and x.IngSequence = 2
union select r.RecipeId, i.IngredientId, x.IngSequence
from x
cross join recipe r
cross join Ingredients i
where r.RecipeName = 'cheese bread'
and i.IngredientName = 'shredded cheese'
and x.IngSequence = 3
union select r.RecipeId, i.IngredientId, x.IngSequence
from x
cross join recipe r
cross join Ingredients i
where r.RecipeName = 'cheese bread'
and i.IngredientName = 'cloves garlic'
and x.IngSequence = 4
union select r.RecipeId, i.IngredientId, x.IngSequence
from x
cross join recipe r
cross join Ingredients i
where r.RecipeName = 'cheese bread'
and i.IngredientName = 'black pepper'
and x.IngSequence = 5
union select r.RecipeId, i.IngredientId, x.IngSequence
from x
cross join recipe r
cross join Ingredients i
where r.RecipeName = 'cheese bread'
and i.IngredientName = 'salt'
and x.IngSequence = 6
*/

/*
CREATE UNIQUE NONCLUSTERED INDEX idx_Direciton_notnull
ON Directions(Direction)
WHERE Direction IS NOT NULL
*/

/*
create table dbo.DirectionStep(
    DirectionStepId int not null identity primary key,
    DirectionStepNum int not null UNIQUE    
        constraint ck_step_must_be_greater_than_zero check(DirectionStepNum > 0)
)
*/

-- DirectionStepId int not null constraint f_DirectionStep_directions foreign key references DirectionStep(DirectionStepId),


/*
insert directionStep(DirectionStepNum)
select x.DirectionNum
from x
*/
/*
-- SM Same here. Like you did for meals.
insert Directions(Direction, directionstepId, RecipeId)
select 'First combine sugar, oil and eggs in a bowl', dr.directionstepId, r.recipeId 
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Chocolate Chip cookies'
        and dr.DirectionStepNum = 1
union select 'mix well', dr.directionstepId, r.recipeId 
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Chocolate Chip cookies'
        and dr.DirectionStepNum = 2
union select 'add flour, vanilla sugar, baking powder and baking soda', dr.directionstepId, r.recipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Chocolate Chip cookies'
        and dr.DirectionStepNum = 3
union select 'beat for 5 minutes', dr.directionstepId, r.recipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Chocolate Chip cookies'
        and dr.DirectionStepNum = 4
union select 'add chocolate chips', dr.directionstepId, r.recipeid  
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Chocolate Chip cookies'
        and dr.DirectionStepNum = 5
union select  'freeze for 1-2 hours', dr.directionstepId, r.recipeid
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Chocolate Chip cookies'
        and dr.DirectionStepNum = 6
union select 'roll into balls and place spread out on a cookie sheet', dr.directionstepId, r.recipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Chocolate Chip cookies'
        and dr.DirectionStepNum = 7
union select 'bake on 350 for 10 min.', dr.directionstepId, r.recipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Chocolate Chip cookies'
        and dr.DirectionStepNum = 8
union select 'Peel the apples and dice', dr.directionstepId, r.RecipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Apple Yogurt Smoothie'
        and dr.DirectionStepNum = 1
union select 'Combine all ingredients in bowl except for apples and ice cubes', dr.directionstepId, r.recipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Apple Yogurt Smoothie'
        and dr.DirectionStepNum = 2
union select 'mix until smooth', dr.directionstepId, r.recipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Apple Yogurt Smoothie'
        and dr.DirectionStepNum = 3
union select 'add apples and ice cubes', dr.directionstepId, r.recipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Apple Yogurt Smoothie'
        and dr.DirectionStepNum = 4
union select 'pour into glasses.', dr.directionstepId, r.recipeid   
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Apple Yogurt Smoothie'
        and dr.DirectionStepNum = 5
union select 'Slit bread every 3/4 inch', dr.directionstepId, r.RecipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Cheese Bread'
        and dr.DirectionStepNum = 1
union select 'Combine all ingredients in bowl', dr.directionstepId, r.RecipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Cheese Bread'
        and dr.DirectionStepNum = 2
union select 'fill slits with cheese mixture', dr.directionstepId, r.RecipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Cheese Bread'
        and dr.DirectionStepNum = 3
union select 'wrap bread into a foil and bake for 30 minutes.', dr.directionstepId, r.RecipeId
        from directionstep dr
        cross join recipe r 
        where r.RecipeName = 'Cheese Bread'
        and dr.DirectionStepNum = 4
*/
/*
create table dbo.MealRecipe(
    MealRecipeId int not null identity primary key,
    MealId int not null constraint f_meal_mealrecipe foreign key references meals(mealsid),
    RecipeId int not null constraint f_recipe_mealrecipe foreign key references recipe(recipeid)
)
*/
/*
;with x as(
        select meal ='Breakfast Bash', recipe = 'Butter Muffins'
        union select 'Breakfast Bash', 'Cheese Bread'
        union select 'Breakfast Bash', 'Chocolate Chip Cookies'
        union select 'Brunch', 'Cheese Bread'
        union select 'Brunch', 'Apple Yogurt Smoothie'
        union select 'Breakfast Treat', 'Apple Yogurt Smoothie'
)

insert MealRecipe(recipeid, mealid)
select r.recipeId, m.MealsId
from x
join meals m
on x.meal = m.MealName 
join recipe r
on x.recipe = r.recipename*/

/*
;with x as(
select recipeId = d.RecipeId, MaxDirStep = max(ds.DirectionStepNum)
from Directions d
join DirectionStep ds
on d.DirectionStepId = ds.DirectionStepId
group by d.RecipeId
)
select LastDirectionStepNumber = x.MaxDirStep, d.Direction
from x
join Directions d
on d.RecipeId = x.recipeId
join DirectionStep ds
on ds.DirectionStepId = d.DirectionStepId
where ds.DirectionStepNum = x.MaxDirStep
*/

/*
delete mr
from MealRecipe mr
join Recipe r
on r.RecipeId = mr.RecipeId
join Staff s
on r.StaffId = s.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'Smith'

delete mr
from MealRecipe mr
join Meals m
on m.MealId =mr.MealId
join staff s
on s.StaffId= m.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'Smith'*/
/*

delete cbr
from CookbookRecipe cbr
join Cookbook cb
on cbr.CookbookId = cb.CookbookId
join staff s
on s.StaffId = cb.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'Smith'

delete c
from Cookbook c
join Staff s
on c.StaffId = s.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'Smith'

delete cr
from CourseRecipe cr
join recipe r
on r.RecipeId = cr.RecipeId
join staff s
on s.StaffId = r.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'Smith'


delete  d
from Directions d
join recipe r
on r.RecipeId = d.RecipeId
join Staff s
on s.StaffId = r.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'Smith'

delete m
from meals m
join Staff s
on m.StaffId = s.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'Smith'

delete ri
from RecipeIngredient ri
join recipe r
on r.RecipeId = ri.RecipeId
join staff s
on s.StaffId = r.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'Smith'

delete r
from recipe r
join Staff s
on r.StaffId = s.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'Smith'

delete s
from Staff s
where s.StaffFirstName = 'John' and s.StaffLastName = 'Smith'*/
/*!!!!!
delete cm
from coursemeal cm
join course c
on c.CourseId = cm.CourseId
join CourseRecipe cr
on cr.CourseId = c.CourseId
join recipe r
on r.RecipeId = cr.RecipeId
join staff s
on s.StaffId = r.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'smith'

delete m 
from courserecipe cr
join recipe r
on r.RecipeId = cr.RecipeId
join staff s
on s.StaffId = r.StaffId
join meals m
on m.StaffId = s.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'smith'

delete s
from Cookbook cb
join Staff s 
on s.StaffId = cb.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'smith'

delete cb
from CookbookRecipe cbr
join Cookbook cb
on cb.CookbookId = cbr.CookbookId
join Staff s
on s.StaffId = cb.StaffId
where s.StaffFirstName = 'John' and s.StaffLastName = 'smith'
*/
/*
    MainSide varchar(4) not null 
        constraint ck_must_be_either_main_or_side check(mainside in ('main', 'side')),
        constraint ck_mainSide_cannot_be_blank check(mainside <> ''),
        constraint u_courseid_recipeid unique(coursemealid, recipeid),*/