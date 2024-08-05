declare @recipeid int

select top 1 @recipeid = r.recipeid 
from recipe r 
left join cookbookrecipe cbr
on cbr.recipeid = r.recipeid
left join courserecipecoursemeal cm 
on cm.RecipeId = r.RecipeId  
where  RecipeStatus = 'draft'
and cbr.CookbookId is NULL
and cm.courseMealId is null 
--or DATEDIFF(day, getdate(), DateArchived) > 30)

select * from recipe where recipeid = @recipeid

declare @return int, @message varchar(500)
exec @return = RecipeDelete @recipeid = @recipeid, @message = @message output

select @return, @message

select * from recipe where recipeid = @recipeid


select * 
from recipe r
where r.recipeid = 23 
and (RecipeStatus = 'archived' and DATEDIFF(day, GETDATE(), DateArchived) < 30)
or RecipeStatus = 'published'  