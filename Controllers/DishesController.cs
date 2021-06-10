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

        public DishesController()
        {
            Dishes = GetDishesData();
        }

        private List<Dish> GetDishesData()
        {
            return Load<Dish>();
        }

        public void Save()
        {
            Save(Dishes);
        }
    }
}
