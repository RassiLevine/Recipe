create or alter proc dbo.MeasurementGet(
    @MeasurementId int = 0,
    @RecipeId int = 0,
    @IngredientId int = 0,
    @All int = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    select @MeasurementId = isnull(@MeasurementId, 0), @RecipeId = isnull(@recipeid, 0), @ingredientid = isnull(@IngredientId, 0), @All = isnull(@all, 0)

select mt.MeasurementTypeId, mt.MeasurementType
from MeasurementType mt
join RecipeIngredient ri
on mt.MeasurementTypeId = ri.MeasurementTypeId
where ri.recipeid = @recipeid
or mt.MeasurementTypeId = @MeasurementId
or ri.ingredientid = @ingredientid
or @All = 1

    return @return
end
go

exec MeasurementGet @recipeid = 6
