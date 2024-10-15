using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD
{
    public class SugarBowlTesting
    {
        private SugarBowl sugarBowl;

        public void SetUp() {
            sugarBowl = new SugarBowl(10);
        }

        public void ShouldReturnTrueIfThereIsEnoughSugar() {
            bool result = sugarBowl.HasSugar(5);

            Assert.AreEqual(true, result);

            result = sugarBowl.HasSugar(10);

            Assert.AreEqual(true, result);
        }

        public void ShouldReturnFalseBecauseThereIsNotEnoughSugar() {
            bool result = sugarBowl.HasSugar(15);

            Assert.AreEqual(false, result);
        }

        public void ShouldSubtractSugar() {
            sugarBowl.GiveSugar(5);
    
            Assert.AreEqual(5, sugarBowl.GetSugarAmount());

            sugarBowl.GiveSugar(2);

            Assert.AreEqual(3, sugarBowl.GetSugarAmount());
        }
    }
}