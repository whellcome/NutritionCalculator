
using NodaTime;
using System.Collections.Generic;

namespace NutritionCalculator.Models
{
    public class Meal
    {
        public uint Id { get; set; }
        private User User { get; set; }
        public List<Ingredient> MealItems { get; set; }
        public string Name { get; set; }
        public LocalDateTime LocalDateTime { get; set; }
    }
}
