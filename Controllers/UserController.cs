using NodaTime;
using NutritionCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NutritionCalculator.Controllers
{
    public class UserController : DataController
    {

        /// <summary>
        /// List of users
        /// </summary>
        public List<User> Users { get; }

        /// <summary>
        /// Current user
        /// </summary>
        public User CurrentUser { get; set; }
        
        public UserController()
        {
            Users = GetUsersData();
            CurrentUser = NCData.CurrentUser ?? Users.FirstOrDefault();
            NCData.DataSaved = new NCData.EventHandler<DataController,NCEventArgs>(eventDataSaved);
        }

        private void eventDataSaved(DataController controller, NCEventArgs args)
        {
            if (args.Message.Equals("InsulinPlan"))
            {
                Save();
            }
        }

        public void SetNew(string name, DateTime birthDate, object insulinPlan, string txtWeight, string txtHeight,
                           bool unitSystemMgdL, bool glutenFree)
        {
            var localDate = LocalDateTime.FromDateTime(birthDate);
            if (!double.TryParse(txtWeight, out double weight)) weight = 0;
            if (!double.TryParse(txtHeight, out double height)) height = 0;
            CurrentUser = new User(name, localDate.Date, (InsulinPlan)insulinPlan, weight, height, unitSystemMgdL, glutenFree)
            {
                Id = (uint)DateTime.Now.Subtract(new DateTime(2021, 1, 1)).TotalSeconds
            };
            Users.Add(CurrentUser);
            Save();
        }

        public void Update(string name, DateTime birthDate, object insulinPlan, string txtWeight, string txtHeight,
                           bool unitSystemMgdL, bool glutenFree)
        {
            var localDate = LocalDateTime.FromDateTime(birthDate);
            if (!double.TryParse(txtWeight, out double weight)) weight = 0;
            if (!double.TryParse(txtHeight, out double height)) height = 0;
            var plan = (InsulinPlan)insulinPlan;
            var index = Users.FindIndex(u => u.Id == CurrentUser.Id);
            
            CurrentUser.Name = name;
            CurrentUser.BirthDate = localDate.Date;
            CurrentUser.InsulinPlan = plan.Id;
            CurrentUser.Weight = weight;
            CurrentUser.Height = height;
            CurrentUser.UnitSystemMgdL = unitSystemMgdL;
            CurrentUser.GlutenFree = glutenFree;

            Users[index] = CurrentUser;
            Save();
            
        }

        public List<User> GetUsersData()
        {
            return Load<User>();
        }

        public void Save()
        {
            Save(Users);
            NCData.CurrentUser = CurrentUser;
        }
    }
}
