create or alter proc dbo.CookbookActiveUpdate(
    @CookbookId int = 0,
    @Active bit = 0
)
as
begin
declare @return int = 0

    update Cookbook 
    set Active = @Active
    where CookbookId = @CookbookId

return @return 
end
go
