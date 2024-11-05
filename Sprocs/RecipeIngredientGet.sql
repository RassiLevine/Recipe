create or alter proc dbo.RecipeIngredientsGet(
    @RecipeId int = 0,
    @All int = 0,
    @IncludeBlank bit = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

select @RecipeId = isnull(@recipeid, 0), @All = isnull(@All, 0)

select ri.RecipeIngredientId, r.recipeid, ri.IngredientAmt,  ri.IngredientSequence, i.IngredientsId, ri.MeasurementTypeId
from RecipeIngredient ri
join Ingredients i
on ri.ingredientId = i.IngredientsId
join MeasurementType mt 
on mt.MeasurementTypeId = ri.MeasurementTypeId
join recipe r 
on r.recipeid = ri.recipeid
where ri.RecipeId = @RecipeId
or @All = 1
order by ri.ingredientsequence
    return @return
end
go
