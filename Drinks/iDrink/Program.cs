using Drinks;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace iDrink
{
    class Program
    {
        static void Main(string[] args)
        {
            var oDrinkManager = new DrinkManager();
            var drinksToDisplay = new StringBuilder();

            oDrinkManager.AddJuice("Oranje", "oranges", false);
            oDrinkManager.AddBeer("Budweiser", 5, true);
            oDrinkManager.AddSoda("Pepsi", true);

            oDrinkManager.AddSoda("7 Up", true);
            oDrinkManager.AddBeer("Grolsch", 7, true);
            oDrinkManager.AddBeer("Stella Artois", 5, true);
            oDrinkManager.AddJuice("Apple", "apples", false);
            oDrinkManager.AddJuice("CranMango", "cranberries and mangoes", false);

            oDrinkManager.GetDrinks().ToList().ForEach(x => {
                if (drinksToDisplay.Length > 0)
                {
                    drinksToDisplay.Append(" ");
                }

                drinksToDisplay.Append(x.Description).Append(".");

                //For the record I used a stringbuilder in case we figure out a list of 20,000+ juice, beer and soda. Otherwise a string would do
            });

            Console.WriteLine(string.Format("\"{0}\"", drinksToDisplay.ToString()));
        }
    }
}

/*
 * In entities all params are initiated through constructor. Also using private set in case you need to serialize/deserialize entities in the future
 * DrinkManager is my aggregate root
 */
