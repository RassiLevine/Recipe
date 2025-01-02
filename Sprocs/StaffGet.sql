create or alter procedure dbo.StaffGet(@StaffId int = 0, @All bit = 0, @StaffUserName varchar(20) = '', @IncludeBlank bit =0)
as
begin
select s.StaffId, s.StaffFirstName, s.StaffLastName, s.UserName
from staff s
where s.StaffId = @StaffId
or @all = 1
or (@StaffUserName <> '' and s.UserName like '%' + @StaffUserName + '%')
union select 0, '', '', ''
where @IncludeBlank = 1
end
go
