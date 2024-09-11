create or alter proc dbo.IngredientUpdate(
    @RecipeIngredientId int = 0,
    @IngredientId int = 0,
    @RecipeId int = 0,
    @MeasurementTypeId int = 0,
    @IngredientAmt decimal = 0,
    @IngredientSequence int = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

select @RecipeIngredientId = isnull(@RecipeIngredientId, 0), @IngredientId = isnull(@IngredientId, 0), 
       @RecipeId = isnull(@RecipeId, 0), @MeasurementTypeId = isnull(@MeasurementTypeId, 0), @IngredientAmt = isnull(@IngredientAmt, 0),
       @IngredientSequence = isnull(@IngredientSequence, 0)

    if @RecipeIngredientId = 0
        begin
            insert RecipeIngredient(RecipeId, ingredientId, MeasurementTypeId, IngredientAmt, IngredientSequence)
            values (@RecipeId, @IngredientId, @MeasurementTypeId, @IngredientAmt, @IngredientSequence)
        end
    else
        begin
            update RecipeIngredient
            set 
                RecipeId = @RecipeId,
                ingredientId = @IngredientId,
                measurementTypeId = @MeasurementTypeId,
                IngredientAmt = @IngredientAmt,
                Ingredientsequence = @IngredientSequence
        end 

    return @return
end
go
