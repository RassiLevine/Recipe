create or alter proc dbo.MeasurementTypeGet(
    @MeasurementId int = 0,
    @RecipeId int = 0,
    @IngredientId int = 0,
    @All int = 0,
    @IncludeBlank int = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    select @MeasurementId = isnull(@MeasurementId, 0), @RecipeId = isnull(@recipeid, 0), @ingredientid = isnull(@IngredientId, 0), @All = isnull(@all, 0)

select mt.MeasurementTypeId,  mt.MeasurementType
from MeasurementType mt
where @All = 1
union select null, null 
where @IncludeBlank = 1

    return @return
end
go

