
namespace NutritionCalculator.Forms
{
    partial class IngredientsForm
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
            this.lvIngredients = new System.Windows.Forms.ListView();
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ingredient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.foodDish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvIngredients
            // 
            this.lvIngredients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.category,
            this.ingredient,
            this.foodDish});
            this.lvIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvIngredients.FullRowSelect = true;
            this.lvIngredients.GridLines = true;
            this.lvIngredients.HideSelection = false;
            this.lvIngredients.Location = new System.Drawing.Point(0, 0);
            this.lvIngredients.Name = "lvIngredients";
            this.lvIngredients.Size = new System.Drawing.Size(414, 609);
            this.lvIngredients.TabIndex = 0;
            this.lvIngredients.UseCompatibleStateImageBehavior = false;
            this.lvIngredients.View = System.Windows.Forms.View.Details;
            this.lvIngredients.DoubleClick += new System.EventHandler(this.lvFoods_DoubleClick);
            // 
            // category
            // 
            this.category.Text = "Category";
            // 
            // ingredient
            // 
            this.ingredient.Text = "Ingredient";
            this.ingredient.Width = 280;
            // 
            // foodDish
            // 
            this.foodDish.Text = "Food/Dish";
            this.foodDish.Width = 70;
            // 
            // IngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 609);
            this.Controls.Add(this.lvIngredients);
            this.Name = "IngredientsForm";
            this.Text = "IngredientsForm";
            this.Load += new System.EventHandler(this.FoodsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvIngredients;
        private System.Windows.Forms.ColumnHeader ingredient;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader foodDish;
    }
}