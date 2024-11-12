create or alter proc dbo.CookbookUpdate(
   @CookbookId int = 0 output,
    @StaffId int = 0,
    @CookbookName varchar(30) = '',
    @Price decimal(5,2) = 0,
    @Active bit = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0
    declare @NewCookbookId int
select @CookbookId = isnull(@CookbookId, 0), @StaffId = ISNULL(@StaffId, 0), @Active = ISNULL(@Active, 0)
    

    if @cookbookId = 0
        begin
            insert Cookbook(StaffId, CookbookName, Price, Active) 
            values(@StaffId, @CookbookName, @Price, @Active)

            select @CookbookId = SCOPE_IDENTITY()

            set @Message = 'New cookbook inserted with ID: ' + cast(@CookbookId as varchar)

        end
    else
        begin
            update Cookbook 
            set 
            StaffId = @StaffId,
            CookbookName = @CookbookName,
            Price = @Price,
            Active = @Active
            where CookbookId = @CookbookId
        end
    
    set @return = 1
    return @return

end
go

--declare @NewCookbookId int

--exec dbo.CookbookUpdate @CookbookId = @NewCookbookId output, @Staffid = 4, @Cookbookname = 'create cookbook', @price = 11 -- here specify all your parameters the same as the sql call from your app
 --@CookbookId = @CoookbookId output -- this is your output parameter
--select @CookbookId = @NewCookbookId OUTPUT --This will give you the value returned by your output paramete
--select @NewCookbookId
/*declare @CookbookId int = 0
declare @Message varchar(500)
exec dbo.CookbookUpdate @CookbookId = @CookbookId output, 
                        @StaffId = 1, 
                        @CookbookName = 'Newest Cookbook', 
                        @Price = 29.99, 
                        @Active = 1, 
                        @Message = @Message output
                        select @cookbookId, @Message
                        */