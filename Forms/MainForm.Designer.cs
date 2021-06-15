
namespace NutritionCalculator.Forms
{
    partial class MainForm
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
            this.buttonSelectUser = new System.Windows.Forms.Button();
            this.btCategories = new System.Windows.Forms.Button();
            this.btFoods = new System.Windows.Forms.Button();
            this.btDishes = new System.Windows.Forms.Button();
            this.btFoodDairy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSelectUser
            // 
            this.buttonSelectUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectUser.Location = new System.Drawing.Point(13, 15);
            this.buttonSelectUser.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelectUser.Name = "buttonSelectUser";
            this.buttonSelectUser.Size = new System.Drawing.Size(290, 58);
            this.buttonSelectUser.TabIndex = 0;
            this.buttonSelectUser.Text = "Select a user";
            this.buttonSelectUser.UseVisualStyleBackColor = true;
            this.buttonSelectUser.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btCategories
            // 
            this.btCategories.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCategories.Location = new System.Drawing.Point(13, 319);
            this.btCategories.Margin = new System.Windows.Forms.Padding(4);
            this.btCategories.Name = "btCategories";
            this.btCategories.Size = new System.Drawing.Size(290, 58);
            this.btCategories.TabIndex = 1;
            this.btCategories.Text = "Categories";
            this.btCategories.UseVisualStyleBackColor = true;
            this.btCategories.Click += new System.EventHandler(this.btCategories_Click);
            // 
            // btFoods
            // 
            this.btFoods.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFoods.Location = new System.Drawing.Point(13, 165);
            this.btFoods.Margin = new System.Windows.Forms.Padding(4);
            this.btFoods.Name = "btFoods";
            this.btFoods.Size = new System.Drawing.Size(290, 58);
            this.btFoods.TabIndex = 2;
            this.btFoods.Text = "Foods";
            this.btFoods.UseVisualStyleBackColor = true;
            this.btFoods.Click += new System.EventHandler(this.btFoods_Click);
            // 
            // btDishes
            // 
            this.btDishes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDishes.Location = new System.Drawing.Point(13, 243);
            this.btDishes.Margin = new System.Windows.Forms.Padding(4);
            this.btDishes.Name = "btDishes";
            this.btDishes.Size = new System.Drawing.Size(290, 58);
            this.btDishes.TabIndex = 4;
            this.btDishes.Text = "Dishes";
            this.btDishes.UseVisualStyleBackColor = true;
            this.btDishes.Click += new System.EventHandler(this.btDishes_Click);
            // 
            // btFoodDairy
            // 
            this.btFoodDairy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btFoodDairy.Location = new System.Drawing.Point(13, 90);
            this.btFoodDairy.Name = "btFoodDairy";
            this.btFoodDairy.Size = new System.Drawing.Size(290, 58);
            this.btFoodDairy.TabIndex = 5;
            this.btFoodDairy.Text = "Food Dairy";
            this.btFoodDairy.UseVisualStyleBackColor = true;
            this.btFoodDairy.Click += new System.EventHandler(this.btFoodDairy_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(316, 395);
            this.Controls.Add(this.btFoodDairy);
            this.Controls.Add(this.btDishes);
            this.Controls.Add(this.btFoods);
            this.Controls.Add(this.btCategories);
            this.Controls.Add(this.buttonSelectUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Nutrition Calculator";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectUser;
        private System.Windows.Forms.Button btCategories;
        private System.Windows.Forms.Button btFoods;
        private System.Windows.Forms.Button btDishes;
        private System.Windows.Forms.Button btFoodDairy;
    }
}