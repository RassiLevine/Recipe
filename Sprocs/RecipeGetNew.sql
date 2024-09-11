create or alter proc dbo.RecipeGet(
    @RecipeId int = 0,
    @All bit = 0,
    @Message varchar(5000) = '' output
)
as
begin
declare @return int = 0

select r.*, c.cuisineid, s.staffid 
from recipe r 
join cuisine c 
on r.cuisineid = c.cuisineid 
join staff s
on r.staffid = s.staffid
where r.RecipeId = @RecipeId



return @return
end