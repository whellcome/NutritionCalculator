using NodaTime;
using System;

namespace NutritionCalculator.Models
{
    public class User
    {
        #region Properties
        public uint Id { get; set; }    
        public string Name { get; set; }
        public LocalDate BirthDate { get; set; }
        public uint InsulinPlan { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public bool UnitSystemMgdL { get; set; }
        public bool GlutenFree { get; set; }
        
        #endregion
        public User(string name, LocalDate birthDate, InsulinPlan insulinPlan, double weight, double height, bool unitSystemMgdL, bool glutenFree)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            BirthDate = birthDate;
            InsulinPlan = (insulinPlan != null) ? insulinPlan.Id : 0;
            Weight = weight;
            Height = height;
            UnitSystemMgdL = unitSystemMgdL;
            GlutenFree = glutenFree;
            
        }

        public User()
        {
        }

        public override string ToString()
        {
            return $"{Name} : {BirthDate}";
        }
    }
}