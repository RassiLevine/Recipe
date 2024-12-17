create or alter proc dbo.MealsGet(
 @MealsId int = 0,
    @StaffId int = 0,
    @MealName varchar(30) = '',
    @Active bit = 1,
    @All bit = 1
)
as
begin
    declare @return int = 0

    select MealsId, StaffId, MealName, Active
    from Meals
    where MealsId = @MealsId 
    or @All = 1

    return @return
end
go


