create or alter proc dbo.CookbookUpdate(
    @CookbookId int = 0,
    @StaffId int = 0,
    @CookbookName varchar(30) = '',
    @Price decimal(5,2) = 0,
    @Active bit = 0,
    --@DateCreated date,
    @Message varchar(500) = '' output
)
as
begin
select @CookbookId = isnull(@CookbookId, 0), @StaffId = ISNULL(@StaffId, 0), @Active = ISNULL(@Active, 0)
    declare @return int = 0

    if @cookbookId = 0
        begin
            insert Cookbook(StaffId, CookbookName, Price, Active) --DateCreated)
            values(@StaffId, @CookbookName, @Price, @Active) --@DateCreated)

            select @CookbookId = SCOPE_IDENTITY()

        end
    else
        begin
            update Cookbook 
            set 
            StaffId = @StaffId,
            CookbookName = @CookbookName,
            Price = @Price,
            Active = @Active
            --DateCreated = @DateCreated
            where CookbookId = @CookbookId
        end

    return @return

end
go