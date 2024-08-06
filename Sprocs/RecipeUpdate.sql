create or alter procedure dbo.RecipeUpdate(
    @recipeid int = 0 output,
    @cuisineid int,
    @staffid int,
    @recipeName varchar (500),
    @calories int, 
    @datedraft date, 
    @datepublished date, 
    @datearchived date
)

as 
    begin 

        select @recipeid = isnull(@recipeid, 0), @cuisineid = isnull(@cuisineid, 0), @calories = isnull(@calories, 0)

        if @recipeid = 0
            begin
                insert recipe(cuisineid, staffid, recipename, calories )--, datedraft, datepublished, datearchived)
                values(@cuisineid, @staffid, @recipename, @calories) --, @datedraft, @datepublished, @datearchived)  

                select @recipeid = SCOPE_IDENTITY()
            end
        else 
            begin
                update recipe
                set 
                cuisineid = @cuisineid,
                recipename = @recipeName,
                calories = @calories,
                datedraft = @datedraft,
                datepublished = @datepublished,
                datearchived = @datearchived
                where recipeid = @recipeid
            end
    end
    go