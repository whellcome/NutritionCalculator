using System.Collections.Generic;

namespace NutritionCalculator.Models
{
    
    public class InsulinPlan
    {
        public uint Id { get; set; }
        
        public uint UserId { get; set; }
        
        public string Name { get; set; }
        public List<InsulinPlanItem> Plan { get; set; }
        public InsulinPlan(User user)
        {
            UserId = user.Id;
            Plan = new List<InsulinPlanItem>();
        }

        public InsulinPlan()
        {
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
