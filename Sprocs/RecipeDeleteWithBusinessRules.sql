
create or alter procedure dbo.RecipeDelete (
    @Recipeid int,
    @Message varchar(500) = '' output
    )  
as    
begin
    declare @return int = 0
    
    if exists(select * from recipe r where r.recipeid = @Recipeid
              and  (RecipeStatus = 'published' or (RecipeStatus = 'archived' and DATEDIFF(day, GETDATE(), DateArchived) < 30)))


    begin
    select @return = 1, @message = 'Cannot delete recipe becasue it is either published or archived for less than 30 days'
    goto finished
    end 

    begin try  
    begin tran
delete RecipeIngredient where recipeid = @recipeid
delete Directions where recipeid = @Recipeid
--delete courserecipecoursemeal where recipeid = @recipeid
--delete cookbookrecipe where recipeid = @recipeid
delete recipe where recipeid = @recipeid
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


