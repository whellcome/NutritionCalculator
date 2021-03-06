using NutritionCalculator.Models;
using System;
using System.Collections.Generic;


namespace NutritionCalculator.Controllers
{
    public class MealsController : DataController
    {
        public User CurrentUser { get; set; }
        public List<Meal> Meals { get; set; }
        public Meal CurrentMeal { get; set; }
        private readonly IngredientsController IngredientsController = new IngredientsController();
        public MealsController()
        {
            CurrentUser = NCData.CurrentUser ?? throw new ArgumentNullException(typeof(User).ToString());
            Meals = GetMealsData();
            CurrentMeal = new Meal
            {
                MealItems = new List<Ingredient>
                {
                    IngredientsController.SetNewItem()
                }
            };
        }

        public void SetNew()
        {
            CurrentMeal.Id = NCData.GetId();
            CurrentMeal.UserId = NCData.CurrentUser.Id;
            CurrentMeal.Name = "";
            foreach (var item in CurrentMeal.MealItems)
            {
                CurrentMeal.Name += $"{item.Nutrient.Name}:{item.Amount}g, ";
            }
            
            Meals.Add(CurrentMeal);
            Save();
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
