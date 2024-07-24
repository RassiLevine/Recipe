create or alter procedure dbo.StaffGet(@StaffId int = 0, @all bit = 0, @StaffLastName varchar(20) = '')
as
begin
select s.StaffId, s.StaffFirstName, s.StaffLastName
from staff s
where s.StaffId = @StaffId
or @all = 1
or (@StaffLastName <> '' and s.StaffLastName like '%' + @StaffLastName + '%')
end
go

/*
exec StaffGet

exec StaffGet @all = 1

exec StaffGet @StaffLastName = 's'

declare @staffId int
select top 1 @staffId = s.staffid from staff s
exec StaffGet @StaffId = @staffId
*/

