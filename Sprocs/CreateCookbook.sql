create or alter proc dbo.CreateCookbook(
    @StaffId int = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    insert Cookbook (CookbookName, Price, StaffId, Active)
    select concat('Recipes by ', s.StaffFirstName, ' ', s.StaffLastName ), count(r.RecipeId)* 1.33, s.StaffId, 0
    from staff s 
    join recipe r
    on s.StaffId = r.StaffId
    where s.staffId = @StaffId
    group by s.StaffId,  s.StaffFirstName, s.StaffLastName
 
    insert CookbookRecipe (CookbookId, recipeId, Seq)
    select c.CookbookId, r.RecipeId, ROW_NUMBER() over (order by r.RecipeName)
    from Cookbook c
    join Staff s
    on s.StaffId = c.StaffId
    join Recipe r
    on r.StaffId = s.StaffId
    where s.StaffId = @StaffId
    and c.CookbookName = concat('Recipes by ', s.StaffFirstName, ' ', s.StaffLastName)

    return @return
end

/*select * from Cookbook C 
join CookbookRecipe r 
on r.CookbookId = c.CookbookId
where c.CookbookName like 'recipes by%'
*/

