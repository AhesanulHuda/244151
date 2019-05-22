namespace Practice_01_WindowsFormsApp
{
    partial class PracticeOneForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNamelabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FatherNamelabel = new System.Windows.Forms.Label();
            this.FatherNameTextBox = new System.Windows.Forms.TextBox();
            this.MotherNamelabel = new System.Windows.Forms.Label();
            this.MotherNameTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ShowAllinfoButton = new System.Windows.Forms.Button();
            this.NameButton = new System.Windows.Forms.Button();
            this.ParentsInfoButton = new System.Windows.Forms.Button();
            this.AddressButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 25);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(343, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(21, 112);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(131, 23);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(233, 107);
            this.FirstNameTextBox.Multiline = true;
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(279, 28);
            this.FirstNameTextBox.TabIndex = 2;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // LastNamelabel
            // 
            this.LastNamelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LastNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNamelabel.Location = new System.Drawing.Point(21, 161);
            this.LastNamelabel.Name = "LastNamelabel";
            this.LastNamelabel.Size = new System.Drawing.Size(100, 23);
            this.LastNamelabel.TabIndex = 3;
            this.LastNamelabel.Text = "Last Name";
            this.LastNamelabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(233, 152);
            this.LastNameTextBox.Multiline = true;
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(279, 32);
            this.LastNameTextBox.TabIndex = 4;
            // 
            // FatherNamelabel
            // 
            this.FatherNamelabel.AutoSize = true;
            this.FatherNamelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FatherNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatherNamelabel.Location = new System.Drawing.Point(21, 210);
            this.FatherNamelabel.Name = "FatherNamelabel";
            this.FatherNamelabel.Size = new System.Drawing.Size(113, 20);
            this.FatherNamelabel.TabIndex = 5;
            this.FatherNamelabel.Text = "Father Name";
            this.FatherNamelabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // FatherNameTextBox
            // 
            this.FatherNameTextBox.Location = new System.Drawing.Point(233, 200);
            this.FatherNameTextBox.Multiline = true;
            this.FatherNameTextBox.Name = "FatherNameTextBox";
            this.FatherNameTextBox.Size = new System.Drawing.Size(279, 30);
            this.FatherNameTextBox.TabIndex = 6;
            // 
            // MotherNamelabel
            // 
            this.MotherNamelabel.AutoSize = true;
            this.MotherNamelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MotherNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotherNamelabel.Location = new System.Drawing.Point(21, 260);
            this.MotherNamelabel.Name = "MotherNamelabel";
            this.MotherNamelabel.Size = new System.Drawing.Size(116, 20);
            this.MotherNamelabel.TabIndex = 7;
            this.MotherNamelabel.Text = "Mother Name";
            // 
            // MotherNameTextBox
            // 
            this.MotherNameTextBox.Location = new System.Drawing.Point(233, 246);
            this.MotherNameTextBox.Multiline = true;
            this.MotherNameTextBox.Name = "MotherNameTextBox";
            this.MotherNameTextBox.Size = new System.Drawing.Size(279, 34);
            this.MotherNameTextBox.TabIndex = 8;
            this.MotherNameTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(26, 311);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(75, 20);
            this.AddressLabel.TabIndex = 9;
            this.AddressLabel.Text = "Address";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(233, 301);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(279, 30);
            this.AddressTextBox.TabIndex = 10;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SaveButton.ForeColor = System.Drawing.Color.Snow;
            this.SaveButton.Location = new System.Drawing.Point(233, 383);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 39);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.button1_Click);
            this.SaveButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SaveButton_MouseClick);
            // 
            // ShowAllinfoButton
            // 
            this.ShowAllinfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ShowAllinfoButton.Location = new System.Drawing.Point(335, 383);
            this.ShowAllinfoButton.Name = "ShowAllinfoButton";
            this.ShowAllinfoButton.Size = new System.Drawing.Size(177, 39);
            this.ShowAllinfoButton.TabIndex = 12;
            this.ShowAllinfoButton.Text = "Show All information";
            this.ShowAllinfoButton.UseVisualStyleBackColor = false;
            this.ShowAllinfoButton.Click += new System.EventHandler(this.ShowAllinfoButton_Click);
            // 
            // NameButton
            // 
            this.NameButton.Location = new System.Drawing.Point(233, 439);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(75, 39);
            this.NameButton.TabIndex = 13;
            this.NameButton.Text = "Name";
            this.NameButton.UseVisualStyleBackColor = true;
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // ParentsInfoButton
            // 
            this.ParentsInfoButton.Location = new System.Drawing.Point(314, 439);
            this.ParentsInfoButton.Name = "ParentsInfoButton";
            this.ParentsInfoButton.Size = new System.Drawing.Size(107, 39);
            this.ParentsInfoButton.TabIndex = 14;
            this.ParentsInfoButton.Text = "Parents Name";
            this.ParentsInfoButton.UseVisualStyleBackColor = true;
            this.ParentsInfoButton.Click += new System.EventHandler(this.ParentsInfoButton_Click);
            // 
            // AddressButton
            // 
            this.AddressButton.Location = new System.Drawing.Point(427, 439);
            this.AddressButton.Name = "AddressButton";
            this.AddressButton.Size = new System.Drawing.Size(75, 39);
            this.AddressButton.TabIndex = 15;
            this.AddressButton.Text = "Address";
            this.AddressButton.UseVisualStyleBackColor = true;
            this.AddressButton.Click += new System.EventHandler(this.AddressButton_Click);
            // 
            // PracticeOneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 525);
            this.Controls.Add(this.AddressButton);
            this.Controls.Add(this.ParentsInfoButton);
            this.Controls.Add(this.NameButton);
            this.Controls.Add(this.ShowAllinfoButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.MotherNameTextBox);
            this.Controls.Add(this.MotherNamelabel);
            this.Controls.Add(this.FatherNameTextBox);
            this.Controls.Add(this.FatherNamelabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNamelabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "PracticeOneForm";
            this.Text = "Normal form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label LastNamelabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label FatherNamelabel;
        private System.Windows.Forms.TextBox FatherNameTextBox;
        private System.Windows.Forms.Label MotherNamelabel;
        private System.Windows.Forms.TextBox MotherNameTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ShowAllinfoButton;
        private System.Windows.Forms.Button NameButton;
        private System.Windows.Forms.Button ParentsInfoButton;
        private System.Windows.Forms.Button AddressButton;
    }
}

