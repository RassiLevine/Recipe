create or alter proc dbo.DirectionsUpdate(
    @DirectionsId int = 0,
    @RecipeId int = 0,
    @Direction varchar(500) = '',
    @DirectionSequence int = 0,
    @Message varchar(500) = '' output
)
as
begin
select @DirectionsId = ISNULL(@DirectionsId, 0)
declare @return int = 0

if @DirectionsId = 0
    begin
        insert Directions(RecipeId, Direction, DirectionSequence)
        values (@RecipeId, @Direction, @DirectionSequence)

        select @DirectionsId = SCOPE_IDENTITY()
    end
else
    begin
        update Directions
        set RecipeId = @RecipeId,
            Direction = @Direction,
            DirectionSequence = @DirectionSequence
        where DirectionsId = @DirectionsId
    end
    
return @return
end