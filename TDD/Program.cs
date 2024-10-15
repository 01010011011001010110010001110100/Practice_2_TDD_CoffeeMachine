using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TDD 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Runing all the Unit Test of all clases


            // Testers
            CupsTesting cupsTesting = new CupsTesting();
            CoffeMakerTesting coffeMakerTesting = new CoffeMakerTesting();
            SugarBowlTesting sugarBowlTesting = new SugarBowlTesting();
            CoffeMachineTesting coffeMachineTesting = new CoffeMachineTesting();
            
            // Set some stuff
            Console.Clear();

            // Cups Unit Testing
            Console.WriteLine("/// Starting Unit Testing for [ Cups ] \n");
            cupsTesting.ShouldReturnTrueIfCupsExist();
            Console.WriteLine("  | ShouldReturnTrueIfCupsExist - Ok ✓ \n");
            cupsTesting.ShouldReturnFalseIfCupsDoNotExist();
            Console.WriteLine("  | ShouldReturnFalseIfCupsDoNotExist - Ok ✓ \n");
            cupsTesting.ShouldSubtractNumberOfCups();
            Console.WriteLine("  | ShouldSubtractNumberOfCups - Ok ✓ \n\n");


            // CoffeeMaker Unit Testing
            Console.WriteLine("/// Starting Unit Testing for [ CoffeeMaker ] \n");
            coffeMakerTesting.ShouldReturnTrueIfThereIsCoffee();
            Console.WriteLine("  | ShouldReturnTrueIfThereIsCoffee - Ok ✓ \n");
            coffeMakerTesting.ShouldReturnFalseIfThereIsNoCoffee();
            Console.WriteLine("  | ShouldReturnFalseIfThereIsNoCoffee - Ok ✓ \n");
            coffeMakerTesting.ShouldSubtractCoffee();
            Console.WriteLine("  | ShouldSubtractCoffee - Ok ✓ \n\n");


            // SugarBowl Unit Testing
            Console.WriteLine("/// Starting Unit Testing for [ SugarBowl ] \n");
            sugarBowlTesting.SetUp();
            sugarBowlTesting.ShouldReturnTrueIfThereIsEnoughSugar();
            Console.WriteLine("  | ShouldReturnTrueIfThereIsEnoughSugar - Ok ✓ \n");
            sugarBowlTesting.ShouldReturnFalseBecauseThereIsNotEnoughSugar();
            Console.WriteLine("  | ShouldReturnFalseBecauseThereIsNotEnoughSugar - Ok ✓ \n");
            sugarBowlTesting.ShouldSubtractSugar();
            Console.WriteLine("  | ShouldSubtractSugar - Ok ✓ \n\n");


            // CoffeeMachine Unit Testing
            Console.WriteLine("/// Starting Unit Testing for [ CoffeeMachine ] \n");
            coffeMachineTesting.SetUp();
            coffeMachineTesting.ShouldReturnASmallCup();
            Console.WriteLine("  | ShouldReturnASmallCup - Ok ✓ \n");
            coffeMachineTesting.ShouldReturnAMediumCup();
            Console.WriteLine("  | ShouldReturnAMediumCup - Ok ✓ \n");
            coffeMachineTesting.ShouldReturnABigCup();
            Console.WriteLine("  | ShouldReturnABigCup - Ok ✓ \n");
            coffeMachineTesting.ShouldReturnNoCups();
            Console.WriteLine("  | ShouldReturnNoCups - Ok ✓ \n");
            coffeMachineTesting.SetUp();
            coffeMachineTesting.ShouldReturnNoCoffe();
            Console.WriteLine("  | ShouldReturnNoCoffe - Ok ✓ \n");
            coffeMachineTesting.SetUp();
            coffeMachineTesting.ShouldReturnNoSugar();
            Console.WriteLine("  | ShouldReturnNoSugar - Ok ✓ \n");
            coffeMachineTesting.SetUp();
            coffeMachineTesting.ShouldSubtractCoffee();
            Console.WriteLine("  | ShouldSubtractCoffee - Ok ✓ \n");
            coffeMachineTesting.SetUp();
            coffeMachineTesting.ShouldSubtractCup();
            Console.WriteLine("  | ShouldSubtractCup - Ok ✓ \n");
            coffeMachineTesting.SetUp();
            coffeMachineTesting.ShouldSubtractSugar();
            Console.WriteLine("  | ShouldSubtractSugar - Ok ✓ \n");
            coffeMachineTesting.SetUp();
            coffeMachineTesting.ShouldReturnCongratulations();
            Console.WriteLine("  | ShouldReturnCongratulations - Ok ✓ \n\n");

            // All the test completer
            Console.WriteLine("[*] ✓ All Unit Tests Were Executed Correctly ✓ \n\n");
            Console.WriteLine("* Press Any Key to Execute The CoffeMachine... *");
            Console.ReadKey();

            // Start the program

            // Set Up
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            coffeeMachine.SetCoffeMaker(new CoffeMaker(100));
            coffeeMachine.SetSugarBowl(new SugarBowl(100));
            coffeeMachine.SetSmallCups(new Cup(20,3));
            coffeeMachine.SetMediumCups(new Cup(10,5));
            coffeeMachine.SetBigCups(new Cup(5,7));
            string answer = string.Empty;
            CupTypes typeCupSeleted = CupTypes.SMALL;
            int amountCupsSelected = 0;
            int amountSugarSelected = 0;

            while (true)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("| C O F F E  -  M A C H I N E | \n\n");
                    Console.WriteLine("[*] Select cup size:");
                    Console.WriteLine("   1 - SMALL");
                    Console.WriteLine("   2 - MEDIUM");
                    Console.WriteLine("   3 - BIG");
                    Console.WriteLine("   4 - [ Close program ]");

                    answer = Console.ReadLine()!;
                    if (ValidAnswer(answer, new String[]{"1","2","3","4"})) break;   
                }

                switch (answer)
                {
                    case "1": typeCupSeleted = CupTypes.SMALL; break;
                    case "2": typeCupSeleted = CupTypes.MEDIUM; break;
                    case "3": typeCupSeleted = CupTypes.BIG; break;
                    case "4": Environment.Exit(0); break;
                }
                

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("| C O F F E  -  M A C H I N E | \n\n");
                    Console.WriteLine("[*] Select the quantity of cups:");
                    Console.WriteLine("   1 - 1 Cup");
                    Console.WriteLine("   2 - 2 Cups");
                    Console.WriteLine("   3 - 3 Cups");
                    Console.WriteLine("   4 - 4 Cups");
                    Console.WriteLine("   5 - [ Close program ]");

                    answer = Console.ReadLine()!;
                    if (ValidAnswer(answer, new string[]{"1","2","3","4","5"})) break;
                }

                switch (answer)
                {
                    case "1": amountCupsSelected = 1; break;
                    case "2": amountCupsSelected = 2; break;
                    case "3": amountCupsSelected = 3; break;
                    case "4": amountCupsSelected = 4; break;
                    case "5": Environment.Exit(0); break;
                }

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("| C O F F E  -  M A C H I N E | \n\n");
                    Console.WriteLine("[*] Select the spoonfuls of sugar:");
                    Console.WriteLine("   1 - 0 g (No sugar)");
                    Console.WriteLine("   2 - 5 g (1 teaspoon)");
                    Console.WriteLine("   3 - 10 g (2 teaspoon)");
                    Console.WriteLine("   4 - 15 g (3 teaspoon)");
                    Console.WriteLine("   5 - 20 g (4 teaspoon)");
                    Console.WriteLine("   6 - [ Close program ]");

                    answer = Console.ReadLine()!;
                    if (ValidAnswer(answer, new string[]{"1","2","3","4","5","6"})) break;
                }

                switch (answer)
                {
                    case "1": amountSugarSelected = 0; break;
                    case "2": amountSugarSelected = 5; break;
                    case "3": amountSugarSelected = 10; break;
                    case "4": amountSugarSelected = 15; break;
                    case "5": amountSugarSelected = 20; break;
                    case "6": Environment.Exit(0); break;
                }

                string result = coffeeMachine.GetCoffeCup(
                    coffeeMachine.GetCupType(typeCupSeleted),
                    amountCupsSelected,
                    amountSugarSelected
                );

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("| C O F F E  -  M A C H I N E | \n\n");
                    Console.WriteLine(result);
                    Console.WriteLine("\nMACHINE RESOURCES STATE:\n");
                    Console.WriteLine($"    - SmallCupsAviable: [{coffeeMachine.GetSmallCups().GetCupsAmmount()}]");
                    Console.WriteLine($"    - MediumCupsAviable: [{coffeeMachine.GetMediumCups().GetCupsAmmount()}]");
                    Console.WriteLine($"    - BigCupsAviable: [{coffeeMachine.GetBigCups().GetCupsAmmount()}]\n");
                    Console.WriteLine($"    - CoffeeAviable: [{coffeeMachine.GetCoffeMaker().GetCoffeAmount()}]\n");
                    Console.WriteLine($"    - SugarAviable: [{coffeeMachine.GetSugarBowl().GetSugarAmount()}]");
                    Console.Write("\n\n Do you want to continue? (y/n):");
                    
                    answer = Console.ReadLine()!;
                    if (ValidAnswer(answer, new string[]{"y","n"})) break;
                }

                switch (answer)
                {
                    case "y": break;
                    case "n": Environment.Exit(0); break;
                }
            }
        }


        public static bool ValidAnswer(string answer, string[] options) {
            foreach (var option in options)
            {
                if (option == answer) {return true;}
            }
            return false;
        }
    }
}