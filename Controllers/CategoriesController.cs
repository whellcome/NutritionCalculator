﻿using NutritionCalculator.Models;
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
            var newCat = new Category
            {
                Id = (uint)DateTime.Now.Subtract(new DateTime(2021, 1, 1)).TotalSeconds
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
