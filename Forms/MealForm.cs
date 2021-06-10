using NutritionCalculator.Controllers;
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
    public partial class MealForm : Form
    {
        private MealsController mealsController = new MealsController();
        private FoodsController foodsController = new FoodsController(); //TODO: to NutritionsController
        public MealForm()
        {
            InitializeComponent();
            NCData.DataSelected = new NCData.EventHandler<Form, NCEventArgs>(eventDataSelected);
        }
        private void MealForm_Load(object sender, EventArgs e)
        {
            lbUser.Text = "User: " + mealsController.CurrentUser.Name;
            MealItemsRefresh();
        }
        private void eventDataSelected(Form sender, NCEventArgs e)
        {
            if (sender.GetType() == typeof(FoodsForm))
            {
                uint index = uint.Parse(e.Message);
                addMealItem(index);
            }
        }

        private void addMealItem(uint index)
        {
            mealsController.CurrentMeal.MealItems.RemoveAll(m => m.Nutrient == null);
            var items = mealsController.CurrentMeal.MealItems;
            
            if (items.Count > 0)
            {
                if (items.SingleOrDefault(i => i.Nutrient.Id == index) == null)
                {
                    var food = foodsController.Foods.SingleOrDefault(f => f.Id == index);
                    items.Add(mealsController.SetNewItem(food, 0));
                    MealItemsRefresh();
                }
            }
            else
            {
                var food = foodsController.Foods.SingleOrDefault(f => f.Id == index);
                items.Add(mealsController.SetNewItem(food, 0));
                MealItemsRefresh();
            }
        }

        private void dgvMealItems_Click(object sender, EventArgs e)
        {
            if (dgvMealItems.CurrentCell.ColumnIndex == 0)
            {
                FoodsForm foodsForm = new FoodsForm();
                foodsForm.Show();
            }
        }

        private void MealItemsRefresh()
        {
            dgvMealItems.DataSource = null;
            dgvMealItems.DataSource = mealsController.CurrentMeal.MealItems;
        }

        private void dgvMealItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            lbConsist.Text = mealsController.getEnergyValues();
            lbConsist.Text += "\n\nRecommended insulin dose: " + InsulinPlanController.GetInsulinDose(dtpMealDateTime.Value, mealsController.GetCarbohydrates());
        }
    }
}
