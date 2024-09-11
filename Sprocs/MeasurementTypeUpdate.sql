create or alter proc dbo.MeasurementTypeUpdate(
    @MeasurementTypeId int = 0,
    @MeasurementType varchar(20) = '',
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    if @MeasurementTypeId = 0
        begin

        insert MeasurementType(MeasurementType)
        values(@MeasurementType)

        select @MeasurementTypeId = SCOPE_IDENTITY()

        end
    else
        begin

        update MeasurementType
        set
        MeasurementType = @MeasurementType
        where MeasurementTypeId = @MeasurementTypeId

        end
    return @return
end
go
