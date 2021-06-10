
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
            this.btMeal = new System.Windows.Forms.Button();
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
            this.btCategories.Location = new System.Drawing.Point(13, 446);
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
            this.btFoods.Location = new System.Drawing.Point(13, 97);
            this.btFoods.Margin = new System.Windows.Forms.Padding(4);
            this.btFoods.Name = "btFoods";
            this.btFoods.Size = new System.Drawing.Size(290, 58);
            this.btFoods.TabIndex = 2;
            this.btFoods.Text = "Foods";
            this.btFoods.UseVisualStyleBackColor = true;
            this.btFoods.Click += new System.EventHandler(this.btFoods_Click);
            // 
            // btMeal
            // 
            this.btMeal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMeal.Location = new System.Drawing.Point(13, 381);
            this.btMeal.Name = "btMeal";
            this.btMeal.Size = new System.Drawing.Size(290, 58);
            this.btMeal.TabIndex = 3;
            this.btMeal.Text = "Meal";
            this.btMeal.UseVisualStyleBackColor = true;
            this.btMeal.Click += new System.EventHandler(this.btMeal_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 554);
            this.Controls.Add(this.btMeal);
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
        private System.Windows.Forms.Button btMeal;
    }
}