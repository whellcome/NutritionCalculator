using NutritionCalculator.Controllers;
using NutritionCalculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionCalculator.Forms
{
    public partial class MealsForm : Form
    {
        private readonly MealsController mealsController = new MealsController();
        public MealsForm()
        {
            InitializeComponent();
        }

        private void MealsForm_Load(object sender, EventArgs e)
        {
            ListViewExtender extender = new ListViewExtender(lvMeals);
            ListViewButtonColumn buttonAction = new ListViewButtonColumn(2);
            buttonAction.Click += OnButtonActionClick;
            buttonAction.FixedWidth = true;

            extender.AddColumn(buttonAction);
            foreach (var meal in mealsController.Meals)
            {
                var row = new string[] { meal.LocalDateTime.ToString("dd.MM.yy"), meal.ToString() };
                var lvi = new ListViewItem(row);
                lvi.Tag = meal;
                lvMeals.Items.Add(lvi).SubItems.Add("View");
            }
            NCData.GroupListView(lvMeals, 0);
        }

        private void OnButtonActionClick(object sender, ListViewColumnMouseEventArgs e)
        {
            MealForm mealForm = new MealForm(true);
            var meal = (Meal)lvMeals.SelectedItems[0].Tag;
            NCData.DataSelected(this, new NCEventArgs(meal.Id.ToString()));
            mealForm.Show();
            Close();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            MealForm mealForm = new MealForm();
            mealForm.Show();
            Close();
        }
    }
}
