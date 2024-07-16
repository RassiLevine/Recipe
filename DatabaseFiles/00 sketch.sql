-- SM Excellent sketch! See comments, fix and resubmit.
use RecipeWebsiteDB
go 

select * from recipe
/*
-- SM You're missing the images.

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

-- SM Where do you store if you're using cups or kilo etc. And we also need a sequence column.
RecipeIngredient
    RecipeIngredientId
    RecipeId (FK)
    IngredientId (FK)
    IngredientAmt 

-- SM No need fro extra table. Add date columns in recipe table for all dates. And add computed status column based on latest date.
RecipeStatus
    RecipeStatusId
    RecipeId(FK)
    RecipeStatus, must be either draft, published, or archived
    DateChanged, timestamp getdate()
---

-- SM We need to know if the meal is active or not.
Meals
    MealId
    MealName, unique
    DateCreated timestamp getdate()

-- SM Add unique sequence column.
Course
    CourseId
    CourseType, unique

CourseMeal
    CourseMealId
    CourseId (FK)
    MealId (FK)
    meal and course id unique

-- SM The recipe can be in same course if it is in different meals. And a recipe can be in same meal if it's in different course.
CourseRecipe
    CourseRecipeId
    CourseID(FK)
    RecipeId(FK)

-- SM A cookbook also needs a staff member that created it. And we also need to know whether it's active or not.
Cookbook
    CookbookId
    RecipeId(FK)
-- SM Should be unique.
    CookbookName
    Price
    DateCreated timestamp getdate()

Staff
    StaffId
    StaffFirstName
    StaffLastName
-- SM Should be unique.
    UserName

-- SM A recipe only has one staff member that created it.
RecipeStaff
    RecipeStaffId
    RecipeId(FK)
    StaffId(FK)

-- SM A meal only has one staff member that created it.
MealStaff
    MealStaffId
    MealId(FK)
    StaffId(FK)




*/