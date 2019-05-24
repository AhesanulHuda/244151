namespace CoffeShopArrayWindowsFormsApp
{
    partial class coffeShopForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.customerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLlabel = new System.Windows.Forms.Label();
            this.contactNoTextBox = new System.Windows.Forms.TextBox();
            this.contactNumberLabel = new System.Windows.Forms.Label();
            this.customerNametextBox = new System.Windows.Forms.TextBox();
            this.CustomerNamLlabel = new System.Windows.Forms.Label();
            this.customerInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(415, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(245, 382);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // customerInfoGroupBox
            // 
            this.customerInfoGroupBox.Controls.Add(this.orderComboBox);
            this.customerInfoGroupBox.Controls.Add(this.saveButton);
            this.customerInfoGroupBox.Controls.Add(this.quantityTextBox);
            this.customerInfoGroupBox.Controls.Add(this.quantityLabel);
            this.customerInfoGroupBox.Controls.Add(this.orderLabel);
            this.customerInfoGroupBox.Controls.Add(this.addressTextBox);
            this.customerInfoGroupBox.Controls.Add(this.addressLlabel);
            this.customerInfoGroupBox.Controls.Add(this.contactNoTextBox);
            this.customerInfoGroupBox.Controls.Add(this.contactNumberLabel);
            this.customerInfoGroupBox.Controls.Add(this.customerNametextBox);
            this.customerInfoGroupBox.Controls.Add(this.CustomerNamLlabel);
            this.customerInfoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.customerInfoGroupBox.Name = "customerInfoGroupBox";
            this.customerInfoGroupBox.Size = new System.Drawing.Size(384, 373);
            this.customerInfoGroupBox.TabIndex = 0;
            this.customerInfoGroupBox.TabStop = false;
            this.customerInfoGroupBox.Text = "Customer Information";
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular"});
            this.orderComboBox.Location = new System.Drawing.Point(179, 147);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(159, 21);
            this.orderComboBox.TabIndex = 3;
            this.orderComboBox.SelectedIndexChanged += new System.EventHandler(this.orderComboBox_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(264, 224);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(179, 175);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(160, 20);
            this.quantityTextBox.TabIndex = 4;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(13, 182);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(52, 13);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "Quantity :";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(13, 156);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(39, 13);
            this.orderLabel.TabIndex = 0;
            this.orderLabel.Text = "Order :";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(179, 99);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(160, 20);
            this.addressTextBox.TabIndex = 2;
            // 
            // addressLlabel
            // 
            this.addressLlabel.AutoSize = true;
            this.addressLlabel.Location = new System.Drawing.Point(13, 106);
            this.addressLlabel.Name = "addressLlabel";
            this.addressLlabel.Size = new System.Drawing.Size(51, 13);
            this.addressLlabel.TabIndex = 0;
            this.addressLlabel.Text = "Address :";
            // 
            // contactNoTextBox
            // 
            this.contactNoTextBox.Location = new System.Drawing.Point(179, 73);
            this.contactNoTextBox.Name = "contactNoTextBox";
            this.contactNoTextBox.Size = new System.Drawing.Size(160, 20);
            this.contactNoTextBox.TabIndex = 1;
            // 
            // contactNumberLabel
            // 
            this.contactNumberLabel.AutoSize = true;
            this.contactNumberLabel.Location = new System.Drawing.Point(13, 80);
            this.contactNumberLabel.Name = "contactNumberLabel";
            this.contactNumberLabel.Size = new System.Drawing.Size(64, 13);
            this.contactNumberLabel.TabIndex = 0;
            this.contactNumberLabel.Text = "Contact No:";
            // 
            // customerNametextBox
            // 
            this.customerNametextBox.Location = new System.Drawing.Point(179, 47);
            this.customerNametextBox.Name = "customerNametextBox";
            this.customerNametextBox.Size = new System.Drawing.Size(160, 20);
            this.customerNametextBox.TabIndex = 0;
            this.customerNametextBox.TextChanged += new System.EventHandler(this.customerNametextBox_TextChanged);
            // 
            // CustomerNamLlabel
            // 
            this.CustomerNamLlabel.AutoSize = true;
            this.CustomerNamLlabel.Location = new System.Drawing.Point(13, 54);
            this.CustomerNamLlabel.Name = "CustomerNamLlabel";
            this.CustomerNamLlabel.Size = new System.Drawing.Size(85, 13);
            this.CustomerNamLlabel.TabIndex = 0;
            this.CustomerNamLlabel.Text = "Customer Name:";
            // 
            // coffeShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 417);
            this.Controls.Add(this.customerInfoGroupBox);
            this.Controls.Add(this.richTextBox1);
            this.Name = "coffeShopForm";
            this.Text = "Coffe Shop";
            this.customerInfoGroupBox.ResumeLayout(false);
            this.customerInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox customerInfoGroupBox;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLlabel;
        private System.Windows.Forms.TextBox contactNoTextBox;
        private System.Windows.Forms.Label contactNumberLabel;
        private System.Windows.Forms.TextBox customerNametextBox;
        private System.Windows.Forms.Label CustomerNamLlabel;
    }
}

