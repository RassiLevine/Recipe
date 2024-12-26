create or alter proc dbo.CuisineRecipeGet(
    @CuisineId int  = 0,
    @All bit = 0
)
as
begin
select @CuisineId = ISNULL(@CuisineId, 0)
declare @return int = 0


select r.recipeId, c.cuisineid, c.cuisinetype, r.staffid, 'user' = s.stafffirstname + ' ' + s.StaffLastName, r.recipename, r.calories, r.datedraft,
r.datepublished, r.datearchived, r.recipestatus, r.recipepic, r.isVegan, NumIngredients = count(ri.ingredientid)
from recipe r
left join cuisine c 
on r.CuisineId = c.CuisineId
left join staff s 
on r.staffid = s.staffid
left join recipeingredient ri 
on r.recipeid = ri.recipeid
where c.CuisineId = @CuisineId
or @All = 1
group by c.cuisineid, c.cuisinetype, r.recipeid, r.recipename, r.staffid, s.stafffirstname, s.StaffLastName, r.calories, r.datedraft, r.datepublished, r.datearchived, r.recipestatus, r.recipepic, r.isVegan
return @return

end

