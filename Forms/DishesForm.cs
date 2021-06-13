using NutritionCalculator.Controllers;
using NutritionCalculator.Models;
using System;
using System.Windows.Forms;

namespace NutritionCalculator.Forms
{
    public partial class DishesForm : Form
    {
        private readonly CategoriesController categoriesController = new CategoriesController();
        private readonly DishesController dishesController = new DishesController();
        public DishesForm()
        {
            InitializeComponent();
        }

        private void DishesForm_Load(object sender, EventArgs e)
        {
            ListViewExtender extender = new ListViewExtender(lvDishes);
            ListViewButtonColumn buttonAction = new ListViewButtonColumn(2);
            buttonAction.Click += OnButtonActionClick;
            buttonAction.FixedWidth = true;

            extender.AddColumn(buttonAction);
            foreach (Dish dish in dishesController.Dishes)
            {
                var row = new string[] { categoriesController.GetCategory(dish.CategorieId).ToString(), dish.ToString() };
                var lvi = new ListViewItem(row);
                lvi.Tag = dish;
                lvDishes.Items.Add(lvi).SubItems.Add("...");
            }
            GroupListView(lvDishes, 0);
        }

        private void OnButtonActionClick(object sender, ListViewColumnMouseEventArgs e)
        {
            DishForm dishForm = new DishForm(true);
            var food = (Food)lvDishes.SelectedItems[0].Tag;
            NCData.DataSelected(this, new NCEventArgs(food.Id.ToString()));
            dishForm.Show();
            Close();
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
        private void btCreate_Click(object sender, EventArgs e)
        {
            DishForm dishForm = new DishForm();
            dishForm.Show();
            Close();
        }

        private void lvFoods_DoubleClick(object sender, EventArgs e)
        {
            var dish = (Dish)lvDishes.SelectedItems[0].Tag;
            NCData.DataSelected(this, new NCEventArgs(dish.Id.ToString()));
        }
    }
}
