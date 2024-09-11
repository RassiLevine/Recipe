create or alter proc dbo.IngredientsUpdate(
    @IngredientsId int = 0,
    @IngredientName varchar(30) = '',
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    if @IngredientsId = 0
        begin

        insert Ingredients(IngredientName)
        values(@IngredientName)

        select @IngredientsId = SCOPE_IDENTITY()

        end
    else
    begin
    
        update Ingredients
        set
        IngredientName = @IngredientName
        where IngredientsId = @IngredientsId

    end
    return @return
end
go