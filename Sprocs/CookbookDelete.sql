create or alter proc dbo.CookbookDelete(
    @CookbookId int,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

        if exists(select * from Cookbook c where c.Active = 1
                and CookbookId = @CookbookId)
    begin
        select @return = 1, @Message = 'Cannot delete cookbook because it is active.'
    goto finished
    end

    begin try
    begin tran
        delete CookbookRecipe where CookbookId = @CookbookId
        delete Cookbook where CookbookId = @CookbookId
      
    commit
    end try

    begin catch
rollback;
throw
    end catch
    finished:
    return @return
end
go

