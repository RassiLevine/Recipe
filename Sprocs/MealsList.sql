create or alter proc dbo.MealsList(
    @MealsId int = 0,
    @StaffId int = 0,
    @All int = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    select @MealsId = isnull(@MealsId, 0), @StaffId = isnull(@StaffId, 0), @All = isnull(@All, 0)

    select m.MealsId, m.MealName, 'User' = concat(s.StaffFirstName, ' ', s.StaffLastName),
           Calories = sum(r.Calories), NumRecipes = count(r.RecipeId)
    from Meals m
    join staff s 
    on s.StaffId = m.StaffId
    join coursemeal cm
    on cm.mealsid = m.mealsid
    join CourseRecipeCourseMeal crm
    on crm.coursemealid = cm.coursemealid
    join recipe r 
    on r.recipeid = crm.recipeid
    group by m.MealsId, m.MealName, s.StaffFirstName, s.StaffLastName

    return @return

end
go

--exec MealsList