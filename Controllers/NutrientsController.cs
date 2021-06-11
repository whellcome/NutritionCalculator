using NutritionCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalculator.Controllers
{
    class NutrientsController
    {
        private DishesController dishesController = new DishesController();
        private FoodsController foodsController = new FoodsController();
        public List<Nutrient> Nutrients { get; }
        public Nutrient CurrentNutrient { get; set; }

        public NutrientsController()
        {
            Nutrients = new List<Nutrient>();
            if (dishesController.Dishes.Count > 0)
            {
                Nutrients.AddRange(dishesController.Dishes);
            }
            if (foodsController.Foods.Count > 0)
            {
                Nutrients.AddRange(foodsController.Foods);
            }
        }

        
    }
}
