create or alter procedure dbo.StaffGet(@StaffId int = 0, @All bit = 0, @StaffUserName varchar(20) = '')
as
begin
select s.StaffId, s.UserName
from staff s
where s.StaffId = @StaffId
or @all = 1
or (@StaffUserName <> '' and s.UserName like '%' + @StaffUserName + '%')
end
go

/*
exec StaffGet

exec StaffGet @All = 1

exec StaffGet @StaffUserName = 's'

declare @staffId int
select top 1 @staffId = s.staffid from staff s
exec StaffGet @StaffId = @staffId
*/

