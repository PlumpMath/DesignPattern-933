using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class CosterCoffee : Coffee
    {
        public override void Burdening()
        {
            Console.WriteLine("this is coster coffee bruding");
        }

        public override void Prepare()
        {
            Console.WriteLine("this is coster coffee prepare");
        }
    }
}
