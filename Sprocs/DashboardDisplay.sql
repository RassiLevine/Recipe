create or alter proc dbo.DashboardGet(
    @Message varchar(1000) = ' '
)
as
begin

    declare @return int = 0

select 'Type' =  'Cookbooks', 'Number' = count(distinct c.CookbookId)
from staff s
join recipe r
on s.Staffid = r.StaffId 
join meals m
on m.StaffId = r.StaffId
join Cookbook c
on c.StaffId = s.StaffId
union select 'Type'  =  'Meals', 'Number' = count(distinct m.MealsId)
from staff s
join recipe r
on s.Staffid = r.StaffId 
join meals m
on m.StaffId = r.StaffId
join Cookbook c
on c.StaffId = s.StaffId
union select 'Type' =  'Recipes', 'Number' = count(distinct r.RecipeId)
from staff s
join recipe r
on s.Staffid = r.StaffId 
join meals m
on m.StaffId = r.StaffId
join Cookbook c
on c.StaffId = s.StaffId
order by 'Type' desc


    return @return
end
go

--exec GetDashboard