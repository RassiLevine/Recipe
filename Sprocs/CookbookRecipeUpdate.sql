create or alter proc dbo.CookbookRecipeUpdate(
    @CookbookRecipeId int = 0,
    @CookbookId int = 0,
    @RecipeId int = 0,
    @Seq int = 0,
    @Message varchar(500) = '' output
)
as
begin
    select @CookbookRecipeId = ISNULL(@CookbookRecipeId, 0), @CookbookId = ISNULL(@CookbookId, 0)
declare @return int = 0

    if @CookbookRecipeId = 0
    begin

        insert CookbookRecipe(CookbookId, recipeId, seq)
        select @CookbookId, @RecipeId, @Seq

        --set @Message = 'Duplicate entry for CookbookId and Seq.'

        end

    else
    begin

    update CookbookRecipe
    set
    CookbookId = @CookbookId,
    recipeId = @RecipeId,
    Seq = @Seq
    where CookbookRecipeId = @CookbookRecipeId

    end
    
return @return

end
go

