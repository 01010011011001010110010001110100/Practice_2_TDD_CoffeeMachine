using System;

namespace TDD
{
    public class SugarBowl
    {
        private int sugarAmount;

        public SugarBowl (int sugarAmount) {
            this.sugarAmount = sugarAmount;
        }

        public void SetSugarAmount(int amount) {
            sugarAmount = amount;
        }

        public int GetSugarAmount() {   
            return sugarAmount;
        }


        public bool HasSugar(int amount = 1) {
            return sugarAmount >= amount;
        }

        public void GiveSugar(int amount) {
            int sugarAviable = sugarAmount - amount;
            sugarAmount = sugarAviable < 0 ? 0 : sugarAviable;
        }
    }
}