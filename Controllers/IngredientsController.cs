using NutritionCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalculator.Controllers
{
    class IngredientsController : DataController
    {
        public List<Ingredient> Igredients { get; set; }
        public IngredientsController()
        {
        }
        public Ingredient SetNewItem(Nutrient nutrient, double amount)
        {
            return new Ingredient(nutrient, amount)
            {
                Id = NCData.GetId()
            };
        }
        public Ingredient SetNewItem()
        {
            return new Ingredient()
            {
                Id = NCData.GetId()
            };
        }
    }
}
