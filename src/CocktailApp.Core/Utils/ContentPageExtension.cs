using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailApp.Core.Utils;

public static class ContentPageExtension
{
	public static T? AssignViewModel<T>(this ContentPage page) where T : BaseViewModel
	{
		var VM = ServiceLocatorHelper.GetService<T>() ?? null;

		if (VM != null)
		{
			page.BindingContext = VM;
			page.Appearing += (s, e) => VM.OnAppearing();
			page.Disappearing += (s, e) => VM.OnDisappearing();
		}
		else
			throw new Exception($"Missing View Model '{nameof(T)}' in service provider. Please register it in ViewModelRegistration.cs");

		return VM;
	}
}
