using System;
using System.Collections.Generic;
using System.Text;

namespace Drinks
{
    public interface IDrinkManager
    {
        Drink GetDrink(Guid id);
        void AddJuice(string name, string fruit, bool isCarbonated);
        void AddSoda(string name, bool isCarbonated);
        void AddBeer(string name, decimal alcoholContent, bool isCarbonated);
        void RemoveDrink(Guid id);
        IEnumerable<Drink> GetDrinks();
    }
}
