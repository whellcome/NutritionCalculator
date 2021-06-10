namespace NutritionCalculator.Models
{
    public abstract class Nutrient
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public Category Categorie { get; set; }
        public string Description { get; set; }
        public double Carbohydrates { get; set; }
        public double Proteins { get; set; }
        public double Fats { get; set; }
        public double Calories { get; set; }
        public double GlycemicIndex { get; set; }
        public double GetCarbohydrates(double amount)
        {
            return Carbohydrates * amount / 100;
        }
        public double GetProteins(double amount)
        {
            return Proteins * amount / 100;
        }
        public double GetFats(double amount)
        {
            return Fats * amount / 100;
        }
        public double GetCalories(double amount)
        {
            return Calories * amount / 100;
        }
    }
}
