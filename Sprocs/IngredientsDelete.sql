create or alter proc dbo.IngredientsDelete(
    @IngredientsId int = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0



    delete ri
    from RecipeIngredient ri
    join Ingredients i
    on ri.ingredientId = i.IngredientsId
    where i.IngredientsId = @IngredientsId

    delete Ingredients 
    where IngredientsId = @IngredientsId

    return @return
end
go

