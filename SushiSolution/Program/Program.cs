using System;

namespace Program
{
    class Program
    {
        public static bool flag = true;
        public static SushiEntity[] allSushi = new SushiEntity[3];
        static void Main(string[] args)
        {
            allSushi[0] = DataBase.withCucumber;
            allSushi[1] = DataBase.withUgor;
            allSushi[2] = DataBase.withSalmon;

            Console.WriteLine("1 - Show Menu; 2 - Exit");
            Choise.choseCommand += StartOrExit;
            Choise.InputAndCheck();
            // Начало программы 
        }
        public static void Start()
        {
            SushiEntity.ShowNameAndWeight(allSushi[0]);
            SushiEntity.ShowNameAndWeight(allSushi[1]);
            SushiEntity.ShowNameAndWeight(allSushi[2]);

            Console.WriteLine("1 - Show Ingredients, 2 - Pick Sushi, 3 - Exit");

            Choise.choseCommand -= StartOrExit;
            Choise.choseCommand += ShowPickOrExit;
            Choise.InputAndCheck();
        }
        public static void Exit()
        {
            Console.WriteLine("Exit");
            flag = false;
        }
        public static void ShowIngredients()
        {
            Console.WriteLine($"Show Ingredients of: " +
                                $" 1 - {allSushi[0].Name};" +
                                $" 2 - {allSushi[1].Name}" +
                                $" 3 - {allSushi[2].Name}");

            Choise.choseCommand -= ShowPickOrExit;
            Choise.choseCommand += WhatSushiShow;
            Choise.InputAndCheck();
        }
        public static void WhatSushiShow(int command)
        {
            switch (command)
            {
                case 1:
                    SushiEntity.ShowIngredients(allSushi[0]);
                    break;
                case 2:
                    SushiEntity.ShowIngredients(allSushi[1]);
                    break;
                case 3:
                    SushiEntity.ShowIngredients(allSushi[2]);
                    break;
            }
            Console.WriteLine("1 - Show Ingredients, 2 - Pick Sushi, 3 - Exit");
            Choise.choseCommand -= WhatSushiShow;
            Choise.choseCommand += ShowPickOrExit;
            Choise.InputAndCheck();
        }
        public static void PickSushi()
        {
            Console.WriteLine($"What kind of Sushi would You buy?: " +
                                $" 1 - {allSushi[0].Name};" +
                                $" 2 - {allSushi[1].Name}" +
                                $" 3 - {allSushi[2].Name}");

            Choise.choseCommand -= ShowPickOrExit;
            Choise.choseCommand += WhatSushiPick;
            Choise.InputAndCheck();
        }
        public static void WhatSushiPick(int command)
        {
            switch (command)
            {
                case 1:
                    ShoppingCart.sushiOnCart.Add(allSushi[0]);
                    break;
                case 2:
                    ShoppingCart.sushiOnCart.Add(allSushi[1]);
                    break;
                case 3:
                    ShoppingCart.sushiOnCart.Add(allSushi[2]);
                    break;
            }
            Console.WriteLine("1 - Show Ingredients, 2 - Pick Sushi, 3 - Exit");
            Choise.choseCommand -= WhatSushiPick;
            Choise.choseCommand += ShowPickOrExit;
            Choise.InputAndCheck();
        }
        public static void StartOrExit(int command)
        {
            switch (command)
            {
                case 1:
                    Start();
                    break;
                case 2:
                    Exit();
                    break;
            }
        }
        public static void ShowPickOrExit(int command)
        {
            switch (command)
            {
                case 1:
                    ShowIngredients();
                    break;
                case 2:
                    PickSushi();
                    break;
                case 3:
                    Exit();
                    break;
            }
        }
    }
}
