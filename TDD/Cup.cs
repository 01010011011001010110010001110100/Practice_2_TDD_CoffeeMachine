using System;

namespace TDD
{
    public class Cup
    {
        private int cupsAmount;
        private int content;

        public Cup(int cupsAmount, int content) {
            this.cupsAmount = cupsAmount;
            this.content = content;
        }

        public void SetCupsAmmount(int amount) {
            cupsAmount = amount;
        }

        public int GetCupsAmmount() {
            return cupsAmount;
        }
    
        public void SetContent(int amount) {
            content = amount;
        }

        public int GetContent() {
            return content;
        }

        public bool HasCups(int amount = 1) {
            return cupsAmount >= amount;
        }

        public void GiveCups(int amount) {
            int cupsAviable = cupsAmount - amount;
            cupsAmount = cupsAviable < 0 ? 0 : cupsAviable;
        }
    }
}