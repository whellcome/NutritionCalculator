using NutritionCalculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace NutritionCalculator.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UsersListForm usersListForm = new UsersListForm();
            usersListForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (NCData.CurrentUser != null)
            {
                buttonSelectUser.Text = $"User: {NCData.CurrentUser.Name} \n" +
                                        $"Change user";
                btMeal.Enabled = true;
            }
            else
            {
                buttonSelectUser.Text = "Select a user";
                btMeal.Enabled = false;
            }
            this.Refresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CalculateForm calculateForm = new CalculateForm();
            calculateForm.Show();
        }

        private void btCategories_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesForm = new CategoriesForm();
            categoriesForm.Show();
        }

        private void btFoods_Click(object sender, EventArgs e)
        {
            FoodsForm foodsForm = new FoodsForm();
            foodsForm.Show();
        }

        private void btMeal_Click(object sender, EventArgs e)
        {
            MealForm mealForm = new MealForm();
            mealForm.Show();
        }
    }
}
