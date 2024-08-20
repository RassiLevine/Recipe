create or alter proc CookbookRecipeGet(
    @CookbookRecipeId int = 0,
    @CookbookId int = 0,
    @RecipeId int = 0,
    @All int = 0,
    @Message varchar(500) = '' output
)
as
begin
 declare @return int = 0

select cbr.CookbookId, r.RecipeId, r.RecipeName, cbr.Seq
from CookbookRecipe cbr
join Recipe r
on r.RecipeId = cbr.RecipeId
where cbr.CookbookId = @CookbookId
order by cbr.Seq
 return @return

end
go

--exec CookbookRecipeGet @cookbookid = 3

