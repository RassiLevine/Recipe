declare @recipeid int

select top 1 @recipeid = r.recipeid
from recipe r
left join RecipeIngredient ri
on r.Recipeid = ri.RecipeId
left join Directions d
on r.RecipeId = d.RecipeId


--where ri.ingredientId is null
--and d.DirectionsId is null

--select * from recipe where RecipeStatus = 'published' or DATEDIFF(day, getdate(), DateArchived) < 30 

select * from recipe where recipeid = @recipeid

declare @return int, @message varchar(500)
exec @return = RecipeDelete @recipeid = @recipeid, @message = @message output

select @return, @message
select * from recipe where recipeid = @recipeid


