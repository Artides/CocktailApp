using System.Collections.ObjectModel;

namespace CocktailApp.Views.Components;

public partial class CocktailWelcomeContent : ContentView
{
    public static readonly BindableProperty DrinksProperty =
         BindableProperty.Create(nameof(Drinks),
             typeof(ICollection<Drink>),
             typeof(CocktailWelcomeContent),
             new ObservableCollection<Drink>(),
             BindingMode.TwoWay,
             propertyChanged: OnDrinksChanged);

    public ICollection<Drink> Drinks
    {
        get => (ICollection<Drink>)GetValue(DrinksProperty);
        set { this.SetValue(DrinksProperty, value); }
    }

    private Drink? _drink1;
    private Drink? _drink2;
    private int _currentIndex = 0;

    public CocktailWelcomeContent()
    {
        InitializeComponent();
    }
    private static void OnDrinksChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is CocktailWelcomeContent view && newValue != null)
        {
            view.Drinks = (ICollection<Drink>)newValue;
            view.vslDrink1.IsVisible = true;
            view.vslDrink2.IsVisible = false;
            view._drink1 = view.Drinks.FirstOrDefault();
            if (view._drink1 != null)
            {
                view.imgDrink1.Source = view._drink1.StrDrinkThumb;
                view.txtDrink1.Text = view._drink1.StrDrink;
            }
            view._currentIndex = 0;
        }
    }

    private void ArrowSx_Clicked(object sender, EventArgs e)
    {
        _currentIndex--;
        if (_currentIndex < 0) _currentIndex = Drinks.Count() - 1;
        UpdateDrinks();
    }

    private void ArrowDx_Clicked(object sender, EventArgs e)
    {
        _currentIndex++;
        if (_currentIndex > Drinks.Count() - 1) _currentIndex = 0;
        UpdateDrinks();
    }

    private void UpdateDrinks()
    {
        if (Drinks?.Any() == false) return;

        if (vslDrink1.IsVisible)
        {
            _drink2 = Drinks?.ElementAt(_currentIndex);
        }
        else
        {
            _drink1 = Drinks?.ElementAt(_currentIndex);
        }
        vslDrink1.IsVisible = !vslDrink1.IsVisible;
        vslDrink2.IsVisible = !vslDrink2.IsVisible;
        imgDrink1.Source = _drink1?.StrDrinkThumb;
        txtDrink1.Text = _drink1?.StrDrink;
        imgDrink2.Source = _drink2?.StrDrinkThumb;
        txtDrink2.Text = _drink2?.StrDrink;
    }


}