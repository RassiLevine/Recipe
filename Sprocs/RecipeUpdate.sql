create or alter procedure dbo.RecipeUpdate(
    @RecipeId int = 0 output,
    @CuisineId int,
    @StaffId int,
    @RecipeName varchar (500),
    @Calories int, 
    @DateDraft date null output,
    @DatePublished date,
    @DateArchived date,
    @Mesage varchar(500) = '' output
)

as 
    begin 
        declare @return int = 0
        select @RecipeId = isnull(@RecipeId, 0), @CuisineId = isnull(@CuisineId, 0), @Calories = isnull(@Calories, 0), 
        @StaffId = ISNULL(@StaffId, 0), @DateDraft = ISNULL(@DateDraft, GETDATE()), @DatePublished = ISNULL(@DatePublished, null),
        @DateArchived = ISNULL(@DateArchived, null)

        if @recipeid = 0
        begin
                insert recipe(CuisineId, StaffId, RecipeName, Calories )
                values(@CuisineId, @StaffId, @RecipeName, @Calories) 

                select @RecipeId = SCOPE_IDENTITY()
                select @DateDraft = DATEFROMPARTS(year(GETDATE()), month(getdate()), day(getdate()))

            end
        else 
            begin
                update recipe
                set 
                CuisineId = @CuisineId,
                StaffId = @StaffId,
                RecipeName = @RecipeName,
                Calories = @Calories,
                DateDraft = @DateDraft,
                DatePublished = @DatePublished,
                DateArchived = @DateArchived
                where RecipeId = @RecipeId
            end
        return @return
    end
    go