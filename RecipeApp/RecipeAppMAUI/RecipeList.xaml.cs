using CPUFramework;
using RecipeSystem;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace RecipeAppMAUI;

public partial class RecipeList : ContentPage
{
	public RecipeList()
	{
		InitializeComponent();
        this.Loaded += RecipeList_Loaded;
	}

    private void BindData()
	{
		DataTable dt = Recipe.GetRecipeListDataTable();
		RecipeListLst.ItemsSource = dt.Rows;
	}
    private void RecipeList_Loaded(object? sender, EventArgs e)
    {
		BindData();
    }
}