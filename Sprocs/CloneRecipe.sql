create or alter proc dbo.CloneRecipe(
    @RecipeId int = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

insert recipe(RecipeName, Calories, CuisineId, StaffId, r.DateDraft, DatePublished, DateArchived)
select concat(r.RecipeName, '-clone'), r.Calories, r.CuisineId, r.StaffId, r.DateDraft, r.DatePublished, r.DateArchived
from recipe r
where r.RecipeId = @RecipeId

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

    return @return
end
go
