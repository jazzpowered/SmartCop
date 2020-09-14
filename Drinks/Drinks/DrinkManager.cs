using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Drinks
{
    public class DrinkManager : IDrinkManager
    {
        protected List<Drink> drinkCollection;

        public DrinkManager()
        {
            this.drinkCollection = new List<Drink>();
        }

        public Drink GetDrink(Guid id) => this.drinkCollection.Find(x => x.Id == id);

        public void AddJuice(string name, string fruit, bool isCarbonated) => this.drinkCollection.Add(new Juice(name, fruit, isCarbonated));

        public void AddSoda(string name, bool isCarbonated) => this.drinkCollection.Add(new Soda(name, isCarbonated));

        public void AddBeer(string name, decimal alcoholContent, bool isCarbonated) => this.drinkCollection.Add(new Beer(name, alcoholContent, isCarbonated));

        public void RemoveDrink(Guid id) => this.drinkCollection.RemoveAll(x => x.Id == id);

        public IEnumerable<Drink> GetDrinks() => drinkCollection;
    }
}
