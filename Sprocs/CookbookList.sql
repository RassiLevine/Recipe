create or alter proc dbo.CookbookList(
    @Message varchar(1000) = ' '
)
as
begin

    declare @return int = 0

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

    return @return
end
go

exec CookbookList