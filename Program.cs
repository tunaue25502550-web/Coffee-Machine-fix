using System;

namespace CoffeeMachineApp
{
    internal class CoffeeMachine
    {
        public int Water { get; private set; }
        public int Coffee { get; private set; }
        public int Milk { get; private set; }
        public int Chocolate { get; private set; }

        public CoffeeMachine(int water, int coffee, int milk, int chocolate)
        {
            Water = water;
            Coffee = coffee;
            Milk = milk;
            Chocolate = chocolate;
        }

        public void ShowStock()
        {
            Console.WriteLine("----- Stock -----");
            Console.WriteLine($"Water: {Water} g");
            Console.WriteLine($"Coffee: {Coffee} g");
            Console.WriteLine($"Milk: {Milk} g");
            Console.WriteLine($"Chocolate: {Chocolate} g");
        }

        public void Refill(int water, int coffee, int milk, int chocolate)
        {
            Water += water;
            Coffee += coffee;
            Milk += milk;
            Chocolate += chocolate;
            Console.WriteLine("Refill completed.");
        }

        private bool CheckIngredient(int water, int coffee, int milk, int chocolate)
        {
            return Water >= water &&
                   Coffee >= coffee &&
                   Milk >= milk &&
                   Chocolate >= chocolate;
        }

        private void UseIngredient(int water, int coffee, int milk, int chocolate)
        {
            Water -= water;
            Coffee -= coffee;
            Milk -= milk;
            Chocolate -= chocolate;
        }

        public void MakeDrink(int menu)
        {
            switch (menu)
            {
                case 1: // กาแฟดำ
                    if (CheckIngredient(300, 20, 0, 0))
                    {
                        UseIngredient(300, 20, 0, 0);
                        Console.WriteLine("Black coffee is ready ☕");
                    }
                    else Console.WriteLine("Not enough ingredients");
                    break;

                case 2: // มอคค่า
                    if (CheckIngredient(300, 20, 0, 10))
                    {
                        UseIngredient(300, 20, 0, 10);
                        Console.WriteLine("Mocha is ready ☕");
                    }
                    else Console.WriteLine("Not enough ingredients");
                    break;

                case 3: // ลาเต้
                    if (CheckIngredient(300, 20, 10, 0))
                    {
                        UseIngredient(300, 20, 10, 0);
                        Console.WriteLine("Latte is ready ☕");
                    }
                    else Console.WriteLine("Not enough ingredients");
                    break;

                case 4: // ช็อกโกแลต
                    if (CheckIngredient(300, 0, 0, 20))
                    {
                        UseIngredient(300, 0, 0, 20);
                        Console.WriteLine("Chocolate is ready ☕");
                    }
                    else Console.WriteLine("Not enough ingredients");
                    break;

                default:
                    Console.WriteLine("Invalid menu");
                    break;
            }
        }
    }
}

