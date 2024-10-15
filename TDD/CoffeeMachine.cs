using System;

namespace TDD
{
    public class CoffeeMachine
    {
        private CoffeMaker coffeMaker;
        public Cup smallCups;
        public Cup mediumCups;
        public Cup bigCups;
        private SugarBowl sugarBowl;


        public Cup GetCupType(CupTypes type) {
            switch(type){
                case CupTypes.SMALL: return smallCups;
                case CupTypes.MEDIUM: return mediumCups;
                case CupTypes.BIG: return bigCups;
                default: return smallCups;
            }
        }

        public string GetCoffeCup(Cup cup, int cupsAmount, int sugarAmount) {
            
            // Guard Clauses
            if (!cup.HasCups(cupsAmount)) return "There are not enough cups";
            if (!coffeMaker.HasCoffe(cup.GetContent() * cupsAmount)) return "There is not enough coffee";
            if (!sugarBowl.HasSugar(sugarAmount)) return "There is not enough sugar";

            // Subtract resources
            cup.GiveCups(cupsAmount);
            coffeMaker.GiveCoffe(cup.GetContent() * cupsAmount);
            sugarBowl.GiveSugar(sugarAmount * cupsAmount);

            // Return Result
            return "Congratulations! Here is your coffee (Procede a tomarlo y se lo bebe de una)";
        }

        public void SetCoffeMaker(CoffeMaker coffeMaker) {
            this.coffeMaker = coffeMaker;
        }

        public void SetSmallCups(Cup smallCups) {
            this.smallCups = smallCups;
        }

        public void SetMediumCups(Cup mediumCups) {
            this.mediumCups = mediumCups;
        }

        public void SetBigCups(Cup bigCups) {
            this.bigCups = bigCups;
        }

        public void SetSugarBowl(SugarBowl sugarBowl) {
            this.sugarBowl = sugarBowl;
        }

        public CoffeMaker GetCoffeMaker() {
            return coffeMaker;
        }

        public Cup GetSmallCups() {
            return smallCups;
        }

        public Cup GetMediumCups() {
            return mediumCups;
        }

        public Cup GetBigCups() {
            return bigCups;
        }

        public SugarBowl GetSugarBowl() {
            return sugarBowl;
        }
    }
}