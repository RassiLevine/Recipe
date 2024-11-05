create or alter proc dbo.CuisineUpdate(
    @CuisineId int = 0,
    @CuisineType varchar(30) = '',
    @Message varchar(500) = '' output
)
as
begin
select @CuisineId = isnull(@CuisineId, 0)
    declare @return int = 0

    if @CuisineId = 0
        begin

        insert Cuisine(CuisineType)
        values(@CuisineType)

        select @CuisineId = SCOPE_IDENTITY()

        end

    else

        begin

        update Cuisine 
        set
        CuisineType = @CuisineType
        where CuisineId = @CuisineId

        end

    return @return 
end
go