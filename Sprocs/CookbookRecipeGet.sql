create or alter proc CookbookRecipeGet(
    @CookbookId int = 0,
    @RecipeId int = 0,
    @All int = 0,
    @Message varchar(500) = '' output
)
as
begin
 declare @return int = 0

select cbr.CookbookId, r.RecipeId, cbr.Seq
from CookbookRecipe cbr
join Recipe r
on r.RecipeId = cbr.RecipeId
where cbr.CookbookId = @CookbookId
or @All = 1
order by cbr.Seq
 return @return

end
go

--exec CookbookRecipeGet @cookbookid = 3

