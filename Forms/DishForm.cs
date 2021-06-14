using NutritionCalculator.Controllers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NutritionCalculator.Forms
{
    public partial class DishForm : Form
    {
        private bool editMode { get; }
        private DishesController dishesController = new DishesController();
        private IngredientsController ingredientsController = new IngredientsController();
        private CategoriesController categoriesController = new CategoriesController();
        private readonly NutrientsController nutrientsController = new NutrientsController();
        public DishForm(bool editMode = false)
        {
            InitializeComponent();
            NCData.DataSelected = new NCData.EventHandler<Form, NCEventArgs>(eventDataSelected);
            this.editMode = editMode;
        }

        private void DishForm_Load(object sender, EventArgs e)
        {
            IngredientsRefresh();
        }

        private void btSelectCategory_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesForm = new CategoriesForm(NCData.GetNewFormPoint(this, 355), false);
            categoriesForm.Show();
        }
        private void eventDataSelected(Form sender, NCEventArgs args)
        {
            if (sender.GetType() == typeof(DishesForm))
            {
                uint index = uint.Parse(args.Message);
                fillForm(index);
            }
            else if (sender.GetType() == typeof(CategoriesForm))
            {
                int index = int.Parse(args.Message);
                categoriesController.CurrentCategory = categoriesController.Categories[index];
                lbCategory.Text = categoriesController.CurrentCategory.Name;
            }
            else if (sender.GetType() == typeof(IngredientsForm))
            {
                uint index = uint.Parse(args.Message);
                addIngredient(index);
            }
        }

        private void addIngredient(uint index)
        {
            dishesController.CurrentDish.Ingredients.RemoveAll(i => i.Nutrient == null);
            var items = dishesController.CurrentDish.Ingredients;

            if (items.Count > 0)
            {
                if (items.SingleOrDefault(i => i.Nutrient.Id == index) == null)
                {
                    var nutrient = nutrientsController.Nutrients.SingleOrDefault(n => n.Id == index);
                    items.Add(ingredientsController.SetNewItem(nutrient, 0));
                    IngredientsRefresh();
                }
            }
            else
            {
                var nutrient = nutrientsController.Nutrients.SingleOrDefault(n => n.Id == index);
                items.Add(ingredientsController.SetNewItem(nutrient, 0));
                IngredientsRefresh();
            }
        }

        private void fillForm(uint index)
        {
            var dish = dishesController.Dishes.SingleOrDefault(d => d.Id == index);
            if (dish != null)
            {
                dishesController.CurrentDish = dish;
                categoriesController.CurrentCategory = categoriesController.Categories.SingleOrDefault(c => c.Id == dish.CategorieId);
                lbCategory.Text = categoriesController.CurrentCategory.Name;
                txtName.Text = dish.Name;
                txtDescription.Text = dish.Description;
                txtCarbohydrates.Text = dish.Carbohydrates.ToString();
                txtProteins.Text = dish.Proteins.ToString();
                txtFats.Text = dish.Fats.ToString();
                txtCalories.Text = dish.Calories.ToString();
                txtGlycemicIndex.Text = dish.GlycemicIndex.ToString();
                txtWastageFactor.Text = dish.WaterWastageFactor.ToString();
                txtPortionMass.Text = dish.Portion.ToString();
            }
        }

        private void txtGlycemicIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;
            if (!(char.IsDigit(number) || char.IsControl(number) || number == ',')) e.Handled = true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var id = (editMode) ? dishesController.CurrentDish.Id.ToString() : "0";
            dishesController.SaveOrNew(id, categoriesController.CurrentCategory, txtName.Text,
                                      txtDescription.Text, txtCarbohydrates.Text, txtProteins.Text, txtFats.Text,
                                      txtCalories.Text, txtGlycemicIndex.Text, txtWastageFactor.Text, 
                                      txtPortionMass.Text, dishesController.CurrentDish.Ingredients);
            DishesForm dishesForm = new DishesForm();
            dishesForm.Show();
            Close();
        }
        private void IngredientsRefresh()
        {
            dgvIngredients.DataSource = null;
            dgvIngredients.DataSource = dishesController.CurrentDish.Ingredients;
        }

        private void dgvIngredients_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            txtCarbohydrates.Text = dishesController.GetCarbohydrates().ToString();
            txtProteins.Text = dishesController.GetProteins().ToString();
            txtFats.Text = dishesController.GetFats().ToString();
            txtCalories.Text = dishesController.GetCalories().ToString();
        }

        private void dgvIngredients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvIngredients.CurrentCell.ColumnIndex == 0)
            {
                IngredientsForm ingredientsForm = new IngredientsForm(NCData.GetNewFormPoint(this, 430));
                ingredientsForm.Show();
            }
        }
    }
}
