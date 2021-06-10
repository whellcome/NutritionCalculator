using NutritionCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalculator.Controllers
{
    public class MealsController : DataController
    {
        public User CurrentUser { get; set; }
        public List<Meal> Meals { get; set; }
        public Meal CurrentMeal { get; set; }
        public MealsController()
        {
            CurrentUser = NCData.CurrentUser ?? throw new ArgumentNullException(typeof(User).ToString());
            Meals = GetMealsData();
            CurrentMeal = new Meal
            {
                MealItems = new List<Ingredient>
                {
                    SetNewItem()
                }
            };
        }

        public void SetNew()
        {
            CurrentMeal.Id = (uint)DateTime.Now.Subtract(new DateTime(2021, 1, 1)).TotalSeconds;
        }

        public Ingredient SetNewItem(Nutrient nutrient, double amount)
        {
            return new Ingredient(nutrient, amount);
        }
        public Ingredient SetNewItem()
        {
            return new Ingredient();
        }
        public double GetCarbohydrates()
        {
            double result = 0;
            foreach (var item in CurrentMeal.MealItems)
                result += item.Nutrient.GetCarbohydrates(item.Amount);
            return result;
        }
        public double GetProteins()
        {
            double result = 0;
            foreach (var item in CurrentMeal.MealItems)
                result += item.Nutrient.GetProteins(item.Amount);
            return result;
        }
        public double GetFats()
        {
            double result = 0;
            foreach (var item in CurrentMeal.MealItems)
                result += item.Nutrient.GetFats(item.Amount);
            return result;
        }
        public double GetCalories()
        {
            double result = 0;
            foreach (var item in CurrentMeal.MealItems)
                result += item.Nutrient.GetCalories(item.Amount);
            return result;
        }
        public string getEnergyValues()
        {
            return $"Carbohydrates: {GetCarbohydrates()} \n" +
                   $"Proteins: {GetProteins()}\n" +
                   $"Fats: {GetFats()}\n" +
                   $"Calories: {GetCalories()}";
        }
        private List<Meal> GetMealsData()
        {
            return Load<Meal>();
        }

        public void Save()
        {
            Save(Meals);
        }
    }
}
