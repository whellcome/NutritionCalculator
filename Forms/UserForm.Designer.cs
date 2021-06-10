
namespace NutritionCalculator.Forms
{
    partial class UserForm
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
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbInsulinPlan = new System.Windows.Forms.ComboBox();
            this.btAddInsulinPlan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.rbUnitSystem1 = new System.Windows.Forms.RadioButton();
            this.rbUnitsystem2 = new System.Windows.Forms.RadioButton();
            this.gbUnitSystem = new System.Windows.Forms.GroupBox();
            this.cbGlutenFree = new System.Windows.Forms.CheckBox();
            this.cbCalculateCalories = new System.Windows.Forms.CheckBox();
            this.btCreateUser = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gbUnitSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserName.Location = new System.Drawing.Point(123, 52);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(268, 22);
            this.tbUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name of user:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Day of birth:";
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtBirthDate.Location = new System.Drawing.Point(123, 105);
            this.dtBirthDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtBirthDate.MaxDate = new System.DateTime(2021, 6, 3, 0, 0, 0, 0);
            this.dtBirthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(268, 22);
            this.dtBirthDate.TabIndex = 4;
            this.dtBirthDate.Value = new System.DateTime(2021, 6, 3, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Insulin Plan:";
            // 
            // cbInsulinPlan
            // 
            this.cbInsulinPlan.FormattingEnabled = true;
            this.cbInsulinPlan.Location = new System.Drawing.Point(123, 152);
            this.cbInsulinPlan.Name = "cbInsulinPlan";
            this.cbInsulinPlan.Size = new System.Drawing.Size(245, 24);
            this.cbInsulinPlan.TabIndex = 6;
            // 
            // btAddInsulinPlan
            // 
            this.btAddInsulinPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddInsulinPlan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAddInsulinPlan.Location = new System.Drawing.Point(371, 151);
            this.btAddInsulinPlan.Margin = new System.Windows.Forms.Padding(0);
            this.btAddInsulinPlan.Name = "btAddInsulinPlan";
            this.btAddInsulinPlan.Padding = new System.Windows.Forms.Padding(0, 1, 0, 4);
            this.btAddInsulinPlan.Size = new System.Drawing.Size(24, 24);
            this.btAddInsulinPlan.TabIndex = 7;
            this.btAddInsulinPlan.Text = ":::";
            this.btAddInsulinPlan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAddInsulinPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btAddInsulinPlan.UseVisualStyleBackColor = true;
            this.btAddInsulinPlan.Click += new System.EventHandler(this.btAddInsulinPlan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Weight:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Height";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(79, 199);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(111, 22);
            this.tbWeight.TabIndex = 10;
            this.tbWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWeight_KeyPress);
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(264, 199);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(126, 22);
            this.tbHeight.TabIndex = 11;
            this.tbHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHeight_KeyPress);
            // 
            // rbUnitSystem1
            // 
            this.rbUnitSystem1.AutoSize = true;
            this.rbUnitSystem1.Location = new System.Drawing.Point(6, 21);
            this.rbUnitSystem1.Name = "rbUnitSystem1";
            this.rbUnitSystem1.Size = new System.Drawing.Size(64, 20);
            this.rbUnitSystem1.TabIndex = 13;
            this.rbUnitSystem1.TabStop = true;
            this.rbUnitSystem1.Text = "mg/dL";
            this.rbUnitSystem1.UseVisualStyleBackColor = true;
            // 
            // rbUnitsystem2
            // 
            this.rbUnitsystem2.AutoSize = true;
            this.rbUnitsystem2.Location = new System.Drawing.Point(6, 47);
            this.rbUnitsystem2.Name = "rbUnitsystem2";
            this.rbUnitsystem2.Size = new System.Drawing.Size(70, 20);
            this.rbUnitsystem2.TabIndex = 14;
            this.rbUnitsystem2.TabStop = true;
            this.rbUnitsystem2.Text = "mmol/L";
            this.rbUnitsystem2.UseVisualStyleBackColor = true;
            // 
            // gbUnitSystem
            // 
            this.gbUnitSystem.Controls.Add(this.rbUnitsystem2);
            this.gbUnitSystem.Controls.Add(this.rbUnitSystem1);
            this.gbUnitSystem.Location = new System.Drawing.Point(19, 249);
            this.gbUnitSystem.Name = "gbUnitSystem";
            this.gbUnitSystem.Size = new System.Drawing.Size(171, 72);
            this.gbUnitSystem.TabIndex = 15;
            this.gbUnitSystem.TabStop = false;
            this.gbUnitSystem.Text = "Unit System";
            // 
            // cbGlutenFree
            // 
            this.cbGlutenFree.AutoSize = true;
            this.cbGlutenFree.Location = new System.Drawing.Point(215, 270);
            this.cbGlutenFree.Name = "cbGlutenFree";
            this.cbGlutenFree.Size = new System.Drawing.Size(91, 20);
            this.cbGlutenFree.TabIndex = 16;
            this.cbGlutenFree.Text = "Gluten free";
            this.cbGlutenFree.UseVisualStyleBackColor = true;
            // 
            // cbCalculateCalories
            // 
            this.cbCalculateCalories.AutoSize = true;
            this.cbCalculateCalories.Location = new System.Drawing.Point(215, 301);
            this.cbCalculateCalories.Name = "cbCalculateCalories";
            this.cbCalculateCalories.Size = new System.Drawing.Size(136, 20);
            this.cbCalculateCalories.TabIndex = 17;
            this.cbCalculateCalories.Text = "Calculate Calories";
            this.cbCalculateCalories.UseVisualStyleBackColor = true;
            // 
            // btCreateUser
            // 
            this.btCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCreateUser.Location = new System.Drawing.Point(19, 354);
            this.btCreateUser.Name = "btCreateUser";
            this.btCreateUser.Size = new System.Drawing.Size(370, 40);
            this.btCreateUser.TabIndex = 18;
            this.btCreateUser.Text = "Create new user";
            this.btCreateUser.UseVisualStyleBackColor = true;
            this.btCreateUser.Click += new System.EventHandler(this.btCreateUser_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(63, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Enter name and parameters of a new user";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 412);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btCreateUser);
            this.Controls.Add(this.cbCalculateCalories);
            this.Controls.Add(this.cbGlutenFree);
            this.Controls.Add(this.gbUnitSystem);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btAddInsulinPlan);
            this.Controls.Add(this.cbInsulinPlan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtBirthDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUserName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.gbUnitSystem.ResumeLayout(false);
            this.gbUnitSystem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbInsulinPlan;
        private System.Windows.Forms.Button btAddInsulinPlan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.RadioButton rbUnitSystem1;
        private System.Windows.Forms.RadioButton rbUnitsystem2;
        private System.Windows.Forms.GroupBox gbUnitSystem;
        private System.Windows.Forms.CheckBox cbGlutenFree;
        private System.Windows.Forms.CheckBox cbCalculateCalories;
        private System.Windows.Forms.Button btCreateUser;
        private System.Windows.Forms.Label label6;
    }
}