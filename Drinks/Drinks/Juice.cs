using System;
using System.Collections.Generic;
using System.Text;

namespace Drinks
{
    public class Juice: Drink
    {
        public string MadeFromFruit { get; private set; }

        public Juice(string name, string madeFromFruit, bool isCarbonated) : base(name, isCarbonated)
        {
            if (string.IsNullOrEmpty(madeFromFruit))
            {
                throw new ArgumentException(nameof(madeFromFruit));
            }

            this.MadeFromFruit = madeFromFruit;
        }

        protected override string GetDescription() => string.Format("{0} juice, {1}, made from {2}", Name, (IsCarbonated ? "carbonated" : "not carbonated"), MadeFromFruit?.ToLower());
    }
}

