
using System.Collections.Generic;

namespace NutritionCalculator.Models
{
    public class Dish : Nutrient
    {
        public List<Ingredient> Ingredients { get; set; }
        public double Portion { get; set; }
        public double WaterWastageFactor { get; set; }

        public override string ToString()
        {
            return $"{Name} (Dish)";
        }
    }
}
