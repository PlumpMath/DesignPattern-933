﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class StarbuckStore : CofferStore
    {
        public override Coffee CreateCoffee()
        {
            return new StarbuckCoffee();
        }
    }
}