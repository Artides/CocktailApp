using CocktailApp.ViewModels;

namespace CocktailApp.Views.Pages;

public partial class CocktailDetailPage : ContentPage
{
	public CocktailDetailPage()
	{
		InitializeComponent();
		this.AssignViewModel<CocktailDetailVM>();
	}
}