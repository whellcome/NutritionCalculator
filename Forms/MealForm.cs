﻿using NutritionCalculator.Controllers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NutritionCalculator.Forms
{
    public partial class MealForm : Form
    {
        private readonly MealsController mealsController = new MealsController();
        private readonly NutrientsController NutrientsController = new NutrientsController();
        private readonly IngredientsController IngredientsController = new IngredientsController();
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
            if (sender.GetType() == typeof(IngredientsForm))
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
                    var nutrient = NutrientsController.Nutrients.SingleOrDefault(f => f.Id == index);
                    items.Add(IngredientsController.SetNewItem(nutrient, 0));
                    MealItemsRefresh();
                }
            }
            else
            {
                var nutrient = NutrientsController.Nutrients.SingleOrDefault(f => f.Id == index);
                items.Add(IngredientsController.SetNewItem(nutrient, 0));
                MealItemsRefresh();
            }
        }

        private void dgvMealItems_Click(object sender, EventArgs e)
        {
            if (dgvMealItems.CurrentCell.ColumnIndex == 0)
            {
                IngredientsForm ingredientsForm = new IngredientsForm(NCData.GetNewFormPoint(this, 430));
                ingredientsForm.Show();
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

        private void btSave_Click(object sender, EventArgs e)
        {
            mealsController.CurrentMeal.LocalDateTime = dtpMealDateTime.Value;
            mealsController.SetNew();
        }
    }
}
