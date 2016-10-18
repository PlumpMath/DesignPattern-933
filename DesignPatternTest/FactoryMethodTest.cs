using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using FactoryMethodPattern;

namespace DesignPatternTest
{
    [TestClass]
    public class FactoryMethodTest
    {
        [TestMethod]
        public void Confirm_Is_The_Starbuckcoffee()
        {
            CofferStore cofferStore = new StarbuckStore();
            Coffee coffer = cofferStore.OrderCoffee();
            Assert.IsInstanceOfType(coffer, typeof(StarbuckCoffee));

        }

        [TestMethod]
        public void Confirm_Is_The_Coster_Store()
        {
            CofferStore cofferStore = new CosterStore();
            Coffee coffer = cofferStore.OrderCoffee();
            Assert.IsInstanceOfType(cofferStore, typeof(CosterStore));

        }
    }
}
