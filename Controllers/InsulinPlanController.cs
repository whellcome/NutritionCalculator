using NodaTime;
using NutritionCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NutritionCalculator.Controllers
{
    public class InsulinPlanController : DataController
    {
        private List<InsulinPlan> InsulinPlans { get; set; }
        public List<InsulinPlan> UserInsulinPlans { get; set; }
        public InsulinPlan CurrentInsulinPlan { get; set; }
        public InsulinPlanController()
        {
            
            InsulinPlans = GetInsulinPlans();
            UserInsulinPlans = InsulinPlans.FindAll(i => i.User.Name == NCData.CurrentUser.Name && i.User.BirthDate == NCData.CurrentUser.BirthDate);
            if (UserInsulinPlans.Count <= 0)
            {
                CurrentInsulinPlan = new InsulinPlan(NCData.CurrentUser);
                CurrentInsulinPlan.Plan.Add(SetNewItem());
            }
            else
            {
                CurrentInsulinPlan = UserInsulinPlans.SingleOrDefault(i => i.Id == NCData.CurrentUser.InsulinPlan) ?? UserInsulinPlans.First();// NutritionCalculatorData.CurrentInsulinPlan;
            }
        }

        public InsulinPlanItem SetNewItem()
        {
            return new InsulinPlanItem();
        }

        public void SetNew(InsulinPlan insulinPlan)
        {
            if (CurrentInsulinPlan.Plan.Count == 0)
            {
                foreach (InsulinPlanItem item in insulinPlan.Plan)
                {
                    CurrentInsulinPlan.Plan.Add(item);
                }   
            }
            CurrentInsulinPlan.Id = (uint)DateTime.Now.Subtract(new DateTime(2021, 1, 1)).TotalSeconds;
            InsulinPlans.Add(CurrentInsulinPlan);
            Save();
        }

        public void Update(InsulinPlan insulinPlan)
        {
            var currentInsulinPlan = UserInsulinPlans.SingleOrDefault(i => i.Id == NCData.CurrentUser.InsulinPlan);
            var index = InsulinPlans.FindIndex(i => i.User == currentInsulinPlan.User && i.Id == currentInsulinPlan.Id);
            InsulinPlans[index] = insulinPlan;
            NCData.CurrentUser.InsulinPlan = insulinPlan.Id;
            Save();
        }

        private List<InsulinPlan> GetInsulinPlans()
        {
            return Load<InsulinPlan>();
        }

        public void Save()
        {
            NCData.CurrentUser.InsulinPlan = CurrentInsulinPlan.Id;
            Save(InsulinPlans);
            NCData.DataSaved(this, new NCEventArgs("InsulinPlan"));
        }

        public static double GetInsulinDose(DateTime dateTime, double amountCarbohydrates, double glucoseLevel = 0)
        {
            if (NCData.CurrentUser == null) return 0;
            
            var localTime = LocalDateTime.FromDateTime(dateTime).TimeOfDay;
            double eatFactor = 0, targetFactor = 0, glucoseTarget = 0;
            var insulinController = new InsulinPlanController();
            var plan = insulinController.CurrentInsulinPlan.Plan;
            plan.OrderBy(p => p.LocalTimeBegin);
            if (localTime < plan.First().LocalTimeBegin || localTime > plan.Last().LocalTimeBegin)
            {
                var item = plan.Last();
                eatFactor = item.EatFactor;
                targetFactor = NCData.CurrentUser.UnitSystemMgdL ? item.TargetFactor / 100 : item.TargetFactor;
                glucoseTarget = item.GlucoseLevelTarget;
            }
            else
            {
                var item = plan.FirstOrDefault(p => p.LocalTimeBegin <= localTime);
                eatFactor = item.EatFactor;
                targetFactor = NCData.CurrentUser.UnitSystemMgdL ? item.TargetFactor/100 : item.TargetFactor;
                glucoseTarget = item.GlucoseLevelTarget;
            }
            var resultat = amountCarbohydrates * eatFactor / 10 + ((glucoseLevel > 0) ? (glucoseLevel - glucoseTarget) * targetFactor : 0);
            return resultat;
        }
    }
}
