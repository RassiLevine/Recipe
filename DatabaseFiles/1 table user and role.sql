use recipewebsiteDB
go
drop table if exists usesr
drop table if exists Roles
drop table if exists users
drop table if exists Reciperoles
drop table if exists RecipeUsers


create table dbo.Roles(
    roleId int not null identity primary key,
    roleName varchar(10) not null constraint u_rolename_roles unique,
    roleRank int not null constraint u_role_rank unique
)
go
create table dbo.Users(
    UserId int not null identity primary key,
    roleId int not null constraint f_users_role foreign key references Roles(roleId),
    userName varchar(20) not null constraint u_user_name unique,
    password varchar(20) not null ,
    sessionKey varchar(255) not null DEFAULT '',
    sessionKeydate datetime null 
)
go






