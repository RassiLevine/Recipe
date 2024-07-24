create or alter procedure dbo.CuisineGet(@CuisineId int = 0, @all bit = 0, @CuisineType varchar (30)= '' )
as
begin 
select c.CuisineId, c.CuisineType
from cuisine c
where c.CuisineId = @CuisineId
or @all = 1
or (@CuisineType <> '' and c.CuisineType like '%' + @CuisineType + '%')
end
go

/*
exec CuisineGet

exec CuisineGet @all = 1

exec CuisineGet @cuisinetype = 'a'

declare @cuisineId int
select top 1 @cuisineId = c.cuisineid from cuisine c
exec CuisineGet @cuisineId = @cuisineId
*/