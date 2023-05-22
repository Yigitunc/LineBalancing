namespace TimeCalc
{
	partial class ProductDefinition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDefinition));
            this.backButton = new System.Windows.Forms.Button();
            this.panelDefinitionLabel = new System.Windows.Forms.Label();
            this.panels = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.panelRouteCountLabel = new System.Windows.Forms.Label();
            this.panelNameLabel = new System.Windows.Forms.Label();
            this.panelSpecsLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.panelRouteCountCombobox = new System.Windows.Forms.ComboBox();
            this.panelTimeLabel = new System.Windows.Forms.Label();
            this.panelManCountLabel = new System.Windows.Forms.Label();
            this.panelArrangementLabel = new System.Windows.Forms.Label();
            this.panelRouteValueLabel = new System.Windows.Forms.Label();
            this.dkLabel = new System.Windows.Forms.Label();
            this.deletePanelButton = new System.Windows.Forms.Button();
            this.totalPanelCountLabel = new System.Windows.Forms.Label();
            this.panelCountLabel = new System.Windows.Forms.Label();
            this.panelCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panels)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DarkRed;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(1469, 858);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(132, 45);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Geri";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // panelDefinitionLabel
            // 
            this.panelDefinitionLabel.AutoSize = true;
            this.panelDefinitionLabel.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelDefinitionLabel.ForeColor = System.Drawing.Color.White;
            this.panelDefinitionLabel.Location = new System.Drawing.Point(886, 56);
            this.panelDefinitionLabel.Name = "panelDefinitionLabel";
            this.panelDefinitionLabel.Size = new System.Drawing.Size(483, 31);
            this.panelDefinitionLabel.TabIndex = 7;
            this.panelDefinitionLabel.Text = "Daha önceden tanımlanmış paneller aşağıdadır.";
            // 
            // panels
            // 
            this.panels.AllowUserToAddRows = false;
            this.panels.AllowUserToDeleteRows = false;
            this.panels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panels.Location = new System.Drawing.Point(639, 109);
            this.panels.Name = "panels";
            this.panels.ReadOnly = true;
            this.panels.Size = new System.Drawing.Size(962, 742);
            this.panels.TabIndex = 8;
            this.panels.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.panels_CellContentClick);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.ForestGreen;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(394, 857);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(132, 45);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Kaydet";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelRouteCountLabel
            // 
            this.panelRouteCountLabel.AutoSize = true;
            this.panelRouteCountLabel.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelRouteCountLabel.ForeColor = System.Drawing.Color.White;
            this.panelRouteCountLabel.Location = new System.Drawing.Point(52, 136);
            this.panelRouteCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panelRouteCountLabel.Name = "panelRouteCountLabel";
            this.panelRouteCountLabel.Size = new System.Drawing.Size(118, 25);
            this.panelRouteCountLabel.TabIndex = 33;
            this.panelRouteCountLabel.Text = "Adım Sayısı: ";
            // 
            // panelNameLabel
            // 
            this.panelNameLabel.AutoSize = true;
            this.panelNameLabel.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelNameLabel.ForeColor = System.Drawing.Color.White;
            this.panelNameLabel.Location = new System.Drawing.Point(65, 85);
            this.panelNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panelNameLabel.Name = "panelNameLabel";
            this.panelNameLabel.Size = new System.Drawing.Size(106, 25);
            this.panelNameLabel.TabIndex = 32;
            this.panelNameLabel.Text = "Panel Adı : ";
            // 
            // panelSpecsLabel
            // 
            this.panelSpecsLabel.AutoSize = true;
            this.panelSpecsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelSpecsLabel.ForeColor = System.Drawing.Color.White;
            this.panelSpecsLabel.Location = new System.Drawing.Point(244, 33);
            this.panelSpecsLabel.Name = "panelSpecsLabel";
            this.panelSpecsLabel.Size = new System.Drawing.Size(306, 33);
            this.panelSpecsLabel.TabIndex = 44;
            this.panelSpecsLabel.Text = "Panel (Ürün) Bilgileri";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Orange;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.Location = new System.Drawing.Point(159, 857);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(132, 45);
            this.resetButton.TabIndex = 50;
            this.resetButton.Text = "Sıfırla";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.productNameTextBox.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productNameTextBox.Location = new System.Drawing.Point(187, 86);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productNameTextBox.Multiline = true;
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(278, 27);
            this.productNameTextBox.TabIndex = 55;
            // 
            // panelRouteCountCombobox
            // 
            this.panelRouteCountCombobox.FormattingEnabled = true;
            this.panelRouteCountCombobox.Items.AddRange(new object[] {
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
            "25"});
            this.panelRouteCountCombobox.Location = new System.Drawing.Point(187, 142);
            this.panelRouteCountCombobox.Name = "panelRouteCountCombobox";
            this.panelRouteCountCombobox.Size = new System.Drawing.Size(178, 21);
            this.panelRouteCountCombobox.TabIndex = 60;
            this.panelRouteCountCombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panelTimeLabel
            // 
            this.panelTimeLabel.AutoSize = true;
            this.panelTimeLabel.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelTimeLabel.ForeColor = System.Drawing.Color.White;
            this.panelTimeLabel.Location = new System.Drawing.Point(369, 184);
            this.panelTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panelTimeLabel.Name = "panelTimeLabel";
            this.panelTimeLabel.Size = new System.Drawing.Size(48, 25);
            this.panelTimeLabel.TabIndex = 64;
            this.panelTimeLabel.Text = "Süre";
            // 
            // panelManCountLabel
            // 
            this.panelManCountLabel.AutoSize = true;
            this.panelManCountLabel.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelManCountLabel.ForeColor = System.Drawing.Color.White;
            this.panelManCountLabel.Location = new System.Drawing.Point(471, 184);
            this.panelManCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panelManCountLabel.Name = "panelManCountLabel";
            this.panelManCountLabel.Size = new System.Drawing.Size(110, 25);
            this.panelManCountLabel.TabIndex = 66;
            this.panelManCountLabel.Text = "Adam Sayısı";
            // 
            // panelArrangementLabel
            // 
            this.panelArrangementLabel.AutoSize = true;
            this.panelArrangementLabel.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelArrangementLabel.ForeColor = System.Drawing.Color.White;
            this.panelArrangementLabel.Location = new System.Drawing.Point(52, 184);
            this.panelArrangementLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panelArrangementLabel.Name = "panelArrangementLabel";
            this.panelArrangementLabel.Size = new System.Drawing.Size(80, 25);
            this.panelArrangementLabel.TabIndex = 73;
            this.panelArrangementLabel.Text = "Sıralama";
            // 
            // panelRouteValueLabel
            // 
            this.panelRouteValueLabel.AutoSize = true;
            this.panelRouteValueLabel.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelRouteValueLabel.ForeColor = System.Drawing.Color.White;
            this.panelRouteValueLabel.Location = new System.Drawing.Point(190, 184);
            this.panelRouteValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panelRouteValueLabel.Name = "panelRouteValueLabel";
            this.panelRouteValueLabel.Size = new System.Drawing.Size(136, 25);
            this.panelRouteValueLabel.TabIndex = 74;
            this.panelRouteValueLabel.Text = "İzleyeceği Rota";
            // 
            // dkLabel
            // 
            this.dkLabel.AutoSize = true;
            this.dkLabel.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dkLabel.ForeColor = System.Drawing.Color.White;
            this.dkLabel.Location = new System.Drawing.Point(410, 184);
            this.dkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dkLabel.Name = "dkLabel";
            this.dkLabel.Size = new System.Drawing.Size(44, 25);
            this.dkLabel.TabIndex = 79;
            this.dkLabel.Text = "(dk)";
            // 
            // deletePanelButton
            // 
            this.deletePanelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deletePanelButton.BackColor = System.Drawing.Color.Brown;
            this.deletePanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deletePanelButton.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePanelButton.Location = new System.Drawing.Point(639, 857);
            this.deletePanelButton.Name = "deletePanelButton";
            this.deletePanelButton.Size = new System.Drawing.Size(150, 45);
            this.deletePanelButton.TabIndex = 81;
            this.deletePanelButton.Text = "Seçili Paneli Sil";
            this.deletePanelButton.UseVisualStyleBackColor = false;
            this.deletePanelButton.Click += new System.EventHandler(this.deletePanelButton_Click);
            // 
            // totalPanelCountLabel
            // 
            this.totalPanelCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.totalPanelCountLabel.AutoSize = true;
            this.totalPanelCountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(144)))), ((int)(((byte)(1)))));
            this.totalPanelCountLabel.Font = new System.Drawing.Font("Sylfaen", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalPanelCountLabel.Location = new System.Drawing.Point(1042, 870);
            this.totalPanelCountLabel.Name = "totalPanelCountLabel";
            this.totalPanelCountLabel.Size = new System.Drawing.Size(120, 22);
            this.totalPanelCountLabel.TabIndex = 84;
            this.totalPanelCountLabel.Text = "Toplam Panel :";
            // 
            // panelCountLabel
            // 
            this.panelCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelCountLabel.AutoSize = true;
            this.panelCountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(144)))), ((int)(((byte)(1)))));
            this.panelCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelCountLabel.Location = new System.Drawing.Point(1180, 871);
            this.panelCountLabel.Name = "panelCountLabel";
            this.panelCountLabel.Size = new System.Drawing.Size(14, 20);
            this.panelCountLabel.TabIndex = 83;
            this.panelCountLabel.Text = ":";
            // 
            // panelCount
            // 
            this.panelCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(144)))), ((int)(((byte)(1)))));
            this.panelCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelCount.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panelCount.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelCount.Location = new System.Drawing.Point(1042, 858);
            this.panelCount.Multiline = true;
            this.panelCount.Name = "panelCount";
            this.panelCount.ReadOnly = true;
            this.panelCount.Size = new System.Drawing.Size(174, 45);
            this.panelCount.TabIndex = 82;
            // 
            // ProductDefinition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1632, 942);
            this.Controls.Add(this.totalPanelCountLabel);
            this.Controls.Add(this.panelCountLabel);
            this.Controls.Add(this.panelCount);
            this.Controls.Add(this.deletePanelButton);
            this.Controls.Add(this.dkLabel);
            this.Controls.Add(this.panelRouteValueLabel);
            this.Controls.Add(this.panelArrangementLabel);
            this.Controls.Add(this.panelManCountLabel);
            this.Controls.Add(this.panelTimeLabel);
            this.Controls.Add(this.panelRouteCountCombobox);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.panelSpecsLabel);
            this.Controls.Add(this.panelRouteCountLabel);
            this.Controls.Add(this.panelNameLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.panels);
            this.Controls.Add(this.panelDefinitionLabel);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductDefinition";
            this.Text = "Panel Tanımlama";
            this.Load += new System.EventHandler(this.ProductDefinition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.Label panelDefinitionLabel;
		private System.Windows.Forms.DataGridView panels;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Label panelRouteCountLabel;
		private System.Windows.Forms.Label panelNameLabel;
		private System.Windows.Forms.Label panelSpecsLabel;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.ComboBox panelRouteCountCombobox;
        private System.Windows.Forms.Label panelTimeLabel;
        private System.Windows.Forms.Label panelManCountLabel;
        private System.Windows.Forms.Label panelArrangementLabel;
        private System.Windows.Forms.Label panelRouteValueLabel;
        private System.Windows.Forms.Label dkLabel;
        private System.Windows.Forms.Button deletePanelButton;
        private System.Windows.Forms.Label totalPanelCountLabel;
        private System.Windows.Forms.Label panelCountLabel;
        private System.Windows.Forms.TextBox panelCount;
    }
}