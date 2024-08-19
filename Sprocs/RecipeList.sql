create or alter proc dbo.RecipeList(
    @Message varchar(1000) = ' '
)
as
begin

    declare @return int = 0

select r.RecipeId, r.RecipeName, r.RecipeStatus, s.UserName, r.Calories, NumIngredients = count(ri.ingredientId)
from recipe r
join staff s
on r.StaffId = s.StaffId 
left join RecipeIngredient ri
on ri.RecipeId = r.RecipeId
group by r.recipeid, r.RecipeName, r.RecipeStatus, s.UserName, r.Calories
order by r.RecipeStatus desc

    return @return
end
go

exec RecipeList

