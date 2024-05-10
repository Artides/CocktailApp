using CocktailApp.ViewModels;

namespace CocktailApp.Views.Pages;

public partial class IngredientSearchPage : ContentPage
{
	public IngredientSearchPage()
	{
		InitializeComponent();
		this.AssignViewModel<IngredientsSearchVM>();
	}
}