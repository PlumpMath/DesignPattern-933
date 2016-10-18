using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class StarbuckCoffee : Coffee
    {
        public override void Burdening()
        {
            Console.WriteLine("this is starbuck coffee bruding");
        }

        public override void Prepare()
        {
            Console.WriteLine("this is starbuck coffee prepare");
        }
    }
}
