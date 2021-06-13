﻿
namespace NutritionCalculator.Models
{
    public class Ingredient
    {
        public uint Id { get; set; }
        public uint ParentId { get; set; }
        public Nutrient Nutrient { get; set; }
        public double Amount { get; set; }
        public Ingredient(Nutrient nutrient, double amount)
        {
            Nutrient = nutrient;
            Amount = amount;
        }

        public Ingredient()
        {
        }
    }
}
