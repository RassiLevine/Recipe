

WITH MealDescriptions AS (
    SELECT MealName,
           CASE
               WHEN MealName = 'Breakfast Bash' THEN 'A hearty morning meal to start the day.'
               WHEN MealName = 'Brunch' THEN 'A mid-morning meal with a variety of delicious options.'
               WHEN MealName = 'Breakfast Treat' THEN 'A sweet and savory breakfast delight.'
               ELSE 'No description available.'
           END AS Description
    FROM Meals
)
UPDATE Meals
SET MealsDesc = md.Description
FROM Meals m
JOIN MealDescriptions md
    ON m.MealName = md.MealName;


    
    WITH RecipeVeganStatus AS (
    SELECT RecipeId,
           CASE
               WHEN RecipeName LIKE '%Vegan%' THEN 'YES' -- Mark as vegan if the name contains 'Vegan'
               ELSE 'NO' -- Otherwise, not vegan
           END AS IsVeganStatus
    FROM dbo.Recipe
)
UPDATE r
SET r.IsVegan = rvs.IsVeganStatus
FROM dbo.Recipe r
JOIN RecipeVeganStatus rvs ON r.RecipeId = rvs.RecipeId;

/*WITH SkillLevelCTE AS (
    SELECT CookbookId,
           CASE 
               WHEN Price <= 10 THEN 'Beginner'
               WHEN Price BETWEEN 10.01 AND 50 THEN 'Intermediate'
               ELSE 'Advanced'
           END AS SkillLevel
    FROM dbo.Cookbook
)
UPDATE dbo.Cookbook
SET SkillLevel = SkillLevelCTE.SkillLevel
FROM SkillLevelCTE
WHERE dbo.Cookbook.CookbookId = SkillLevelCTE.CookbookId*/
UPDATE dbo.Cookbook
SET SkillLevel = 
    CASE
        WHEN CookbookName LIKE '%Treats%' THEN 1   -- Treats for Two should be Beginner
        WHEN CookbookName LIKE '%Brunch%' THEN 2   -- Brunch Recipes should be Intermediate
        WHEN CookbookName LIKE '%Dinner%' THEN 3   -- Dinner in Two should be Advanced
        ELSE 1   -- Default to Beginner if no match
    END;