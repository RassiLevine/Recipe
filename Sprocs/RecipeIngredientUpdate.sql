create or alter proc dbo.RecipeIngredientUpdate(
    @RecipeIngredientId int = 0,
    @RecipeId int = 0,
    @IngredientsId int = 0,
    @MeasurementTypeId int = 0,
    @IngredientAmt decimal,
    @IngredientSequence int,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

select @RecipeIngredientId = isnull(@RecipeIngredientId, 0)

    if @RecipeIngredientId = 0
        begin
            insert RecipeIngredient(RecipeId, IngredientId, MeasurementTypeId, IngredientAmt, IngredientSequence)
            values ( @RecipeId, @IngredientsId, @MeasurementTypeId, @IngredientAmt, @IngredientSequence)

            select @RecipeIngredientId = scope_identity()
        end
    else
        begin
            update RecipeIngredient
            set 
                RecipeId = @RecipeId,
                IngredientId = @IngredientsId,
                MeasurementTypeId = @MeasurementTypeId,
                IngredientAmt = @IngredientAmt,
                Ingredientsequence = @IngredientSequence
            where RecipeIngredientId = @RecipeIngredientId
        end 

    return @return
end
go

