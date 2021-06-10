
using NutritionCalculator.Controllers;
using NutritionCalculator.Models;
using System;

using System.Windows.Forms;

namespace NutritionCalculator.Forms
{
    public partial class UsersListForm : Form
    {
        public UsersListForm()
        {
            InitializeComponent();
            
        }

        private void OnButtonActionClick(object sender, ListViewColumnMouseEventArgs e)
        {
            try
            {
                NCData.CurrentUser = (User)usersListView.SelectedItems[0].Tag;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            UserForm userForm = new UserForm(true);
            userForm.Show();
            this.Close();
        }

        private void UsersListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void UsersListForm_Load(object sender, EventArgs e)
        {
            var userController = new UserController();
            if (userController.Users.Count > 0)
            {
                ListViewExtender extender = new ListViewExtender(usersListView);
                
                ListViewButtonColumn buttonAction = new ListViewButtonColumn(2);
                buttonAction.Click += OnButtonActionClick;
                buttonAction.FixedWidth = true;

                extender.AddColumn(buttonAction);

                foreach (var user in userController.Users)
                {
                    var row = new string[] { user.Name, user.BirthDate.ToString() };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = user;
                    usersListView.Items.Add(lvi).SubItems.Add("...");
                }
            }
            else
            {
                MessageBox.Show("Users list is epty, create a new user", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserForm userForm = new UserForm();
                userForm.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
            this.Close();
        }

        private void usersListView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                NCData.CurrentUser = (User)usersListView.SelectedItems[0].Tag;
                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
