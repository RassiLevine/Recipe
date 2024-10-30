create or alter proc dbo.DirectionsGet(
    @DirectionsId int = 0,
    @RecipeId int = 0,
    @All int = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

select d.DirectionsId, r.recipeid, d.Direction, d.DirectionSequence
from Directions d
join recipe r
on r.recipeid = d.recipeid
where @RecipeId = d.RecipeId
or @All = 1
order by d.DirectionSequence

    return @return
end

--exec DirectionsGet @Recipeid = 3