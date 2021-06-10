using NutritionCalculator.Controllers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NutritionCalculator.Forms
{
    public partial class FoodForm : Form
    {
        private bool editMode { get; }
        private FoodsController foodsController = new FoodsController();
        private CategoriesController categoriesController = new CategoriesController();
        public FoodForm(bool editMode = false)
        {
            InitializeComponent();
            NCData.DataSelected = new NCData.EventHandler<Form, NCEventArgs>(eventDataSelected);
            this.editMode = editMode;
        }

        private void btSelectCategory_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesForm = new CategoriesForm(false);
            categoriesForm.Show();
        }
        private void eventDataSelected(Form sender, NCEventArgs args)
        {
            if (sender.GetType() == typeof(FoodsForm))
            {
                uint index = uint.Parse(args.Message);
                fillForm(index);
            }
            else
            {
                int index = int.Parse(args.Message);
                categoriesController.CurrentCategory = categoriesController.Categories[index];
                lbCategory.Text = categoriesController.CurrentCategory.Name;
            }
        }

        private void fillForm(uint index)
        {
            var food = foodsController.Foods.SingleOrDefault(f => f.Id == index);
            if (food != null)
            {
                foodsController.CurrentFood = food;
                categoriesController.CurrentCategory = food.Categorie;
                lbCategory.Text = categoriesController.CurrentCategory.Name;
                txtName.Text = food.Name;
                txtArt.Text = food.Kind;
                txtDescription.Text = food.Description;
                txtCarbohydrates.Text = food.Carbohydrates.ToString();
                txtProteins.Text = food.Proteins.ToString();
                txtFats.Text = food.Fats.ToString();
                txtCalories.Text = food.Calories.ToString();
                txtGlycemicIndex.Text = food.GlycemicIndex.ToString();
            }
        }

        private void txtCarbohydrates_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;
            if (!Char.IsDigit(number)) e.Handled = true;
        }

        private void txtProteins_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;
            if (!Char.IsDigit(number)) e.Handled = true;    
        }

        private void txtFats_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;
            if (!Char.IsDigit(number)) e.Handled = true;
        }

        private void txtCalories_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;
            if (!Char.IsDigit(number)) e.Handled = true;
        }

        private void txtGlycemicIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;
            if (!Char.IsDigit(number)) e.Handled = true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var id = (editMode) ? foodsController.CurrentFood.Id.ToString() : "0";
            foodsController.SaveOrNew(id, categoriesController.CurrentCategory, txtName.Text, txtArt.Text,
                                      txtDescription.Text, txtCarbohydrates.Text, txtProteins.Text, txtFats.Text,
                                      txtCalories.Text, txtGlycemicIndex.Text);
            FoodsForm foodsForm = new FoodsForm();
            foodsForm.Show();
            Close();
        }
    }
}
