create or alter proc dbo.UserLogout(
    @username varchar(20),
    @message varchar(500) = '' output
)
as 
begin
declare @return int =0, @userId int
select @message =''

update Users 
set sessionkey = '',
sessionkeydate = null
where username = @username
return @return
end
go
grant execute on UserLogout to recipeapprole

