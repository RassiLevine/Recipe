create or alter proc dbo.UserGet(
    @userId int = 0,
    @sessionkey varchar(255) ='',
    @message varchar(500) = '' output
)
as
begin
declare @return int = 0, @maxseconds int = 6000
if isnull(@sessionkey, '') != ''
begin
    if(select top 1 DATEDIFF(SECOND, u.sessionKeydate, GETDATE()) from Users u where u.sessionKey = @sessionKey) > @maxseconds
begin
update u set u.sessionKey = '', u.sessionkeydate = null from users u where u.sessionkey = @sessionkey
end
end

select u.userid, u.roleId, u.username, u.sessionkey, r.rolename, r.roleRank
from Users u
join roles r
on r.roleid = u.roleid
where u.userid = @userId
or(u.sessionKey = @sessionkey and sessionkey <> '')

return @return
end
go
grant execute on UserGet to recipeapprole
