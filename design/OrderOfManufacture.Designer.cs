namespace TimeCalc
{
	partial class OrderOfManufacture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderOfManufacture));
            this.backButton = new System.Windows.Forms.Button();
            this.productCountCombobox = new System.Windows.Forms.ComboBox();
            this.productCountLabel = new System.Windows.Forms.Label();
            this.existingOrderCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orderNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.existingOrderCount = new System.Windows.Forms.Label();
            this.deleteOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.BackColor = System.Drawing.Color.DarkRed;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(776, 771);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(132, 45);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Geri";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click_1);
            // 
            // productCountCombobox
            // 
            this.productCountCombobox.FormattingEnabled = true;
            this.productCountCombobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.productCountCombobox.Location = new System.Drawing.Point(165, 35);
            this.productCountCombobox.Name = "productCountCombobox";
            this.productCountCombobox.Size = new System.Drawing.Size(178, 21);
            this.productCountCombobox.TabIndex = 62;
            this.productCountCombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // productCountLabel
            // 
            this.productCountLabel.AutoSize = true;
            this.productCountLabel.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productCountLabel.ForeColor = System.Drawing.Color.White;
            this.productCountLabel.Location = new System.Drawing.Point(30, 31);
            this.productCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productCountLabel.Name = "productCountLabel";
            this.productCountLabel.Size = new System.Drawing.Size(116, 25);
            this.productCountLabel.TabIndex = 61;
            this.productCountLabel.Text = "Ürün Sayısı :";
            // 
            // existingOrderCombobox
            // 
            this.existingOrderCombobox.FormattingEnabled = true;
            this.existingOrderCombobox.Location = new System.Drawing.Point(714, 35);
            this.existingOrderCombobox.Name = "existingOrderCombobox";
            this.existingOrderCombobox.Size = new System.Drawing.Size(178, 21);
            this.existingOrderCombobox.TabIndex = 64;
            this.existingOrderCombobox.SelectedIndexChanged += new System.EventHandler(this.existingOrderCombobox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(362, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 25);
            this.label2.TabIndex = 65;
            this.label2.Text = "Var olan bir sıralamayı güncellemek için :";
            // 
            // orderNameTextBox
            // 
            this.orderNameTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderNameTextBox.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.orderNameTextBox.Location = new System.Drawing.Point(155, 782);
            this.orderNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderNameTextBox.Multiline = true;
            this.orderNameTextBox.Name = "orderNameTextBox";
            this.orderNameTextBox.Size = new System.Drawing.Size(213, 27);
            this.orderNameTextBox.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 782);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 68;
            this.label3.Text = "Sıralama adı :";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightGreen;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(390, 773);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(180, 45);
            this.saveButton.TabIndex = 69;
            this.saveButton.Text = "Sıralamayı Kaydet";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // existingOrderCount
            // 
            this.existingOrderCount.AutoSize = true;
            this.existingOrderCount.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.existingOrderCount.ForeColor = System.Drawing.Color.White;
            this.existingOrderCount.Location = new System.Drawing.Point(856, 35);
            this.existingOrderCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.existingOrderCount.Name = "existingOrderCount";
            this.existingOrderCount.Size = new System.Drawing.Size(17, 25);
            this.existingOrderCount.TabIndex = 70;
            this.existingOrderCount.Text = ".";
            // 
            // deleteOrder
            // 
            this.deleteOrder.BackColor = System.Drawing.Color.Brown;
            this.deleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteOrder.ForeColor = System.Drawing.Color.Black;
            this.deleteOrder.Location = new System.Drawing.Point(603, 773);
            this.deleteOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteOrder.Name = "deleteOrder";
            this.deleteOrder.Size = new System.Drawing.Size(132, 45);
            this.deleteOrder.TabIndex = 71;
            this.deleteOrder.Text = "Sıralamayı Sil";
            this.deleteOrder.UseVisualStyleBackColor = false;
            this.deleteOrder.Click += new System.EventHandler(this.deleteOrder_Click);
            // 
            // OrderOfManufacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(920, 828);
            this.Controls.Add(this.deleteOrder);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.existingOrderCombobox);
            this.Controls.Add(this.productCountCombobox);
            this.Controls.Add(this.productCountLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.existingOrderCount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "OrderOfManufacture";
            this.Text = "İmalat Sıralaması";
            this.Load += new System.EventHandler(this.OrderOfManufacture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox productCountCombobox;
        private System.Windows.Forms.Label productCountLabel;
        private System.Windows.Forms.ComboBox existingOrderCombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orderNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label existingOrderCount;
        private System.Windows.Forms.Button deleteOrder;
    }
}