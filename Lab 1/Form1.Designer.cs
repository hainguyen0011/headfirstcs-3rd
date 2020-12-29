namespace Lab_1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dog1_pictureBox = new System.Windows.Forms.PictureBox();
            this.dog2_pictureBox = new System.Windows.Forms.PictureBox();
            this.dog3_pictureBox = new System.Windows.Forms.PictureBox();
            this.dog4_pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.raceButton = new System.Windows.Forms.Button();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.betLabel = new System.Windows.Forms.Label();
            this.buckUpDown = new System.Windows.Forms.NumericUpDown();
            this.indexUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.betButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.raceTrackPictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dog1_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4_pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buckUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dog1_pictureBox
            // 
            this.dog1_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("dog1_pictureBox.Image")));
            this.dog1_pictureBox.Location = new System.Drawing.Point(24, 15);
            this.dog1_pictureBox.Name = "dog1_pictureBox";
            this.dog1_pictureBox.Size = new System.Drawing.Size(75, 20);
            this.dog1_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog1_pictureBox.TabIndex = 2;
            this.dog1_pictureBox.TabStop = false;
            // 
            // dog2_pictureBox
            // 
            this.dog2_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("dog2_pictureBox.Image")));
            this.dog2_pictureBox.Location = new System.Drawing.Point(24, 63);
            this.dog2_pictureBox.Name = "dog2_pictureBox";
            this.dog2_pictureBox.Size = new System.Drawing.Size(75, 20);
            this.dog2_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog2_pictureBox.TabIndex = 3;
            this.dog2_pictureBox.TabStop = false;
            // 
            // dog3_pictureBox
            // 
            this.dog3_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("dog3_pictureBox.Image")));
            this.dog3_pictureBox.Location = new System.Drawing.Point(24, 115);
            this.dog3_pictureBox.Name = "dog3_pictureBox";
            this.dog3_pictureBox.Size = new System.Drawing.Size(75, 20);
            this.dog3_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog3_pictureBox.TabIndex = 4;
            this.dog3_pictureBox.TabStop = false;
            // 
            // dog4_pictureBox
            // 
            this.dog4_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("dog4_pictureBox.Image")));
            this.dog4_pictureBox.Location = new System.Drawing.Point(24, 163);
            this.dog4_pictureBox.Name = "dog4_pictureBox";
            this.dog4_pictureBox.Size = new System.Drawing.Size(75, 20);
            this.dog4_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog4_pictureBox.TabIndex = 5;
            this.dog4_pictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.raceButton);
            this.groupBox1.Controls.Add(this.alBetLabel);
            this.groupBox1.Controls.Add(this.bobBetLabel);
            this.groupBox1.Controls.Add(this.joeBetLabel);
            this.groupBox1.Controls.Add(this.betLabel);
            this.groupBox1.Controls.Add(this.buckUpDown);
            this.groupBox1.Controls.Add(this.indexUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.betButton);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.alRadioButton);
            this.groupBox1.Controls.Add(this.bobRadioButton);
            this.groupBox1.Controls.Add(this.joeRadioButton);
            this.groupBox1.Controls.Add(this.minimumBetLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 159);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Palor";
            // 
            // raceButton
            // 
            this.raceButton.Location = new System.Drawing.Point(410, 40);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(141, 85);
            this.raceButton.TabIndex = 13;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(208, 98);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(158, 18);
            this.alBetLabel.TabIndex = 12;
            this.alBetLabel.Text = "alBetLabel";
            this.alBetLabel.Visible = false;
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(208, 75);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(158, 18);
            this.bobBetLabel.TabIndex = 11;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(208, 52);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(158, 18);
            this.joeBetLabel.TabIndex = 10;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betLabel.Location = new System.Drawing.Point(205, 25);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(40, 17);
            this.betLabel.TabIndex = 9;
            this.betLabel.Text = "Bets";
            // 
            // buckUpDown
            // 
            this.buckUpDown.Location = new System.Drawing.Point(118, 129);
            this.buckUpDown.Maximum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.buckUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.buckUpDown.Name = "buckUpDown";
            this.buckUpDown.Size = new System.Drawing.Size(43, 20);
            this.buckUpDown.TabIndex = 8;
            this.buckUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // indexUpDown
            // 
            this.indexUpDown.Location = new System.Drawing.Point(283, 129);
            this.indexUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.indexUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.indexUpDown.Name = "indexUpDown";
            this.indexUpDown.Size = new System.Drawing.Size(43, 20);
            this.indexUpDown.TabIndex = 7;
            this.indexUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "bucks on dog number";
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(60, 127);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(47, 23);
            this.betButton.TabIndex = 5;
            this.betButton.Text = "Bets";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(23, 132);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(33, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "name";
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(12, 97);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(34, 17);
            this.alRadioButton.TabIndex = 3;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "Al";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.Visible = false;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(12, 74);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(44, 17);
            this.bobRadioButton.TabIndex = 2;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "Bob";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(12, 51);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(42, 17);
            this.joeRadioButton.TabIndex = 1;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "Joe";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(9, 25);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(134, 17);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "minimumBetLabel";
            // 
            // raceTrackPictureBox
            // 
            this.raceTrackPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("raceTrackPictureBox.Image")));
            this.raceTrackPictureBox.Location = new System.Drawing.Point(14, 8);
            this.raceTrackPictureBox.Name = "raceTrackPictureBox";
            this.raceTrackPictureBox.Size = new System.Drawing.Size(600, 187);
            this.raceTrackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raceTrackPictureBox.TabIndex = 7;
            this.raceTrackPictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 363);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dog4_pictureBox);
            this.Controls.Add(this.dog3_pictureBox);
            this.Controls.Add(this.dog2_pictureBox);
            this.Controls.Add(this.dog1_pictureBox);
            this.Controls.Add(this.raceTrackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.dog1_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4_pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buckUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox dog1_pictureBox;
        private System.Windows.Forms.PictureBox dog2_pictureBox;
        private System.Windows.Forms.PictureBox dog3_pictureBox;
        private System.Windows.Forms.PictureBox dog4_pictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.NumericUpDown buckUpDown;
        private System.Windows.Forms.NumericUpDown indexUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.PictureBox raceTrackPictureBox;
        private System.Windows.Forms.Timer timer1;
    }
}

