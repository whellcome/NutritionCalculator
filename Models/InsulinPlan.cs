using System.Collections.Generic;

namespace NutritionCalculator.Models
{
    
    public class InsulinPlan
    {
        public uint Id { get; set; }
        
        public User User { get; set; }
        
        public string Name { get; set; }
        public List<InsulinPlanItem> Plan { get; set; }
        public InsulinPlan(User user)
        {
            User = user;
            Plan = new List<InsulinPlanItem>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
