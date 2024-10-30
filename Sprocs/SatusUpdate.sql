create or alter proc dbo.StatusUpdate(
    @RecipeId int = 0,
    @DateDraft date,
    @DatePublished date null,
    @DateArchived date null,
    @Message varchar(500) = '' output
)
as
begin 
    declare @return int = 0

    update recipe 
    set 
        DateDraft = @DateDraft,
        DatePublished = @DatePublished,
        DateArchived = @DateArchived
        where RecipeId = @RecipeId

    return @return
end
go

