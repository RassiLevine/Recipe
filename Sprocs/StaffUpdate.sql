create or alter proc dbo.StaffUpdate(
    @StaffId int = 0,
    @StaffFirstName varchar(30) = '',
    @StaffLastName varchar(30) = '',
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    if @StaffId = 0
        begin

        insert Staff(StaffFirstName, StaffLastName)
        values(@StaffFirstName, @StaffLastName)

        select @StaffId = SCOPE_IDENTITY()

        end

    else
        begin

        update Staff
        set
        StaffFirstName = @StaffFirstName,
        StaffLastName = @StaffLastName
        where StaffId = @StaffId

        end

    return @return
end
go