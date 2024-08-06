create or alter function dbo.TotalCaloriesPerMeal(@mealid int)
returns varchar(5)
as
begin
    declare @value varchar(5) = ''

        select @value = sum(r.calories)
        from courserecipecoursemeal crm
        join recipe r
        on crm.recipeid = r.recipeid
        join coursemeal cm 
        on cm.coursemealid = crm.coursemealid
        join meals m
        on m.mealsid = cm.mealsid
        where m.mealsid = @mealid
        group by m.mealname

    return @value
end
go

/*  
TEST
select m.mealname, TotalCalories = dbo.TotalCaloriesPerMeal(m.mealsid)
from meals m
*/