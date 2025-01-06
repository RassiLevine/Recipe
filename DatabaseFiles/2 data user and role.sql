
delete Roles
delete Users


insert Roles(roleName, roleRank)
select 'user', 1
union select 'superuser', 2
union select 'admin', 3

insert Users(roleId, userName, password)
select r.roleId, 'user', 'password' from Roles r
where r.roleRank = 1 
union select r.roleId, 'sam', 'password2' from Roles r
where r.roleRank = 2
union select r.roleId, 'admin', 'password3' from Roles r
where r.roleRank = 3
