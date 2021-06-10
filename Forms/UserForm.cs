using NodaTime;
using NutritionCalculator.Controllers;
using System;
using System.Windows.Forms;

namespace NutritionCalculator.Forms
{
    public partial class UserForm : Form
    {
        private bool editMode { get; }
        private UserController userController = new UserController();
        public UserForm(bool editMode = false)
        {
            InitializeComponent();
            this.editMode = editMode;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if (editMode)
            {
                var currentUser = NCData.CurrentUser;
                btCreateUser.Text = "Save user's data";
                tbUserName.Text = currentUser.Name;
                dtBirthDate.Value = currentUser.BirthDate.ToDateTimeUnspecified();
                var insulinPlanController = new InsulinPlanController();
                cbInsulinPlan.DataSource = insulinPlanController.UserInsulinPlans;
                cbInsulinPlan.SelectedItem = insulinPlanController.CurrentInsulinPlan;
                tbWeight.Text = currentUser.Weight.ToString();
                tbHeight.Text = currentUser.Height.ToString();
                rbUnitSystem1.Checked = currentUser.UnitSystemMgdL;
                cbGlutenFree.Checked = currentUser.GlutenFree;
                cbCalculateCalories.Checked = currentUser.CalculateCalories;
            }
        }

        private void tbWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;
            if (!Char.IsDigit(number)) e.Handled = true;
        }

        private void tbHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;
            if (!Char.IsDigit(number)) e.Handled = true;
        }

        private void btAddInsulinPlan_Click(object sender, EventArgs e)
        {
            if (!editMode) NewUserSave();
            InsulinPlanForm insulinPlanForm = new InsulinPlanForm(cbInsulinPlan.SelectedItem != null);
            insulinPlanForm.Show();
            Close();
        }

        private void btCreateUser_Click(object sender, EventArgs e)
        {
            if (editMode) UserUpdate();
            else NewUserSave();
            UsersListForm usersListForm = new UsersListForm();
            usersListForm.Show();
            Close();
        }
        private void NewUserSave()
        {
            var localDate = LocalDateTime.FromDateTime(dtBirthDate.Value);
            userController.SetNew(tbUserName.Text, localDate.Date, (Models.InsulinPlan)cbInsulinPlan.SelectedItem, Int32.Parse(tbWeight.Text),
                                          Int32.Parse(tbHeight.Text), rbUnitSystem1.Checked, cbGlutenFree.Checked,
                                          cbCalculateCalories.Checked);
        }
        private void UserUpdate()
        {
            var localDate = LocalDateTime.FromDateTime(dtBirthDate.Value);
            userController.Update(tbUserName.Text, localDate.Date, (Models.InsulinPlan)cbInsulinPlan.SelectedItem, Int32.Parse(tbWeight.Text),
                                      Int32.Parse(tbHeight.Text), rbUnitSystem1.Checked, cbGlutenFree.Checked,
                                      cbCalculateCalories.Checked);
        }
    }
}
