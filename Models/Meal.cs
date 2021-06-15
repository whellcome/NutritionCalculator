using System;
using System.Collections.Generic;

namespace NutritionCalculator.Models
{
    public class Meal
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public List<Ingredient> MealItems { get; set; }
        public string Name { get; set; }
        public DateTime LocalDateTime { get; set; }

        public override string ToString()
        {
            return $"{LocalDateTime.ToString("HH:mm")} : {Name}";
        }
    }
}
