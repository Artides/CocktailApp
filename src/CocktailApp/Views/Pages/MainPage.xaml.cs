using CocktailApp.ViewModels;

namespace CocktailApp.Views.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.AssignViewModel<MainPageVM>();	
    }

}
