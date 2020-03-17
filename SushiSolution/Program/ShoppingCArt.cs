using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public static class ShoppingCart
    {
        public static List<SushiEntity> sushiOnCart = new List<SushiEntity>();

        public static void ShowCart()
        {
            foreach (SushiEntity sushi in sushiOnCart)
            {
                Console.WriteLine(sushi.Name);
            }
        }
    }
}
