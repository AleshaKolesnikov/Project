using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class SushiEntity
    {
        public string Name { get; set; }
        public string[] Ingredients { get; set; }
        public int Weight { get; set; }

        public static void ShowNameAndWeight(SushiEntity nameOfSushi)
        {
            Console.WriteLine($"{nameOfSushi.Name} - {nameOfSushi.Weight}gr");
        }

        public static void ShowIngredients(SushiEntity nameOfSushi)
        {
            foreach (string ingr in nameOfSushi.Ingredients)
            {
                Console.WriteLine(ingr);
            }
        }
    }
}
