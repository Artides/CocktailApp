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
    private bool _drink1Visible = true;
    public CocktailWelcomeContent()
    {
        InitializeComponent();
    }
    private static void OnDrinksChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is CocktailWelcomeContent view && newValue != null)
        {
            view.Drinks = (ICollection<Drink>)newValue;
            view.vslDrink1.Opacity = 1;
            view.vslDrink2.Opacity = 0;
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
        UpdateDrinks(true);
    }

    private void ArrowDx_Clicked(object sender, EventArgs e)
    {
        _currentIndex++;
        if (_currentIndex > Drinks.Count() - 1) _currentIndex = 0;
        UpdateDrinks(false);
    }

    private void UpdateDrinks(bool left)
    {
        if (Drinks?.Any() == false) return;

        if (_drink1Visible)
        {
            _drink1Visible = false;
            _drink2 = Drinks?.ElementAt(_currentIndex);
            imgDrink2.Source = _drink2?.StrDrinkThumb;
            txtDrink2.Text = _drink2?.StrDrink;
            vslDrink1.FadeTo(0);
            vslDrink1.TranslateTo(left ? -100 : 100, 0).ContinueWith(t => vslDrink1.TranslationX = 0);
            vslDrink2.FadeTo(1);
        }
        else
        {
            _drink1Visible = true;
            _drink1 = Drinks?.ElementAt(_currentIndex);
            imgDrink1.Source = _drink1?.StrDrinkThumb;
            txtDrink1.Text = _drink1?.StrDrink;
            vslDrink2.FadeTo(0);
            vslDrink2.TranslateTo(left ? -100 : 100, 0).ContinueWith(t => vslDrink2.TranslationX = 0);
            vslDrink1.FadeTo(1);
        }


    }


    private void vslDrink1_Tapped(object sender, TappedEventArgs e)
    {

    }

    private void vslDrink2_Tapped(object sender, TappedEventArgs e)
    {

    }
}