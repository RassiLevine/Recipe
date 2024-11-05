create or alter proc dbo.CookbookList(
    @Message varchar(1000) = ' '
)
as
begin

    declare @return int = 0

select cb.CookbookId, cb.CookbookName, author = concat(s.StaffFirstName, ' ',  s.StaffLastName), NumRecipes = count(cbr.RecipeId), cb.price
from Cookbook cb
join staff s
on cb.staffid = s.StaffId
left join CookbookRecipe cbr
on cbr.CookbookId = cb.CookbookId
--left join recipe r
--on cbr.recipeId = r.RecipeId
group by cb.CookbookId, cb.CookbookName, cb.active, s.StaffFirstName, s.StaffLastName, cb.Price
order by cb.CookbookName

    return @return
end
go


