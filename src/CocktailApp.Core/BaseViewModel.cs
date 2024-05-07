﻿using CocktailApp.Core.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CocktailApp.Core;

public abstract partial class BaseViewModel(INavigationService navigationService) : ObservableObject, IQueryAttributable
{
	protected readonly INavigationService _navigationService = navigationService;

	[RelayCommand]
	void GoBack() => GoBackCommandExecute();

	public virtual Task GoBackCommandExecute()
	{
		_navigationService.NavigateBack();
		return Task.CompletedTask;
	}
	public virtual void ApplyQueryAttributes(IDictionary<string, object> query) { }
	public virtual Task OnAppearing() => Task.CompletedTask;
	public virtual Task OnDisappearing() => Task.CompletedTask;

}