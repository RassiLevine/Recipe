create or alter proc dbo.CuisineDelete(
    @CuisineId int = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    delete ri
    from RecipeIngredient ri
    join Recipe r
    on ri.RecipeId = r.RecipeId
    join Cuisine c
    on r.CuisineId = c.CuisineId
    where c.CuisineId = @CuisineId

    delete d
    from Directions d
    join Recipe r
    on r.RecipeId = d.RecipeId
    join Cuisine c
    on r.CuisineId = c.CuisineId
    where c.CuisineId = @CuisineId

    delete crcm
    from CourseRecipeCourseMeal crcm
    join recipe r
    on crcm.RecipeId = r.RecipeId
    join Cuisine c
    on c.CuisineId = r.CuisineId
    where c.CuisineId = @CuisineId

    delete cbr
    from CookbookRecipe cbr
    join recipe r
    on r.RecipeId = cbr.RecipeId
    join Cuisine c
    on r.CuisineId = c.CuisineId
    where c.CuisineId = @CuisineId

    delete r
    from recipe r
    join Cuisine c
    on r.CuisineId = c.CuisineId
    where c.CuisineId = @CuisineId

    delete Cuisine
    where CuisineId = @CuisineId

    return @return
end
go

