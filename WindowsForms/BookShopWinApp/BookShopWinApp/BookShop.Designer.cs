namespace BookShopWinApp
{
    partial class BookShop
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
            this.displayTextBox = new System.Windows.Forms.RichTextBox();
            this.CustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomerNamelabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.ContactNolabel = new System.Windows.Forms.Label();
            this.contactNoTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.Orderlabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayTextBox
            // 
            this.displayTextBox.BackColor = System.Drawing.Color.DimGray;
            this.displayTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.displayTextBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.displayTextBox.Location = new System.Drawing.Point(351, 0);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.displayTextBox.Size = new System.Drawing.Size(330, 454);
            this.displayTextBox.TabIndex = 1;
            this.displayTextBox.Text = "";
            // 
            // CustomerGroupBox
            // 
            this.CustomerGroupBox.BackColor = System.Drawing.Color.Gainsboro;
            this.CustomerGroupBox.Controls.Add(this.orderComboBox);
            this.CustomerGroupBox.Controls.Add(this.saveButton);
            this.CustomerGroupBox.Controls.Add(this.quantityTextBox);
            this.CustomerGroupBox.Controls.Add(this.quantityLabel);
            this.CustomerGroupBox.Controls.Add(this.Orderlabel);
            this.CustomerGroupBox.Controls.Add(this.addressTextBox);
            this.CustomerGroupBox.Controls.Add(this.AddressLabel);
            this.CustomerGroupBox.Controls.Add(this.contactNoTextBox);
            this.CustomerGroupBox.Controls.Add(this.ContactNolabel);
            this.CustomerGroupBox.Controls.Add(this.customerNameTextBox);
            this.CustomerGroupBox.Controls.Add(this.CustomerNamelabel);
            this.CustomerGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.CustomerGroupBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerGroupBox.Location = new System.Drawing.Point(0, 0);
            this.CustomerGroupBox.Name = "CustomerGroupBox";
            this.CustomerGroupBox.Size = new System.Drawing.Size(345, 454);
            this.CustomerGroupBox.TabIndex = 0;
            this.CustomerGroupBox.TabStop = false;
            this.CustomerGroupBox.Text = "Customer Information";
            // 
            // CustomerNamelabel
            // 
            this.CustomerNamelabel.AutoSize = true;
            this.CustomerNamelabel.Location = new System.Drawing.Point(29, 86);
            this.CustomerNamelabel.Name = "CustomerNamelabel";
            this.CustomerNamelabel.Size = new System.Drawing.Size(109, 16);
            this.CustomerNamelabel.TabIndex = 0;
            this.CustomerNamelabel.Text = "Customer Name";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(154, 79);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(138, 27);
            this.customerNameTextBox.TabIndex = 0;
            // 
            // ContactNolabel
            // 
            this.ContactNolabel.AutoSize = true;
            this.ContactNolabel.Location = new System.Drawing.Point(29, 112);
            this.ContactNolabel.Name = "ContactNolabel";
            this.ContactNolabel.Size = new System.Drawing.Size(81, 16);
            this.ContactNolabel.TabIndex = 0;
            this.ContactNolabel.Text = "Contact NO";
            // 
            // contactNoTextBox
            // 
            this.contactNoTextBox.Location = new System.Drawing.Point(154, 105);
            this.contactNoTextBox.Name = "contactNoTextBox";
            this.contactNoTextBox.Size = new System.Drawing.Size(138, 27);
            this.contactNoTextBox.TabIndex = 1;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(29, 138);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(59, 16);
            this.AddressLabel.TabIndex = 0;
            this.AddressLabel.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(154, 131);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(138, 27);
            this.addressTextBox.TabIndex = 2;
            // 
            // Orderlabel
            // 
            this.Orderlabel.AutoSize = true;
            this.Orderlabel.Location = new System.Drawing.Point(29, 198);
            this.Orderlabel.Name = "Orderlabel";
            this.Orderlabel.Size = new System.Drawing.Size(43, 16);
            this.Orderlabel.TabIndex = 0;
            this.Orderlabel.Text = "Order";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(29, 224);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(62, 16);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(154, 217);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(138, 27);
            this.quantityTextBox.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LimeGreen;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(217, 274);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 32);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Items.AddRange(new object[] {
            "Bangla",
            "English",
            "Math",
            "Art"});
            this.orderComboBox.Location = new System.Drawing.Point(154, 190);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(138, 24);
            this.orderComboBox.TabIndex = 3;
            // 
            // BookShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 454);
            this.Controls.Add(this.CustomerGroupBox);
            this.Controls.Add(this.displayTextBox);
            this.Name = "BookShop";
            this.Text = "Book Shop";
            this.Load += new System.EventHandler(this.BookShop_Load);
            this.CustomerGroupBox.ResumeLayout(false);
            this.CustomerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox displayTextBox;
        private System.Windows.Forms.GroupBox CustomerGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label Orderlabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox contactNoTextBox;
        private System.Windows.Forms.Label ContactNolabel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label CustomerNamelabel;
        private System.Windows.Forms.ComboBox orderComboBox;
    }
}

