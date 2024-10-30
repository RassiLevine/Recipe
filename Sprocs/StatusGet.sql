create or alter proc dbo.StatusGet(
    @RecipeId int = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

select r.RecipeId, r.RecipeName, r.RecipeStatus, r.DateDraft, r.DatePublished, r.DateArchived
from recipe r
where RecipeId = @RecipeId

    return @return
end
go


select * from recipe