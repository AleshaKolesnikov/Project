using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public static class DataBase
    {
        public static SushiEntity withSalmon = new SushiEntity()
        {
            Name = "With Salmon",
            Weight = 100,
            Ingredients = new string[] { "Nori", "Salmon" }
        };

        public static SushiEntity withUgor = new SushiEntity()
        {
            Name = "With Ugor",
            Weight = 105,
            Ingredients = new string[] { "Nori", "Ugor" }
        };
        public static SushiEntity withCucumber = new SushiEntity()
        {
            Name = "With Cucumber",
            Weight = 108,
            Ingredients = new string[] { "Nori", "Cucumber" }
        };
    }
}
