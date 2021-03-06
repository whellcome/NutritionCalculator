
namespace NutritionCalculator.Forms
{
    partial class DishForm
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
            this.components = new System.ComponentModel.Container();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCarbohydrates = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProteins = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFats = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGlycemicIndex = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.btSelectCategory = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.txtWastageFactor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPortionMass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nutrientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dishesControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesControllerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(139, 70);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 25);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDescription.Location = new System.Drawing.Point(139, 112);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(192, 103);
            this.txtDescription.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Carbohydrates";
            // 
            // txtCarbohydrates
            // 
            this.txtCarbohydrates.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCarbohydrates.Location = new System.Drawing.Point(145, 30);
            this.txtCarbohydrates.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarbohydrates.Name = "txtCarbohydrates";
            this.txtCarbohydrates.ReadOnly = true;
            this.txtCarbohydrates.Size = new System.Drawing.Size(63, 25);
            this.txtCarbohydrates.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Proteins";
            // 
            // txtProteins
            // 
            this.txtProteins.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProteins.Location = new System.Drawing.Point(145, 60);
            this.txtProteins.Margin = new System.Windows.Forms.Padding(4);
            this.txtProteins.Name = "txtProteins";
            this.txtProteins.ReadOnly = true;
            this.txtProteins.Size = new System.Drawing.Size(63, 25);
            this.txtProteins.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fats";
            // 
            // txtFats
            // 
            this.txtFats.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFats.Location = new System.Drawing.Point(145, 90);
            this.txtFats.Margin = new System.Windows.Forms.Padding(4);
            this.txtFats.Name = "txtFats";
            this.txtFats.ReadOnly = true;
            this.txtFats.Size = new System.Drawing.Size(63, 25);
            this.txtFats.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Calories";
            // 
            // txtCalories
            // 
            this.txtCalories.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCalories.Location = new System.Drawing.Point(145, 120);
            this.txtCalories.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.ReadOnly = true;
            this.txtCalories.Size = new System.Drawing.Size(63, 25);
            this.txtCalories.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "GlycemicIndex";
            // 
            // txtGlycemicIndex
            // 
            this.txtGlycemicIndex.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtGlycemicIndex.Location = new System.Drawing.Point(145, 150);
            this.txtGlycemicIndex.Margin = new System.Windows.Forms.Padding(4);
            this.txtGlycemicIndex.Name = "txtGlycemicIndex";
            this.txtGlycemicIndex.Size = new System.Drawing.Size(63, 25);
            this.txtGlycemicIndex.TabIndex = 14;
            this.txtGlycemicIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGlycemicIndex_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtGlycemicIndex);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCalories);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFats);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtProteins);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCarbohydrates);
            this.groupBox1.Location = new System.Drawing.Point(13, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 195);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Energy values";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Category";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(139, 40);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(53, 16);
            this.lbCategory.TabIndex = 18;
            this.lbCategory.Text = "select...";
            // 
            // btSelectCategory
            // 
            this.btSelectCategory.Location = new System.Drawing.Point(306, 31);
            this.btSelectCategory.Name = "btSelectCategory";
            this.btSelectCategory.Size = new System.Drawing.Size(25, 25);
            this.btSelectCategory.TabIndex = 19;
            this.btSelectCategory.Text = ":::";
            this.btSelectCategory.UseVisualStyleBackColor = true;
            this.btSelectCategory.Click += new System.EventHandler(this.btSelectCategory_Click);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSave.Location = new System.Drawing.Point(338, 454);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(314, 31);
            this.btSave.TabIndex = 20;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // dgvIngredients
            // 
            this.dgvIngredients.AutoGenerateColumns = false;
            this.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nutrientDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dgvIngredients.DataSource = this.ingredientBindingSource;
            this.dgvIngredients.Location = new System.Drawing.Point(338, 75);
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.Size = new System.Drawing.Size(313, 373);
            this.dgvIngredients.TabIndex = 21;
            this.dgvIngredients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredients_CellDoubleClick);
            this.dgvIngredients.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredients_CellEndEdit);
            // 
            // txtWastageFactor
            // 
            this.txtWastageFactor.Location = new System.Drawing.Point(200, 432);
            this.txtWastageFactor.Name = "txtWastageFactor";
            this.txtWastageFactor.Size = new System.Drawing.Size(44, 22);
            this.txtWastageFactor.TabIndex = 22;
            this.txtWastageFactor.TextChanged += new System.EventHandler(this.txtWastageFactor_TextChanged);
            this.txtWastageFactor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGlycemicIndex_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Water Wastage Factor";
            // 
            // txtPortionMass
            // 
            this.txtPortionMass.Location = new System.Drawing.Point(200, 463);
            this.txtPortionMass.Name = "txtPortionMass";
            this.txtPortionMass.Size = new System.Drawing.Size(44, 22);
            this.txtPortionMass.TabIndex = 24;
            this.txtPortionMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGlycemicIndex_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 469);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Portion mass";
            // 
            // nutrientDataGridViewTextBoxColumn
            // 
            this.nutrientDataGridViewTextBoxColumn.DataPropertyName = "Nutrient";
            this.nutrientDataGridViewTextBoxColumn.HeaderText = "Nutrient";
            this.nutrientDataGridViewTextBoxColumn.Name = "nutrientDataGridViewTextBoxColumn";
            this.nutrientDataGridViewTextBoxColumn.ReadOnly = true;
            this.nutrientDataGridViewTextBoxColumn.Width = 200;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 70;
            // 
            // ingredientBindingSource
            // 
            this.ingredientBindingSource.DataSource = typeof(NutritionCalculator.Models.Ingredient);
            // 
            // dishesControllerBindingSource
            // 
            this.dishesControllerBindingSource.DataSource = typeof(NutritionCalculator.Controllers.DishesController);
            // 
            // DishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 493);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPortionMass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWastageFactor);
            this.Controls.Add(this.dgvIngredients);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btSelectCategory);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DishForm";
            this.Text = "DishForm";
            this.Load += new System.EventHandler(this.DishForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesControllerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCarbohydrates;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProteins;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFats;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCalories;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGlycemicIndex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Button btSelectCategory;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DataGridView dgvIngredients;
        private System.Windows.Forms.BindingSource ingredientBindingSource;
        private System.Windows.Forms.BindingSource dishesControllerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nutrientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtWastageFactor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPortionMass;
        private System.Windows.Forms.Label label10;
    }
}