create or alter proc dbo.UserLogin(
    @username varchar(20),
    @password varchar(20),
    @message varchar(500) = '' output
)
as 
begin
declare @return int =0, @userId int
select @message =''
select @userId = u.userid from Users u where u.username = @username and u.password = @password

if isnull(@userId, 0)>0
begin
update Users
set sessionkey = newid(), sessionkeydate = getdate()
where userid = @userId

select u.userid, u.roleId, u.username, u.sessionkey, r.rolename, r.roleRank
from Users u
join Roles r
on r.roleid = u.roleid
where u.userid = @userId
end
else
begin
select @return = 1, @message = 'invalid login'
end
return @return
end
go
grant execute on UserLogin to recipeapprole
