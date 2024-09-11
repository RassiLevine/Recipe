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
    select cb.cookbookid, r.recipeid, ROW_NUMBER() over (order by r.RecipeName)
    from recipe r 
    join Staff s on r.StaffId = s.StaffId 
    join Cookbook cb on cb.StaffId = s.StaffId
    where s.StaffId = @staffId
    and cb.CookbookName = concat('Recipes by', s.StaffFirstName, s.StaffLastName)

    return @return
end
go
