namespace Party_Planner
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.numberDinner = new System.Windows.Forms.NumericUpDown();
            this.fancyDinnerBox = new System.Windows.Forms.CheckBox();
            this.healthyDinnerBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dinnerCostLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fancyBirthday = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.birthdayCostLabel = new System.Windows.Forms.Label();
            this.cakeWritingTxtBox = new System.Windows.Forms.TextBox();
            this.numberBithday = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberDinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBithday)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(226, 224);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dinnerCostLabel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.healthyDinnerBox);
            this.tabPage1.Controls.Add(this.fancyDinnerBox);
            this.tabPage1.Controls.Add(this.numberDinner);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(218, 198);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numberBithday);
            this.tabPage2.Controls.Add(this.cakeWritingTxtBox);
            this.tabPage2.Controls.Add(this.birthdayCostLabel);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tooLongLabel);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.fancyBirthday);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(218, 198);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of people";
            // 
            // numberDinner
            // 
            this.numberDinner.Location = new System.Drawing.Point(35, 45);
            this.numberDinner.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberDinner.Name = "numberDinner";
            this.numberDinner.Size = new System.Drawing.Size(120, 20);
            this.numberDinner.TabIndex = 1;
            this.numberDinner.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberDinner.ValueChanged += new System.EventHandler(this.numberDinner_ValueChanged);
            // 
            // fancyDinnerBox
            // 
            this.fancyDinnerBox.AutoSize = true;
            this.fancyDinnerBox.Location = new System.Drawing.Point(44, 71);
            this.fancyDinnerBox.Name = "fancyDinnerBox";
            this.fancyDinnerBox.Size = new System.Drawing.Size(115, 17);
            this.fancyDinnerBox.TabIndex = 2;
            this.fancyDinnerBox.Text = "Fancy Decorations";
            this.fancyDinnerBox.UseVisualStyleBackColor = true;
            this.fancyDinnerBox.CheckedChanged += new System.EventHandler(this.fancyDinnerBox_CheckedChanged);
            // 
            // healthyDinnerBox
            // 
            this.healthyDinnerBox.AutoSize = true;
            this.healthyDinnerBox.Location = new System.Drawing.Point(44, 94);
            this.healthyDinnerBox.Name = "healthyDinnerBox";
            this.healthyDinnerBox.Size = new System.Drawing.Size(96, 17);
            this.healthyDinnerBox.TabIndex = 3;
            this.healthyDinnerBox.Text = "Healthy Option";
            this.healthyDinnerBox.UseVisualStyleBackColor = true;
            this.healthyDinnerBox.CheckedChanged += new System.EventHandler(this.healthyDinnerBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cost";
            // 
            // dinnerCostLabel
            // 
            this.dinnerCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dinnerCostLabel.Location = new System.Drawing.Point(79, 146);
            this.dinnerCostLabel.Name = "dinnerCostLabel";
            this.dinnerCostLabel.Size = new System.Drawing.Size(100, 20);
            this.dinnerCostLabel.TabIndex = 5;
            this.dinnerCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number of people";
            // 
            // fancyBirthday
            // 
            this.fancyBirthday.AutoSize = true;
            this.fancyBirthday.Location = new System.Drawing.Point(48, 60);
            this.fancyBirthday.Name = "fancyBirthday";
            this.fancyBirthday.Size = new System.Drawing.Size(115, 17);
            this.fancyBirthday.TabIndex = 1;
            this.fancyBirthday.Text = "Fancy Decorations";
            this.fancyBirthday.UseVisualStyleBackColor = true;
            this.fancyBirthday.CheckedChanged += new System.EventHandler(this.fancyBirthday_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cake Writing";
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.BackColor = System.Drawing.Color.Red;
            this.tooLongLabel.Location = new System.Drawing.Point(133, 94);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(63, 15);
            this.tooLongLabel.TabIndex = 3;
            this.tooLongLabel.Text = "TOO LONG";
            this.tooLongLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tooLongLabel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cost";
            // 
            // birthdayCostLabel
            // 
            this.birthdayCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.birthdayCostLabel.Location = new System.Drawing.Point(86, 148);
            this.birthdayCostLabel.Name = "birthdayCostLabel";
            this.birthdayCostLabel.Size = new System.Drawing.Size(100, 20);
            this.birthdayCostLabel.TabIndex = 5;
            this.birthdayCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cakeWritingTxtBox
            // 
            this.cakeWritingTxtBox.Location = new System.Drawing.Point(27, 110);
            this.cakeWritingTxtBox.Name = "cakeWritingTxtBox";
            this.cakeWritingTxtBox.Size = new System.Drawing.Size(169, 20);
            this.cakeWritingTxtBox.TabIndex = 6;
            this.cakeWritingTxtBox.TextChanged += new System.EventHandler(this.cakeWritingTxtBox_TextChanged);
            // 
            // numberBithday
            // 
            this.numberBithday.Location = new System.Drawing.Point(48, 34);
            this.numberBithday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberBithday.Name = "numberBithday";
            this.numberBithday.Size = new System.Drawing.Size(120, 20);
            this.numberBithday.TabIndex = 7;
            this.numberBithday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberBithday.ValueChanged += new System.EventHandler(this.numberBithday_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 225);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberDinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBithday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label dinnerCostLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox healthyDinnerBox;
        private System.Windows.Forms.CheckBox fancyDinnerBox;
        private System.Windows.Forms.NumericUpDown numberDinner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox cakeWritingTxtBox;
        private System.Windows.Forms.Label birthdayCostLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox fancyBirthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numberBithday;
    }
}

