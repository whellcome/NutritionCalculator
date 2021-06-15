
namespace NutritionCalculator.Forms
{
    partial class MealsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvMeals = new System.Windows.Forms.ListView();
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.meal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvMeals
            // 
            this.lvMeals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.date,
            this.meal,
            this.edit});
            this.lvMeals.FullRowSelect = true;
            this.lvMeals.GridLines = true;
            this.lvMeals.HideSelection = false;
            this.lvMeals.Location = new System.Drawing.Point(3, -3);
            this.lvMeals.Name = "lvMeals";
            this.lvMeals.Size = new System.Drawing.Size(390, 542);
            this.lvMeals.TabIndex = 2;
            this.lvMeals.UseCompatibleStateImageBehavior = false;
            this.lvMeals.View = System.Windows.Forms.View.Details;
            // 
            // date
            // 
            this.date.Text = "";
            this.date.Width = 0;
            // 
            // meal
            // 
            this.meal.Text = "Meal";
            this.meal.Width = 340;
            // 
            // edit
            // 
            this.edit.Text = "...";
            this.edit.Width = 30;
            // 
            // btCreate
            // 
            this.btCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCreate.Location = new System.Drawing.Point(4, 550);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(389, 37);
            this.btCreate.TabIndex = 3;
            this.btCreate.Text = "Add a Meal";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // MealsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 599);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.lvMeals);
            this.Name = "MealsForm";
            this.Text = "MealsForm";
            this.Load += new System.EventHandler(this.MealsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMeals;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader meal;
        private System.Windows.Forms.ColumnHeader edit;
        private System.Windows.Forms.Button btCreate;
    }
}