#if IOS 
using UIKit;
#endif

namespace CocktailApp.Core.Utils
{
    public static class KeyboardHelper
    {
        public static void Hide()
        {
#if ANDROID
            var context = Platform.AppContext;
            var inputMethodManager = context.GetSystemService(Android.Content.Context.InputMethodService) as Android.Views.InputMethods.InputMethodManager;
            if (inputMethodManager != null)
            {
                var activity = Platform.CurrentActivity;
                var token = activity?.CurrentFocus?.WindowToken;
                inputMethodManager.HideSoftInputFromWindow(token, Android.Views.InputMethods.HideSoftInputFlags.None);
                activity?.Window?.DecorView.ClearFocus();
            }
#elif IOS
            UIApplication.SharedApplication.Delegate.GetWindow().EndEditing(true);
#endif

        }

    }
}
