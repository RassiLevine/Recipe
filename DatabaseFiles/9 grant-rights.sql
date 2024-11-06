use RecipeWebsiteDB
go
select concat('grant execute on ', r.ROUTINE_NAME, ' to recipeapprole')
from INFORMATION_SCHEMA.ROUTINES r