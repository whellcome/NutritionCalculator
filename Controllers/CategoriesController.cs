using NutritionCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var newCat = new Category
            {
                Id = NCData.GetId()
            };
            return newCat;
        }
        public Category GetCategory(uint id)
        {
            return Categories.SingleOrDefault(c => c.Id == id);
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
