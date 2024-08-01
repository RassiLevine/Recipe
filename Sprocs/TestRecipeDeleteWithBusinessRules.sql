/*declare @recipeid int

select top 1 @recipeid = recipeid 
from recipe r 
where RecipeStatus = 'published'

select * from recipe where recipeid = @recipeid

declare @return int, @message varchar(500)

exec @return = RecipeDelete @recipeid = @recipeid, @message = @message output

select @return, @message

select * from recipe where recipeid = @recipeid
*/


declare @recipeid int

select top 1 @recipeid = recipeid 
from recipe r 
where DATEDIFF(day, GETDATE(), DateArchived) < 30

select * from recipe where recipeid = @recipeid

declare @return int, @message varchar(500)

exec @return = RecipeDelete @recipeid = @recipeid, @message = @message output

select @return, @message

select * from recipe where recipeid = @recipeid