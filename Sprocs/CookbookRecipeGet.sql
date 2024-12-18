create or alter proc CookbookRecipeGet(
    @CookbookId int = 0,
    @RecipeId int = 0,
    @All int = 0,
    @Message varchar(500) = '' output
)
as
begin
 declare @return int = 0

select cbr.CookBookRecipeId, cbr.CookbookId, r.RecipeId, cbr.Seq, r.RecipeName, r.isVegan, r.calories,r.RecipeStatus,
r.CuisineId,r.DateDraft, r.DatePublished,
     r.DateArchived, r.StaffId, 'user' = concat(s.StaffFirstName, ' ', s.StaffLastName), r.RecipePic,NumIngredients = count(ri.ingredientid)
from CookbookRecipe cbr
join Recipe r
on r.RecipeId = cbr.RecipeId
join staff s 
on r.StaffId = s.StaffId
join RecipeIngredient ri
on ri.RecipeId = r.RecipeId
where cbr.CookbookId = @CookbookId
or @All = 1
group by cbr.CookBookRecipeId, cbr.CookbookId, r.RecipeId, cbr.Seq, r.RecipeName, r.isVegan, r.calories,r.RecipeStatus,
r.CuisineId,r.DateDraft, r.DatePublished,
     r.DateArchived, r.StaffId,r.RecipePic,s.StaffFirstName, s.StaffLastName
order by cbr.Seq

 return @return

end
go

--exec CookbookRecipeGet @cookbookid = 3


   