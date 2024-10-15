using System;

namespace TDD
{
    public class CoffeMaker
    {
        private int coffeAmount;

        public CoffeMaker (int coffeAmount) {
            this.coffeAmount = coffeAmount;
        }

        public void SetCoffeAmount(int amount) {
            coffeAmount = amount;
        }

        public int GetCoffeAmount() {
            return coffeAmount;
        }


        public bool HasCoffe(int amount = 1) {
            return coffeAmount >= amount;
        }

        public void GiveCoffe(int amount) {
            int coffeAviable = coffeAmount - amount;
            coffeAmount = coffeAviable < 0 ? 0 : coffeAviable;
        }
    }
}