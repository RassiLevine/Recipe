select u.UserId, u.roleId, u.userName, u.[password], u.sessionKey,  r.roleName, r.roleRank
from users u
join roles r
on r.roleId = u.roleId

--login
declare @message varchar(500), @return int
exec @return =UserLogin @username = '', @password = '',  @message = @message output
select @return, @message

exec @return =UserLogin @username = 'admin', @password = 'password3',  @message = @message output
select @return, @message


--userget
declare @message varchar(500), @return int, @sessionkey varchar(255)
select @sessionkey = sessionkey from users where sessionkey != ''
select @sessionkey
exec @return = UserGet @userid = 0, @sessionkey = @sessionkey,  @message = @message output
select @return, @message
