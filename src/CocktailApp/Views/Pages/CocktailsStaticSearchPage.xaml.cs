using CocktailApp.ViewModels;

namespace CocktailApp.Views.Pages;

public partial class CocktailsStaticSearchPage : ContentPage
{
	public CocktailsStaticSearchPage()
	{
		InitializeComponent();
        this.AssignViewModel<CocktailsStaticSearchVM>();
    }
}