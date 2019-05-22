namespace CalculatorWindowsFormsApp_Partice_02
{
    partial class CalculatorForm
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
            this.FirstNumberlabel = new System.Windows.Forms.Label();
            this.FirstNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SecoundNumberTextBox2 = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FirstNumberlabel
            // 
            this.FirstNumberlabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FirstNumberlabel.Location = new System.Drawing.Point(147, 64);
            this.FirstNumberlabel.Name = "FirstNumberlabel";
            this.FirstNumberlabel.Size = new System.Drawing.Size(100, 43);
            this.FirstNumberlabel.TabIndex = 0;
            this.FirstNumberlabel.Text = "First Number";
            this.FirstNumberlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FirstNumberlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstNumberTextBox
            // 
            this.FirstNumberTextBox.BackColor = System.Drawing.Color.White;
            this.FirstNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNumberTextBox.Location = new System.Drawing.Point(271, 64);
            this.FirstNumberTextBox.Multiline = true;
            this.FirstNumberTextBox.Name = "FirstNumberTextBox";
            this.FirstNumberTextBox.Size = new System.Drawing.Size(136, 40);
            this.FirstNumberTextBox.TabIndex = 1;
            this.FirstNumberTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(147, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Secound Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SecoundNumberTextBox2
            // 
            this.SecoundNumberTextBox2.BackColor = System.Drawing.Color.White;
            this.SecoundNumberTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecoundNumberTextBox2.Location = new System.Drawing.Point(271, 117);
            this.SecoundNumberTextBox2.Multiline = true;
            this.SecoundNumberTextBox2.Name = "SecoundNumberTextBox2";
            this.SecoundNumberTextBox2.Size = new System.Drawing.Size(136, 40);
            this.SecoundNumberTextBox2.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(32, 243);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(113, 36);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add (+)";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Location = new System.Drawing.Point(151, 242);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(113, 36);
            this.SubtractButton.TabIndex = 3;
            this.SubtractButton.Text = "Subtract (-)";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(272, 242);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(113, 36);
            this.MultiplyButton.TabIndex = 4;
            this.MultiplyButton.Text = "Multiply (*)";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(391, 243);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(113, 36);
            this.DivideButton.TabIndex = 5;
            this.DivideButton.Text = "Divide (/)";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ResultLabel.Location = new System.Drawing.Point(149, 172);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(101, 41);
            this.ResultLabel.TabIndex = 6;
            this.ResultLabel.Text = "Result ::";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.Location = new System.Drawing.Point(271, 172);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(136, 41);
            this.ResultTextBox.TabIndex = 7;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(570, 343);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SecoundNumberTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNumberTextBox);
            this.Controls.Add(this.FirstNumberlabel);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNumberlabel;
        private System.Windows.Forms.TextBox FirstNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SecoundNumberTextBox2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}

