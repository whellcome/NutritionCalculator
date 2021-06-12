using NutritionCalculator.Controllers;
using NutritionCalculator.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NutritionCalculator.Forms
{
    public partial class IngredientsForm : Form
    {
        public IngredientsForm(Point pt)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = pt;


        }
        private readonly NutrientsController NutrientsController = new NutrientsController();
        private readonly CategoriesController CategoriesController = new CategoriesController();
        private void FoodsForm_Load(object sender, EventArgs e)
        {            
            foreach (Nutrient nutrient in NutrientsController.Nutrients)
            {
                var row = new string[] { CategoriesController.GetCategory(nutrient.CategorieId).ToString(), nutrient.ToString() };
                var lvi = new ListViewItem(row)
                {
                    Tag = nutrient
                };
                lvIngredients.Items.Add(lvi);
            }
            GroupListView(lvIngredients, 0);
        }

        private void GroupListView(ListView lstView, int SubItemIndex)
        {
            bool flag = true;
            foreach (ListViewItem item in lstView.Items)
            {
                string groupName = item.SubItems[SubItemIndex].Text;
                foreach (ListViewGroup lvGroup in lstView.Groups)
                {
                    if (lvGroup.Name == groupName)
                    {
                        item.Group = lvGroup;
                        flag = false;
                    }
                }
                if (flag == true)
                {
                    ListViewGroup lstGrp = new ListViewGroup(groupName, groupName);
                    lstView.Groups.Add(lstGrp);
                    item.Group = lstGrp;
                }
                flag = true;
            }
        }

        private void lvFoods_DoubleClick(object sender, EventArgs e)
        {
            var nutrient = (Nutrient)lvIngredients.SelectedItems[0].Tag;
            NCData.DataSelected(this, new NCEventArgs(nutrient.Id.ToString()));
        }
    }
}
