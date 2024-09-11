create or alter proc dbo.StaffDelete(
    @StaffId int = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0


delete cbr
from CookbookRecipe cbr
join Cookbook cb
on cb.CookbookId = cbr.CookbookId
join staff s 
on s.StaffId = cb.StaffId
where s.StaffId = @StaffId

delete cb
from Cookbook cb
join staff s
on cb.StaffId = s.StaffId
where s.StaffId = @StaffId

delete cr
from CourseRecipeCourseMeal cr
join recipe r
on cr.RecipeId = r.RecipeId
join staff s
on r.StaffId = s.StaffId
where s.StaffId = @StaffId


delete cr 
from CourseMeal cm
join CourseRecipeCourseMeal cr
on cr.courseMealId = cm.CourseMealId
join meals m
on cm.MealsId = m.MealsId
join staff s
on s.StaffId = m.StaffId
where s.StaffId = @StaffId

delete cm
from Meals m
join CourseMeal cm
on cm.MealsId = m.MealsId
join staff s
on s.StaffId = m.StaffId
where s.StaffId = @StaffId

delete m
from meals m
join staff s
on s.StaffId = m.StaffId
where s.StaffId = @StaffId

delete cbr
from recipe r
join CookbookRecipe cbr
on cbr.recipeId = r.RecipeId
join Staff s
on s.StaffId = r.StaffId
where s.StaffId = @StaffId

delete ri
from RecipeIngredient ri
join recipe r
on r.RecipeId = ri.RecipeId
join Staff s
on s.StaffId = r.StaffId
where s.StaffId = @StaffId

delete d
from directions d
join recipe r
on r.RecipeId = d.RecipeId
join Staff s
on s.StaffId = r.StaffId
where s.StaffId = @StaffId

delete r
from recipe r
join Staff s 
on s.StaffId = r.StaffId
where s.StaffId = @StaffId

delete s
from staff s
where s.StaffId = @StaffId


    return @return
end
go

