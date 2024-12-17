create or alter proc dbo.MealsGet(
 @MealsId int = 0,
    @StaffId int = 0,
    @MealName varchar(30) = '',
    @Active bit = 1,
    @All bit = 1
)
as
begin
    declare @return int = 0
    declare @TotalMeals int =0




    select m.MealsId, m.StaffId, m.MealName, m.Active, m.MealPic, m.MealsDesc, m.DateCreated, TotalRecipes = count(DISTINCT r.recipeid)
    from Meals m
    join CourseMeal cm
    on cm.MealsId = m.MealsId
    join CourseRecipeCourseMeal cr
    on cr.courseMealId = cm.CourseMealId
    join Recipe r
    on cr.RecipeId = r.recipeid
    where m.MealsId = @MealsId 
    or @All = 1
    group by m.MealsId, m.MealName, m.StaffId, m.Active, m.MealPic, m.MealsDesc, m.DateCreated

    return @return
end
go



exec MealsGet @all=1
