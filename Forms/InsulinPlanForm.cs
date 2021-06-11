using NutritionCalculator.Controllers;
using System;
using System.Windows.Forms;

namespace NutritionCalculator.Forms
{
    public partial class InsulinPlanForm : Form
    {
        private bool editMode { get; }
        private InsulinPlanController InsulinPlanController = new InsulinPlanController();
        public InsulinPlanForm(bool editMode = false)
        {
            InitializeComponent();
            this.editMode = editMode;
        }

        private void InsulinPlanForm_Load(object sender, EventArgs e)
        {
            tbName.Text = InsulinPlanController.CurrentInsulinPlan.Name;
            tbName.Text = string.IsNullOrWhiteSpace(tbName.Text) ? "Insulin plan" : tbName.Text;
            RefreshGridView();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            InsulinPlanController.CurrentInsulinPlan.Name = tbName.Text;
            InsulinPlanController.CurrentInsulinPlan.UserId = NCData.CurrentUser.Id;
            if (editMode)
                InsulinPlanController.Update(InsulinPlanController.CurrentInsulinPlan);
            else
                InsulinPlanController.SetNew(InsulinPlanController.CurrentInsulinPlan);
            UserForm userForm = new UserForm(true);
            userForm.Show();
            Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            InsulinPlanController.CurrentInsulinPlan.Plan.Add(InsulinPlanController.SetNewItem());
            RefreshGridView();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            var currItem = dgvInsulinPlan.CurrentRow.Index;
            InsulinPlanController.CurrentInsulinPlan.Plan.Remove(InsulinPlanController.CurrentInsulinPlan.Plan[currItem]);
            RefreshGridView();
        }
        
        private void RefreshGridView()
        {
            dgvInsulinPlan.DataSource = null;
            dgvInsulinPlan.Columns.AddRange(
                new DataGridViewTextBoxColumn() { Name = "clmTimeBegin", HeaderText = "Time of begin", DataPropertyName = "LocalTimeBegin" },
                new DataGridViewTextBoxColumn() { Name = "clmEatFactor", HeaderText = "Factor for food", DataPropertyName = "EatFactor" },
                new DataGridViewTextBoxColumn() { Name = "clmTarget", HeaderText = "Target of glucose level", DataPropertyName = "GlucoseLevelTarget" },
                new DataGridViewTextBoxColumn() { Name = "clmTargetFactor", HeaderText = "Factor for glucode level target", DataPropertyName = "TargetFactor" }
            );
            dgvInsulinPlan.DataSource = InsulinPlanController.CurrentInsulinPlan.Plan;
        }
    }
}
