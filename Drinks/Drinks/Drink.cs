using System;

namespace Drinks
{
    public class Drink
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public bool IsCarbonated { get; private set; }
        public string Description
        {
            get { return GetDescription(); }
        }

        public Drink(string name, bool isCarbonated)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException(nameof(name));
            }

            this.Id = new Guid();
            this.Name = name;
            this.IsCarbonated = isCarbonated;
        }

        protected virtual string GetDescription()
        {
            return Name;
        }
    }
}
