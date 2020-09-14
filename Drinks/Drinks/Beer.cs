using System;
using System.Collections.Generic;
using System.Text;

namespace Drinks
{
    public class Beer : Drink
    {
        public decimal AlcoholContent { get; private set; }

        public Beer(string name, decimal alcoholContent, bool isCarbonated): base(name, isCarbonated)
        {
            if (alcoholContent < 0)
            {
                throw new ArgumentException(nameof(alcoholContent));
            }

            this.AlcoholContent = alcoholContent;
        }

        protected override string GetDescription() => string.Format("{0}, {1}, {2}%", Name, (IsCarbonated? "carbonated" : "not carbonated"), AlcoholContent);
    }
}
