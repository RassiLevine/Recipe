create or alter procedure dbo.RecipeUpdate(
    @RecipeId int = 0 output,
    @CuisineId int,
    @StaffId int,
    @RecipeName varchar (500),
    @Calories int, 
    @DateDraft date, 
    @DatePublished date, 
    @DateArchived date
)

as 
    begin 

        select @RecipeId = isnull(@recipeid, 0), @CuisineId = isnull(@cuisineid, 0), @Calories = isnull(@calories, 0)

        if @recipeid = 0
            begin
                insert recipe(cuisineid, staffid, recipename, calories )
                values(@CuisineId, @StaffId, @RecipeName, @Calories) 

                select @RecipeId = SCOPE_IDENTITY()
            end
        else 
            begin
                update recipe
                set 
                cuisineid = @CuisineId,
                staffid = @StaffId,
                recipename = @RecipeName,
                calories = @Calories,
                datedraft = @DateDraft,
                datepublished = @DatePublished,
                datearchived = @DateArchived
                where recipeid = @RecipeId
            end
    end
    go