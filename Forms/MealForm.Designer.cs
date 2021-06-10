
namespace NutritionCalculator.Forms
{
    partial class MealForm
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
            this.dgvMealItems = new System.Windows.Forms.DataGridView();
            this.mealsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mealItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpMealDateTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbConsist = new System.Windows.Forms.Label();
            this.mealsControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nutrientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealsControllerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMealItems
            // 
            this.dgvMealItems.AutoGenerateColumns = false;
            this.dgvMealItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nutrientDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dgvMealItems.DataSource = this.mealItemsBindingSource;
            this.dgvMealItems.Location = new System.Drawing.Point(225, 15);
            this.dgvMealItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMealItems.Name = "dgvMealItems";
            this.dgvMealItems.Size = new System.Drawing.Size(381, 390);
            this.dgvMealItems.TabIndex = 0;
            this.dgvMealItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMealItems_CellEndEdit);
            this.dgvMealItems.Click += new System.EventHandler(this.dgvMealItems_Click);
            // 
            // mealsBindingSource
            // 
            this.mealsBindingSource.DataMember = "Meals";
            this.mealsBindingSource.DataSource = this.mealsControllerBindingSource;
            // 
            // mealItemsBindingSource
            // 
            this.mealItemsBindingSource.DataMember = "MealItems";
            this.mealItemsBindingSource.DataSource = this.mealsBindingSource;
            // 
            // dtpMealDateTime
            // 
            this.dtpMealDateTime.CustomFormat = "dd.MM.yyy : hh.mm";
            this.dtpMealDateTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mealsBindingSource, "LocalDateTime", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "g"));
            this.dtpMealDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMealDateTime.Location = new System.Drawing.Point(13, 71);
            this.dtpMealDateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpMealDateTime.Name = "dtpMealDateTime";
            this.dtpMealDateTime.Size = new System.Drawing.Size(201, 22);
            this.dtpMealDateTime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Date Time and\r\nClick on a food cell\r\nto add a food item from the list.";
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSave.Location = new System.Drawing.Point(13, 351);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(201, 54);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mealsControllerBindingSource, "CurrentUser", true));
            this.lbUser.Location = new System.Drawing.Point(10, 107);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(40, 16);
            this.lbUser.TabIndex = 4;
            this.lbUser.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "This meal contains:";
            // 
            // lbConsist
            // 
            this.lbConsist.AutoSize = true;
            this.lbConsist.Location = new System.Drawing.Point(12, 154);
            this.lbConsist.Name = "lbConsist";
            this.lbConsist.Size = new System.Drawing.Size(50, 16);
            this.lbConsist.TabIndex = 6;
            this.lbConsist.Text = "consist";
            // 
            // mealsControllerBindingSource
            // 
            this.mealsControllerBindingSource.DataSource = typeof(NutritionCalculator.Controllers.MealsController);
            // 
            // nutrientDataGridViewTextBoxColumn
            // 
            this.nutrientDataGridViewTextBoxColumn.DataPropertyName = "Nutrient";
            this.nutrientDataGridViewTextBoxColumn.HeaderText = "Nutrient";
            this.nutrientDataGridViewTextBoxColumn.Name = "nutrientDataGridViewTextBoxColumn";
            this.nutrientDataGridViewTextBoxColumn.ReadOnly = true;
            this.nutrientDataGridViewTextBoxColumn.Width = 238;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // MealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 420);
            this.Controls.Add(this.lbConsist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpMealDateTime);
            this.Controls.Add(this.dgvMealItems);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MealForm";
            this.Text = "MealForm";
            this.Load += new System.EventHandler(this.MealForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealsControllerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMealItems;
        private System.Windows.Forms.BindingSource mealItemsBindingSource;
        private System.Windows.Forms.BindingSource mealsBindingSource;
        private System.Windows.Forms.BindingSource mealsControllerBindingSource;
        private System.Windows.Forms.DateTimePicker dtpMealDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn nutrientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbConsist;
    }
}