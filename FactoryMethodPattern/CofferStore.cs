using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public abstract class CofferStore
    {
        public abstract Coffee CreateCoffee();

        public Coffee OrderCoffee()
        {
            Coffee coffee = CreateCoffee();

            coffee.Prepare();
            coffee.Burdening();

            return coffee;
        }

    }
}
