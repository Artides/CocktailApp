using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailApp.Core.Services
{
    public interface ITranslationService
    {
        string GetString(string key);
    }
}
