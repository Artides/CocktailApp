using CocktailApp.ViewModels;

namespace CocktailApp.Views.Pages;

public partial class CocktailsSearchPage : ContentPage
{
	public CocktailsSearchPage()
	{
		InitializeComponent();
		this.AssignViewModel<CocktailsSearchVM>();
	}
}