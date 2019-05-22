namespace CoffeeShopWindowsFormsApp
{
    partial class CoffeShopForm
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
            this.ResultRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CustomerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.ContactNumTextBox = new System.Windows.Forms.TextBox();
            this.ContactNumLabel = new System.Windows.Forms.Label();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.OrderComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultRichTextBox1
            // 
            this.ResultRichTextBox1.BackColor = System.Drawing.Color.Honeydew;
            this.ResultRichTextBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultRichTextBox1.Location = new System.Drawing.Point(490, 52);
            this.ResultRichTextBox1.Name = "ResultRichTextBox1";
            this.ResultRichTextBox1.Size = new System.Drawing.Size(273, 374);
            this.ResultRichTextBox1.TabIndex = 0;
            this.ResultRichTextBox1.Text = "";
            // 
            // CustomerInfoGroupBox
            // 
            this.CustomerInfoGroupBox.Controls.Add(this.OrderComboBox);
            this.CustomerInfoGroupBox.Controls.Add(this.SaveButton);
            this.CustomerInfoGroupBox.Controls.Add(this.QuantityTextBox);
            this.CustomerInfoGroupBox.Controls.Add(this.QuantityLabel);
            this.CustomerInfoGroupBox.Controls.Add(this.OrderLabel);
            this.CustomerInfoGroupBox.Controls.Add(this.AddressTextBox);
            this.CustomerInfoGroupBox.Controls.Add(this.AddressLabel);
            this.CustomerInfoGroupBox.Controls.Add(this.ContactNumTextBox);
            this.CustomerInfoGroupBox.Controls.Add(this.ContactNumLabel);
            this.CustomerInfoGroupBox.Controls.Add(this.CustomerNameTextBox);
            this.CustomerInfoGroupBox.Controls.Add(this.CustomerNameLabel);
            this.CustomerInfoGroupBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerInfoGroupBox.Location = new System.Drawing.Point(26, 52);
            this.CustomerInfoGroupBox.Name = "CustomerInfoGroupBox";
            this.CustomerInfoGroupBox.Size = new System.Drawing.Size(440, 374);
            this.CustomerInfoGroupBox.TabIndex = 2;
            this.CustomerInfoGroupBox.TabStop = false;
            this.CustomerInfoGroupBox.Text = "Customer Information";
            this.CustomerInfoGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(292, 313);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(95, 31);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTextBox.Location = new System.Drawing.Point(206, 243);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(181, 26);
            this.QuantityTextBox.TabIndex = 1;
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(27, 243);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(74, 19);
            this.QuantityLabel.TabIndex = 0;
            this.QuantityLabel.Text = "Quantity";
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLabel.Location = new System.Drawing.Point(27, 205);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(52, 19);
            this.OrderLabel.TabIndex = 0;
            this.OrderLabel.Text = "Order";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTextBox.Location = new System.Drawing.Point(206, 125);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(181, 26);
            this.AddressTextBox.TabIndex = 1;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(27, 125);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(68, 19);
            this.AddressLabel.TabIndex = 0;
            this.AddressLabel.Text = "Address";
            // 
            // ContactNumTextBox
            // 
            this.ContactNumTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumTextBox.Location = new System.Drawing.Point(206, 93);
            this.ContactNumTextBox.Name = "ContactNumTextBox";
            this.ContactNumTextBox.Size = new System.Drawing.Size(181, 26);
            this.ContactNumTextBox.TabIndex = 1;
            this.ContactNumTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ContactNumLabel
            // 
            this.ContactNumLabel.AutoSize = true;
            this.ContactNumLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumLabel.Location = new System.Drawing.Point(27, 93);
            this.ContactNumLabel.Name = "ContactNumLabel";
            this.ContactNumLabel.Size = new System.Drawing.Size(129, 19);
            this.ContactNumLabel.TabIndex = 0;
            this.ContactNumLabel.Text = "Contact Number";
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameTextBox.Location = new System.Drawing.Point(206, 61);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(181, 26);
            this.CustomerNameTextBox.TabIndex = 1;
            this.CustomerNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(27, 61);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(125, 19);
            this.CustomerNameLabel.TabIndex = 0;
            this.CustomerNameLabel.Text = "Customer Name";
            // 
            // OrderComboBox
            // 
            this.OrderComboBox.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderComboBox.FormattingEnabled = true;
            this.OrderComboBox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular"});
            this.OrderComboBox.Location = new System.Drawing.Point(206, 205);
            this.OrderComboBox.Name = "OrderComboBox";
            this.OrderComboBox.Size = new System.Drawing.Size(121, 27);
            this.OrderComboBox.TabIndex = 4;
            this.OrderComboBox.Text = "item";
            this.OrderComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderComboBox_SelectedIndexChanged_1);
            // 
            // CoffeShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerInfoGroupBox);
            this.Controls.Add(this.ResultRichTextBox1);
            this.Name = "CoffeShopForm";
            this.Text = "Coffe Shop";
            this.Load += new System.EventHandler(this.CoffeShopForm_Load);
            this.CustomerInfoGroupBox.ResumeLayout(false);
            this.CustomerInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ResultRichTextBox1;
        private System.Windows.Forms.GroupBox CustomerInfoGroupBox;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox ContactNumTextBox;
        private System.Windows.Forms.Label ContactNumLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox OrderComboBox;
    }
}

