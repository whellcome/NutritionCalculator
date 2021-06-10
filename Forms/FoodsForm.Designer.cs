
namespace NutritionCalculator.Forms
{
    partial class FoodsForm
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
            this.lvFoods = new System.Windows.Forms.ListView();
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.food = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvFoods
            // 
            this.lvFoods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.category,
            this.food,
            this.edit});
            this.lvFoods.FullRowSelect = true;
            this.lvFoods.GridLines = true;
            this.lvFoods.HideSelection = false;
            this.lvFoods.Location = new System.Drawing.Point(6, 0);
            this.lvFoods.Name = "lvFoods";
            this.lvFoods.Size = new System.Drawing.Size(390, 542);
            this.lvFoods.TabIndex = 0;
            this.lvFoods.UseCompatibleStateImageBehavior = false;
            this.lvFoods.View = System.Windows.Forms.View.Details;
            this.lvFoods.DoubleClick += new System.EventHandler(this.lvFoods_DoubleClick);
            // 
            // category
            // 
            this.category.Text = "Category";
            // 
            // food
            // 
            this.food.Text = "Food";
            this.food.Width = 280;
            // 
            // edit
            // 
            this.edit.Text = "...";
            this.edit.Width = 20;
            // 
            // btCreate
            // 
            this.btCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCreate.Location = new System.Drawing.Point(6, 560);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(389, 37);
            this.btCreate.TabIndex = 1;
            this.btCreate.Text = "Create new";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // FoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 609);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.lvFoods);
            this.Name = "FoodsForm";
            this.Text = "FoodsForm";
            this.Load += new System.EventHandler(this.FoodsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvFoods;
        private System.Windows.Forms.ColumnHeader food;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader edit;
        private System.Windows.Forms.Button btCreate;
    }
}