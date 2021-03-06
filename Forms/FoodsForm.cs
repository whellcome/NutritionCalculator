using NutritionCalculator.Controllers;
using NutritionCalculator.Models;
using System;
using System.Windows.Forms;

namespace NutritionCalculator.Forms
{
    public partial class FoodsForm : Form
    {
        public FoodsForm()
        {
            InitializeComponent();
            
        }
        private FoodsController foodsController = new FoodsController();
        private CategoriesController categoriesController = new CategoriesController();
        private void FoodsForm_Load(object sender, EventArgs e)
        {
            ListViewExtender extender = new ListViewExtender(lvFoods);

            ListViewButtonColumn buttonAction = new ListViewButtonColumn(2);
            buttonAction.Click += OnButtonActionClick;
            buttonAction.FixedWidth = true;

            extender.AddColumn(buttonAction);
            foreach (Food food in foodsController.Foods)
            {
                var row = new string[] { categoriesController.GetCategory(food.CategorieId).ToString(), food.ToString() };
                var lvi = new ListViewItem(row);
                lvi.Tag = food;
                lvFoods.Items.Add(lvi).SubItems.Add("...");
            }
            NCData.GroupListView(lvFoods, 0);
        }

        private void OnButtonActionClick(object sender, ListViewColumnMouseEventArgs e)
        {
            FoodForm foodForm = new FoodForm(true);
            var food = (Food)lvFoods.SelectedItems[0].Tag;
            NCData.DataSelected(this, new NCEventArgs(food.Id.ToString()));
            foodForm.Show();
            //foodsController.Save(); // TODO: in case of deletion from the list
            Close();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            FoodForm foodForm = new FoodForm();
            foodForm.Show();
            Close();
        }

        private void lvFoods_DoubleClick(object sender, EventArgs e)
        {
            var food = (Food)lvFoods.SelectedItems[0].Tag;
            NCData.DataSelected(this, new NCEventArgs(food.Id.ToString()));
        }
    }
}
