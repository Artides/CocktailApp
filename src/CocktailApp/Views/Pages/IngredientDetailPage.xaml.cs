using CocktailApp.ViewModels;

namespace CocktailApp.Views.Pages;

public partial class IngredientDetailPage : ContentPage
{
	public IngredientDetailPage()
	{
		InitializeComponent();
        this.AssignViewModel<IngredientDetailVM>();
    }
}