using NutritionCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalculator.Controllers
{
    class DishesController : DataController
    {
        public List<Dish> Dishes { get; }
        public Dish CurrentDish { get; set; }
        private readonly IngredientsController IngredientsController = new IngredientsController();
        public DishesController()
        {
            Dishes = GetDishesData();

            CurrentDish = new Dish
            {
                Ingredients = new List<Ingredient>
                {
                    IngredientsController.SetNewItem()
                },
                WaterWastageFactor = 1,
            };
        }

        private List<Dish> GetDishesData()
        {
            return Load<Dish>();
        }

        public void Save()
        {
            Save(Dishes);
        }

        public double GetCarbohydrates(double factor = 1)
        {
            double result = 0;
            foreach (var item in CurrentDish.Ingredients)
                result += item.Nutrient.GetCarbohydrates(item.Amount);
            return Math.Round(result / factorReview(factor), 1);
        }
        public double GetProteins(double factor = 1)
        {
            double result = 0;
            foreach (var item in CurrentDish.Ingredients)
                result += item.Nutrient.GetProteins(item.Amount);
            return Math.Round(result / factorReview(factor),1);
        }
        public double GetFats(double factor = 1)
        {
            double result = 0;
            foreach (var item in CurrentDish.Ingredients)
                result += item.Nutrient.GetFats(item.Amount);
            return Math.Round(result / factorReview(factor), 1);
        }

        public double GetCalories(double factor = 1)
        {
            //Zum Kalkulieren Kalorien würde es besser die Formel benutzen:
            //Kohlenhydrates*4*0,956+Fette*9*0,94+Eiweiße*4*0,84+OrgSäuren*3+Alkohol*7+MehrwertAlkohol*2,4 
            // TODO: realisieren das in einer zukünftigen Version

            double result = 0;
            foreach (var item in CurrentDish.Ingredients)
                result += item.Nutrient.GetCalories(item.Amount);
            return Math.Round(result / factorReview(factor), 1);
        }
        private double factorReview(double factor)
        {
            return (factor <= 0 || factor > 1) ? 1 : factor;
        }
        public void SetNew()
        {
            CurrentDish.Id = NCData.GetId();
            Dishes.Add(CurrentDish);
            Save();
        }
        public void SaveOrNew(string strId, Category category, string name, string description,
                              string carbohydrates, string proteins, string fats, string calories,
                              string glycemicIndex, string wastageFactor, string portionMass, List<Ingredient> ingredients)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            var id = uint.Parse(strId);
            var dish = Dishes.SingleOrDefault(f => f.Id == id);

            if (dish != null && id != 0)
            {
                var index = Dishes.FindIndex(f => f.Id == id); //TODO: overwrite warning 

                dish.Name = name;
                dish.CategorieId = category.Id;
                dish.Description = description;
                dish.Carbohydrates = double.Parse(carbohydrates);
                dish.Proteins = double.Parse(proteins);
                dish.Fats = double.Parse(fats);
                dish.Calories = double.Parse(calories);
                dish.GlycemicIndex = double.Parse(glycemicIndex);
                dish.WaterWastageFactor = double.Parse(wastageFactor);
                dish.Portion = double.Parse(portionMass);
                dish.Ingredients = ingredients;
                Dishes[index] = dish;
            }
            else
            {
                Dish newDish = new Dish()
                {
                    Id = NCData.GetId(),
                    Name = name,
                    CategorieId = category.Id,
                    Description = description,
                    Carbohydrates = double.Parse(carbohydrates),
                    Proteins = double.Parse(proteins),
                    Fats = double.Parse(fats),
                    Calories = double.Parse(calories),
                    GlycemicIndex = double.Parse(glycemicIndex),
                    WaterWastageFactor = double.Parse(wastageFactor),
                    Portion = double.Parse(portionMass),
                    Ingredients = ingredients
                };
                Dishes.Add(newDish);
            }
            Save();
        }
    }
}
