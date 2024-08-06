
create or alter procedure dbo.RecipeDelete (
    @Recipeid int
    )
as
begin
    begin try
        begin tran
delete RecipeIngredient where recipeid = @recipeid
delete Directions where recipeid = @Recipeid
delete courserecipecoursemeal where recipeid = @recipeid
delete cookbookrecipe where recipeid = @recipeid
delete recipe where recipeid = @recipeid
        commit
    end try
begin catch
    rollback;
    throw
end catch
end
go