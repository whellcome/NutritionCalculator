using NutritionCalculator.Controllers;
using System;
using System.Windows.Forms;

namespace NutritionCalculator.Forms
{
    public partial class CategoriesForm : Form
    {
        private CategoriesController CategoriesController = new CategoriesController();
        private bool Editable;
        public CategoriesForm(bool editable = true)
        {
            InitializeComponent();
            Editable = editable;
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            if(Editable) CategoriesController.Categories.Add(CategoriesController.SetNewItem());
            else
            {
                dgvCategories.ReadOnly = true;
                btSave.Enabled = false;
            }
            dgvCategories.DataSource = CategoriesController.Categories;

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            CategoriesController.Categories.RemoveAll(c => c.Name == null);
            CategoriesController.Save();
            CategoriesController.Categories.Add(CategoriesController.SetNewItem());
            dgvCategoriesRefresh();
        }
        private void dgvCategories_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategories.CurrentRow != null && dgvCategories.CurrentRow.Index == CategoriesController.Categories.Count-1)
            {
                CategoriesController.Categories.Add(CategoriesController.SetNewItem());
                dgvCategoriesRefresh();
            }
        }
        private void dgvCategoriesRefresh()
        {
            dgvCategories.DataSource = null;
            dgvCategories.DataSource = CategoriesController.Categories;
        }

        private void dgvCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NCData.DataSelected(this, new NCEventArgs(dgvCategories.CurrentRow.Index.ToString()));
            Close();
        }
    }
}

