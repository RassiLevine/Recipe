use RecipeWebsiteDB
go
/*select concat('grant execute on ', r.ROUTINE_NAME, ' to recipeapprole')
from INFORMATION_SCHEMA.ROUTINES r*/

grant execute on RecipeDesc to recipeapprole
grant execute on TotalCaloriesPerMeal to recipeapprole
grant execute on CloneRecipe to recipeapprole
grant execute on CookbookActiveUpdate to recipeapprole
grant execute on CookbookDelete to recipeapprole
grant execute on CookbookGet to recipeapprole
grant execute on CookbookList to recipeapprole
grant execute on CookbookRecipeDelete to recipeapprole
grant execute on CookbookRecipeUpdate to recipeapprole
grant execute on CookbookRecipeGet to recipeapprole
grant execute on CookbookUpdate to recipeapprole
grant execute on CourseDelete to recipeapprole
grant execute on CourseGet to recipeapprole
grant execute on CourseUpdate to recipeapprole
grant execute on CreateCookbook to recipeapprole
grant execute on CuisineDelete to recipeapprole
grant execute on CuisineUpdate to recipeapprole
grant execute on RecipeDelete to recipeapprole
grant execute on DashboardGet to recipeapprole
grant execute on DirectionsDelete to recipeapprole
grant execute on DirectionsUpdate to recipeapprole
grant execute on DirectionsGet to recipeapprole
grant execute on IngredientsGet to recipeapprole
grant execute on IngredientsDelete to recipeapprole
grant execute on IngredientsUpdate to recipeapprole
grant execute on MealsList to recipeapprole
grant execute on MeasurementTypeGet to recipeapprole
grant execute on MeasurementTypeDelete to recipeapprole
grant execute on MeasurementTypeUpdate to recipeapprole
grant execute on RecipeIngredientDelete to recipeapprole
grant execute on RecipeIngredientsGet to recipeapprole
grant execute on RecipeIngredientUpdate to recipeapprole
grant execute on RecipeList to recipeapprole
grant execute on RecipeGet to recipeapprole
grant execute on RecipeUpdate to recipeapprole
grant execute on CuisineGet to recipeapprole
grant execute on StatusUpdate to recipeapprole
grant execute on StaffGet to recipeapprole
grant execute on StaffDelete to recipeapprole
grant execute on StaffUpdate to recipeapprole
grant execute on StatusGet to recipeapprole