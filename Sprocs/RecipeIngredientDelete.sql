create or alter proc dbo.RecipeIngredientDelete(
    @RecipeIngredientId int = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    delete RecipeIngredient where RecipeIngredientId = @RecipeIngredientId

    return @return
end
go
