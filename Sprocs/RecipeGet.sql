
create or alter procedure dbo.RecipeGet(@RecipeId int =0, @all bit = 0, @RecipeName varchar(30) = '')
as 
begin
    select r.RecipeId, r.RecipeName, r.Calories, r.CuisineId, r.DateDraft, r.DatePublished, r.DateArchived, r.StaffId, r.StaffId, r.RecipePic
    from recipe r
    where r.recipeid = @RecipeId
    or @all = 1
    or (@RecipeName <> '' and r.RecipeName like '%' + @RecipeName + '%')
end
go

/*
exec RecipeGet

exec RecipeGet @all =1

exec RecipeGet @RecipeName = 't'

declare @recipeId int
select top 1 @recipeId = r.recipeid from recipe r
exec RecipeGet @RecipeId = @recipeId
*/