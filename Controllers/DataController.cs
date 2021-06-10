using System.Collections.Generic;

namespace NutritionCalculator.Controllers
{
    public abstract class DataController
    {
        private readonly IDataController manager = new DataJsonController();

        protected void Save<T>(List<T> item) where T : class
        {
            manager.Save(item);
        }

        protected List<T> Load<T>() where T : class
        {
            return manager.Load<T>();
        }
    }
}
