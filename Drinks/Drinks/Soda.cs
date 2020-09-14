using System;
using System.Collections.Generic;
using System.Text;

namespace Drinks
{
    public class Soda : Drink
    {
        public Soda(string name, bool isCarbonated) : base(name, isCarbonated) { }

        protected override string GetDescription() => string.Format("{0}, {1}", Name, IsCarbonated ? "carbonated" : "not carbonated");
    }
}
