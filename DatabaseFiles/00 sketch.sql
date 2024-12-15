
use RecipeWebsiteDB
go 

select * from recipe
/*

Directions
    DirectionId
    DirectionNum
    Directions

Recipe
    recipeId
-- SM A recipe has multiple directions.
    DirectionId(FK)
    RecipeName, unique


Ingredeints
    IngredientId
    IngredientName, unique

Cuisine
    CuisineId
    CuisineName, unique


RecipeIngredient
    RecipeIngredientId
    RecipeId (FK)
    IngredientId (FK)
    IngredientAmt 


RecipeStatus
    RecipeStatusId
    RecipeId(FK)
    RecipeStatus, must be either draft, published, or archived
    DateChanged, timestamp getdate()
---


Meals
    MealId
    MealName, unique
    DateCreated timestamp getdate()


Course
    CourseId
    CourseType, unique

CourseMeal
    CourseMealId
    CourseId (FK)
    MealId (FK)
    meal and course id unique


CourseRecipe
    CourseRecipeId
    CourseID(FK)
    RecipeId(FK)


Cookbook
    CookbookId
    RecipeId(FK)

    CookbookName
    Price
    DateCreated timestamp getdate()

Staff
    StaffId
    StaffFirstName
    StaffLastName

    UserName


RecipeStaff
    RecipeStaffId
    RecipeId(FK)
    StaffId(FK)


MealStaff
    MealStaffId
    MealId(FK)
    StaffId(FK)




*/