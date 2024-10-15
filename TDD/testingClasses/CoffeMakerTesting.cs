using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD
{
    public class CoffeMakerTesting
    {
        public void ShouldReturnTrueIfThereIsCoffee() {
            CoffeMaker coffeMaker = new CoffeMaker(10);
            bool result = coffeMaker.HasCoffe(5);

            Assert.AreEqual(true, result);
        }

        public void ShouldReturnFalseIfThereIsNoCoffee() {
            CoffeMaker coffeMaker = new CoffeMaker(10);
            bool result = coffeMaker.HasCoffe(11);

            Assert.AreEqual(false, result);
        }

        public void ShouldSubtractCoffee() {
            CoffeMaker coffeMaker = new CoffeMaker(10);
            
            coffeMaker.GiveCoffe(7);

            Assert.AreEqual(3, coffeMaker.GetCoffeAmount());
        }
    }
}