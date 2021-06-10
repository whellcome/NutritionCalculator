using NodaTime;
using System;

namespace NutritionCalculator.Models
{
    public class InsulinPlanItem
    {
        public LocalTime LocalTimeBegin { get; set; }
        public double EatFactor { get; set; }
        public double GlucoseLevelTarget { get; set; }
        public double TargetFactor { get; set; }

        public InsulinPlanItem(User user, string name, LocalTime localTimeBegin, double eatFactor, double glucoseLevelTarget, double targetFactor)
        {
            LocalTimeBegin = localTimeBegin;
            EatFactor = eatFactor;
            GlucoseLevelTarget = glucoseLevelTarget;
            TargetFactor = targetFactor;
        }

        public InsulinPlanItem()
        {
        }
    }
}
