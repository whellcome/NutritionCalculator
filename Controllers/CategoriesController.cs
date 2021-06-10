using NutritionCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalculator.Controllers
{
    public class CategoriesController : DataController
    {
        public List<Category> Categories { get; set; }
        public Category CurrentCategory { get; set; }

        public CategoriesController()
        {
            Categories = GetCategoriesData();
        }

        public Category SetNewItem()
        {
            return new Category();
        }

        private List<Category> GetCategoriesData()
        {
            return Load<Category>();
        }

        public void Save()
        {
            Save(Categories);
        }
    }
}
