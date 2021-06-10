using NutritionCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NutritionCalculator.Controllers
{
    public class FoodsController : DataController
    {
        public List<Food> Foods { get; }
        public Food CurrentFood { get; set; }
        public FoodsController()
        {
            Foods = GetFoodsData();
        }

        private List<Food> GetFoodsData()
        {
            return Load<Food>();
        }

        public void Save()
        {
            Save(Foods);
        }

        public void SaveOrNew(string strId, Category category, string name, string art, string description,
                              string carbohydrates, string proteins, string fats, string calories, 
                              string glycemicIndex)
        {
            if(string.IsNullOrWhiteSpace(name))  throw new ArgumentNullException(nameof(name));
            var id = uint.Parse(strId);
            var food = Foods.SingleOrDefault(f => f.Id == id);

            if ( food != null && id != 0)
            {
                var index = Foods.FindIndex(f => f.Id == id); //TODO: overwrite warning 

                food.Name = name;
                food.Kind = art;
                food.Categorie = category;
                food.Description = description;
                food.Carbohydrates = double.Parse(carbohydrates);
                food.Proteins = double.Parse(proteins);
                food.Fats = double.Parse(fats);
                food.Calories = double.Parse(calories);
                food.GlycemicIndex = double.Parse(glycemicIndex);
                Foods[index] = food;
            }
            else
            {
                Food newFood = new Food()
                {
                    Id = (uint)DateTime.Now.Subtract(new DateTime(2021, 1, 1)).TotalSeconds,
                    Name = name,
                    Kind = art,
                    Categorie = category,
                    Description = description,
                    Carbohydrates = double.Parse(carbohydrates),
                    Proteins = double.Parse(proteins),
                    Fats = double.Parse(fats),
                    Calories = double.Parse(calories),
                    GlycemicIndex = double.Parse(glycemicIndex)
                };
                Foods.Add(newFood);
            }
            Save();
        }
    }
}
