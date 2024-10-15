using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD
{
    public class CoffeMachineTesting
    {
        
        private CoffeMaker coffeMaker;
        private Cup smallCups;
        private Cup mediumCups;
        private Cup BigCups;
        private SugarBowl sugarBowl;
        private CoffeeMachine coffeeMachine;


        public void SetUp() {
            coffeMaker = new CoffeMaker(50);
            smallCups = new Cup(5,10);
            mediumCups = new Cup(5,20);
            BigCups = new Cup(5,30);
            sugarBowl = new SugarBowl(20);

            coffeeMachine = new CoffeeMachine();
            coffeeMachine.SetCoffeMaker(coffeMaker);
            coffeeMachine.SetSmallCups(smallCups);
            coffeeMachine.SetMediumCups(mediumCups);
            coffeeMachine.SetBigCups(BigCups);
            coffeeMachine.SetSugarBowl(sugarBowl);
        }

        public void ShouldReturnASmallCup() {
            Cup cup = coffeeMachine.GetCupType(CupTypes.SMALL);

            Assert.AreEqual(coffeeMachine.smallCups, cup);
        }

        public void ShouldReturnAMediumCup() {
            Cup cup = coffeeMachine.GetCupType(CupTypes.MEDIUM);

            Assert.AreEqual(coffeeMachine.mediumCups, cup);
        }

        public void ShouldReturnABigCup() {
            Cup cup = coffeeMachine.GetCupType(CupTypes.BIG);

            Assert.AreEqual(coffeeMachine.bigCups, cup);
        }      

        public void ShouldReturnNoCups() {
            Cup cup = coffeeMachine.GetCupType(CupTypes.SMALL);

            string result = coffeeMachine.GetCoffeCup(cup,10,2);

            Assert.AreEqual("There are not enough cups", result);
        }  

        public void ShouldReturnNoCoffe() {
            
            CoffeMaker coffeMaker = new CoffeMaker(5);
            coffeeMachine.SetCoffeMaker(coffeMaker);

            Cup cup = coffeeMachine.GetCupType(CupTypes.SMALL);

            string result = coffeeMachine.GetCoffeCup(cup,1,2);

            Assert.AreEqual("There is not enough coffee", result);
        }  

        public void ShouldReturnNoSugar() {
            
            SugarBowl sugarBowl = new SugarBowl(2);
            coffeeMachine.SetSugarBowl(sugarBowl);

            Cup cup = coffeeMachine.GetCupType(CupTypes.SMALL); 

            string result = coffeeMachine.GetCoffeCup(cup,1,3);

            Assert.AreEqual("There is not enough sugar", result);
        }  

        public void ShouldSubtractCoffee() {
            Cup cup = coffeeMachine.GetCupType(CupTypes.SMALL);

            coffeeMachine.GetCoffeCup(cup, 1, 3);

            int result = coffeeMachine.GetCoffeMaker().GetCoffeAmount();

            Assert.AreEqual(40, result);
        }

        public void ShouldSubtractCup() {
            Cup cup = coffeeMachine.GetCupType(CupTypes.SMALL);

            coffeeMachine.GetCoffeCup(cup, 1, 3);

            int result = coffeeMachine.GetSmallCups().GetCupsAmmount();

            Assert.AreEqual(4, result);
        }

        public void ShouldSubtractSugar() {
            Cup cup = coffeeMachine.GetCupType(CupTypes.SMALL);

            coffeeMachine.GetCoffeCup(cup, 1, 3);

            int result = coffeeMachine.GetSugarBowl().GetSugarAmount();

            Assert.AreEqual(17, result);
        }

        public void ShouldReturnCongratulations() {
            Cup cup = coffeeMachine.GetCupType(CupTypes.SMALL);

            string result = coffeeMachine.GetCoffeCup(cup, 1, 3);

            Assert.AreEqual("Congratulations! Here is your coffee (Procede a tomarlo y se lo bebe de una)", result);
        }
    }
}