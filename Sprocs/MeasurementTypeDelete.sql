create or alter proc dbo.MeasurementTypeDelete(
    @MeasurementTypeId int = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    delete ri
    from RecipeIngredient ri
    join MeasurementType mt
    on ri.MeasurementTypeId = mt.MeasurementTypeId
    where mt.MeasurementTypeId = @MeasurementTypeId

    delete MeasurementType
    where MeasurementTypeId = @MeasurementTypeId

    return @return
end
go