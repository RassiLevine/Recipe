create or alter proc dbo.CookbookGet(
    @CookbookId int = 0,
    @All int = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0


select c.CookbookId, c.CookbookName, c.Price, c.Active, c.DateCreated, s.StaffId, 'User' = concat(s.StaffFirstName, ' ', s.StaffLastName), c.skilllevel, c.SkillLevelDescription, c.cookbookpic
from cookbook c
join staff s
on s.staffid = c.staffid
where c.CookbookId = @CookbookId
or @All = 1

    return @return

end
go

exec CookbookGet @All = 1
