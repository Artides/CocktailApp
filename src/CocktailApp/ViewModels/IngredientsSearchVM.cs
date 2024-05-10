using CocktailApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailApp.ViewModels;

internal partial class IngredientsSearchVM : BaseViewModel
{
    private readonly IIngredientService _ingredientsSearchVM;

    [ObservableProperty]
    IEnumerable<Ingredient>? filteredIngredients;

    [ObservableProperty]
    string? searchString;

    [ObservableProperty]
    bool initCompleted;

    List<Ingredient> _allIngredients = [];

    public IngredientsSearchVM(INavigationService navigationService, IIngredientService ingredientsSearchVM) : base(navigationService)
    {
        _ingredientsSearchVM = ingredientsSearchVM;
    }

    public override Task OnAppearing()
    {
        InitCompleted = false;

        Task.Run(() =>
        {
            if (SearchString.IsNotEmpty())
                UpdateIngredientList(SearchString);
            else
                LoadAllIngredients();
            InitCompleted = true;
        });

        return Task.CompletedTask;
    }


    [RelayCommand]
    void GoToDetail(Ingredient selectedIngredient)
    {
        KeyboardHelper.Hide();
        _navigationService.NavigateToPage(nameof(IngredientDetailVM), IngredientDetailVM.GetNavigationParameter(selectedIngredient.StrIngredient));
    }

    async void LoadAllIngredients()
    {
        var result = await _ingredientsSearchVM.GetAllIngredients();
        if (result != null) _allIngredients.AddRange(result);

       FilteredIngredients = _allIngredients;
    }

    partial void OnSearchStringChanged(string? value)
    {
        UpdateIngredientList(value);
    }

    private void UpdateIngredientList(string? value)
    {
        if (value.IsEmpty())
        {
            FilteredIngredients = _allIngredients;
        }
        else
        {
            FilteredIngredients = _allIngredients.Where(x => x.StrIngredient?.Contains(value, StringComparison.CurrentCultureIgnoreCase) == true);
        }
    }
}