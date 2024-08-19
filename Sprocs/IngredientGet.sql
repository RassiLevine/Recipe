create or alter proc dbo.IngredientsGet(
    @RecipeId int = 0,
    @IngredientsId int = 0,
    @All int = 0,
    @Message varchar(500) = '' output
    )
as
begin
    declare @return int = 0

select @recipeid = isnull(@recipeid, 0), @All = isnull(@all, 0)

select i.ingredientsId, ingredientAmt = ri.ingredientamt, Measurement = mt.MeasurementType,  Ingredient = i.IngredientName, IngredientSequence = ri.Ingredientsequence
from Ingredients i
join RecipeIngredient ri
on i.IngredientsId = ri.ingredientId
join Recipe r
on r.RecipeId = ri.recipeId
left join measurementtype mt 
on mt.measurementTypeId = ri.MeasurementTypeId
where r.recipeid = @recipeid
or @all =1
order by ri.Ingredientsequence



    return @return
end
go


--exec IngredientsGet @All =1



