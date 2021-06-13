
namespace NutritionCalculator.Forms
{
    partial class DishesForm
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
            this.lvDishes = new System.Windows.Forms.ListView();
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvDishes
            // 
            this.lvDishes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.category,
            this.dish,
            this.edit});
            this.lvDishes.FullRowSelect = true;
            this.lvDishes.GridLines = true;
            this.lvDishes.HideSelection = false;
            this.lvDishes.Location = new System.Drawing.Point(4, 4);
            this.lvDishes.Name = "lvDishes";
            this.lvDishes.Size = new System.Drawing.Size(390, 542);
            this.lvDishes.TabIndex = 1;
            this.lvDishes.UseCompatibleStateImageBehavior = false;
            this.lvDishes.View = System.Windows.Forms.View.Details;
            // 
            // category
            // 
            this.category.Text = "Category";
            // 
            // dish
            // 
            this.dish.Text = "Dish";
            this.dish.Width = 280;
            // 
            // edit
            // 
            this.edit.Text = "...";
            this.edit.Width = 20;
            // 
            // btCreate
            // 
            this.btCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCreate.Location = new System.Drawing.Point(5, 566);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(389, 37);
            this.btCreate.TabIndex = 2;
            this.btCreate.Text = "Create new";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // DishesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 621);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.lvDishes);
            this.Name = "DishesForm";
            this.Text = "Dishes";
            this.Load += new System.EventHandler(this.DishesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDishes;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader dish;
        private System.Windows.Forms.ColumnHeader edit;
        private System.Windows.Forms.Button btCreate;
    }
}