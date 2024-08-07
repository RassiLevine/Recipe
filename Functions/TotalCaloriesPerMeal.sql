create or alter function dbo.TotalCaloriesPerMeal(@mealid int)
returns int
as
begin
    declare @value int = 0

        select @value = sum(r.calories)
        from courserecipecoursemeal crm
        join recipe r
        on crm.recipeid = r.recipeid
        join coursemeal cm 
        on cm.coursemealid = crm.coursemealid
        where cm.MealsId = @mealid


    return @value
end
go

/*  
TEST
select m.mealname, TotalCalories = dbo.TotalCaloriesPerMeal(m.mealsid)
from meals m
*/