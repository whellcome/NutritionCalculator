

namespace NutritionCalculator.Models
{
    public class Food : Nutrient
    {
        public string Kind { get; set; }

        public override string ToString()
        {
            return $"{Name} : {Kind}";
        }
    }
}
