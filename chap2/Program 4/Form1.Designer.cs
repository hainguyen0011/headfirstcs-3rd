namespace Program_4
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
            this.changeText = new System.Windows.Forms.Button();
            this.labelToChange = new System.Windows.Forms.Label();
            this.enableCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // changeText
            // 
            this.changeText.Location = new System.Drawing.Point(63, 30);
            this.changeText.Name = "changeText";
            this.changeText.Size = new System.Drawing.Size(146, 23);
            this.changeText.TabIndex = 0;
            this.changeText.Text = "Change label if checked";
            this.changeText.UseVisualStyleBackColor = true;
            this.changeText.Click += new System.EventHandler(this.changeText_Click);
            // 
            // labelToChange
            // 
            this.labelToChange.Location = new System.Drawing.Point(12, 117);
            this.labelToChange.Name = "labelToChange";
            this.labelToChange.Size = new System.Drawing.Size(526, 23);
            this.labelToChange.TabIndex = 1;
            this.labelToChange.Text = "Press button to change text";
            this.labelToChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enableCheckbox
            // 
            this.enableCheckbox.AutoSize = true;
            this.enableCheckbox.Location = new System.Drawing.Point(356, 34);
            this.enableCheckbox.Name = "enableCheckbox";
            this.enableCheckbox.Size = new System.Drawing.Size(131, 17);
            this.enableCheckbox.TabIndex = 2;
            this.enableCheckbox.Text = "Enable label changing";
            this.enableCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(550, 168);
            this.Controls.Add(this.enableCheckbox);
            this.Controls.Add(this.labelToChange);
            this.Controls.Add(this.changeText);
            this.Name = "Form1";
            this.Text = "My Window App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeText;
        private System.Windows.Forms.Label labelToChange;
        private System.Windows.Forms.CheckBox enableCheckbox;
    }
}

