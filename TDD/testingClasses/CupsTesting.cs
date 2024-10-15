using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD
{
    public class CupsTesting
    {
        public void ShouldReturnTrueIfCupsExist() {
            Cup smallCups = new Cup(2,10);
            bool result = smallCups.HasCups(1);
            
            Assert.AreEqual(true, result);
        }

        public void ShouldReturnFalseIfCupsDoNotExist() {
            Cup smallCups = new Cup(1,10);
            bool result = smallCups.HasCups(2);
            
            Assert.AreEqual(false, result);
        }

        public void ShouldSubtractNumberOfCups() {
            Cup smallCups = new Cup(5,10);

            smallCups.GiveCups(1);
            
            Assert.AreEqual(4, smallCups.GetCupsAmmount());
        }
    }
}