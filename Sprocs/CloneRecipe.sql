create or alter proc dbo.CloneRecipe(
    @RecipeId int = 0 output,
    @DirectionId int = 0 output,
    @RecipeIngredientId int = 0 output,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0
    declare @CloneRecipeId int = 0 
select @RecipeId = ISNULL(@RecipeId, 0), @DirectionId = ISNULL(@DirectionId, 0), @RecipeIngredientId = ISNULL(@RecipeIngredientId,0)

insert recipe(RecipeName, Calories, CuisineId, StaffId)
select concat(r.RecipeName, '-clone'), r.Calories, r.CuisineId, r.StaffId
from recipe r
where r.RecipeId = @RecipeId

select @RecipeId = SCOPE_IDENTITY()

;with x as(
    select recipeName = concat(r.RecipeName, '-clone'), d.direction, d.DirectionSequence
    from directions d
    join recipe r
    on r.RecipeId = d.RecipeId
    where r.RecipeId = @RecipeId
)
insert Directions(recipeid, Direction, DirectionSequence)
select r.recipeid, x.direction, x.DirectionSequence
from x
join recipe r
on r.RecipeName = x.recipeName

select @DirectionId = SCOPE_IDENTITY()

;with x as(
    select recipename = concat(r.RecipeName, '-clone'), ri.IngredientAmt, ri.ingredientId, 
    ri.IngredientSequence, ri.MeasurementTypeId
    from RecipeIngredient ri
    join recipe r 
    on r.RecipeId= ri.RecipeId
    where r.RecipeId = @RecipeId
)
insert RecipeIngredient(RecipeId, IngredientAmt, ingredientId, IngredientSequence, MeasurementTypeId)
select r.recipeid, x.IngredientAmt, x.ingredientId, x.IngredientSequence, x.MeasurementTypeId
from x
join recipe r
on r.recipename = x.recipename

select @RecipeIngredientId = SCOPE_IDENTITY()

--return cloned recipe 

select top 1 @RecipeIngredientId = ri.RecipeIngredientId from RecipeIngredient ri order by RecipeIngredientId desc
select @DirectionId = d.DirectionsId from Directions d join recipe r on r.recipeid = d.DirectionsId where r.RecipeId = @RecipeId

select r.RecipeId, r.RecipeName, r.Calories, r.CuisineId, r.StaffId
from recipe r
where r.RecipeId = @RecipeId
return  @return

select d.DirectionsId, d.Direction, d.DirectionSequence
from Directions d
join recipe r
on r.RecipeId = d.RecipeId
where r.RecipeId = @RecipeId

select RecipeIngredientId, ri.RecipeId, IngredientAmt, ingredientId, IngredientSequence, MeasurementTypeId  
from RecipeIngredient ri
join recipe r
on r.RecipeId = ri.RecipeId
where r.RecipeId = @RecipeId

return @RecipeId
return @DirectionId
RETURN @RecipeIngredientId

end
go


exec CloneRecipe  @recipeid = 75
select *
from recipe r
join Directions d
on r.RecipeId = d.RecipeId
where r.RecipeId = 79