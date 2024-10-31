create or alter proc dbo.CookbookRecipeDelete(
    @CookbookRecipeId int = 0,
    @Message varchar(500) = '' output
)
as
begin

declare @return int = 0

    begin tran
        delete CookbookRecipe where CookBookRecipeId = @CookbookRecipeId
    commit

return @return

end
go
