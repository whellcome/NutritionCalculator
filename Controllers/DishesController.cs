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
                }
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
            return result * factor;
        }
        public double GetProteins(double factor = 1)
        {
            double result = 0;
            foreach (var item in CurrentDish.Ingredients)
                result += item.Nutrient.GetProteins(item.Amount);
            return result * factor;
        }
        public double GetFats(double factor = 1)
        {
            double result = 0;
            foreach (var item in CurrentDish.Ingredients)
                result += item.Nutrient.GetFats(item.Amount);
            return result * factor;
        }
        public double GetCalories(double factor = 1)
        {
            double result = 0;
            foreach (var item in CurrentDish.Ingredients)
                result += item.Nutrient.GetCalories(item.Amount);
            return result * factor;
        }
        public void SetNew()
        {
            CurrentDish.Id = NCData.GetId();
            Dishes.Add(CurrentDish);
            Save();
        }
    }
}
