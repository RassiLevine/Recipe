create or alter function dbo.RecipeDesc(@recipeid int)
returns varchar(120)
as
begin

    declare @value varchar(120) = ''

        select @value = concat(r.RecipeName, ' (', c.CuisineType, ') has ', count(distinct ri.ingredientId), ' ingredients and ', count(distinct d.Direction), ' steps.')
        from recipe r
        join cuisine c 
        on r.CuisineId = c.CuisineId
        join RecipeIngredient ri
        on r.RecipeId = ri.RecipeId
        join Directions d
        on d.RecipeId = r.RecipeId
        where r.RecipeId = @recipeid
        group by r.RecipeName, c.CuisineType
    
    return @value
end
go

/*
TEST
select recipedesc = dbo.RecipeDesc(r.recipeid)
from recipe r
*/