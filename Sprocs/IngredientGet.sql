create or alter proc dbo.IngredientsGet(
    @RecipeId int = 0,
    @IngredientsId int = 0,
    @IngredientName varchar(30) = '',
    @All int = 0,
    @IncludeBlank int = 0,
    @Message varchar(500) = '' output
    )
as
begin
    declare @return int = 0

select @recipeid = isnull(@recipeid, 0), @All = isnull(@all, 0)

select i.IngredientsId, i.IngredientName
-- i.ingredientsId, ingredientAmt = ri.ingredientamt, Measurement = mt.MeasurementType,  Ingredient = i.IngredientName, IngredientSequence = ri.Ingredientsequence
from Ingredients i
join RecipeIngredient ri
on i.IngredientsId = ri.ingredientId
join recipe r
on r.recipeid = ri.recipeid
where r.recipeid = @recipeid
or @all =1
or i.IngredientName like '%' + @IngredientName + '%'
union select null, null
where @IncludeBlank = 1
order by  i.IngredientName

    return @return
end
go


--exec IngredientsGet @recipeid=3



