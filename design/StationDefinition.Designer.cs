namespace TimeCalc
{
	partial class DurakTanımlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DurakTanımlama));
            this.backButton = new System.Windows.Forms.Button();
            this.stationName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.stationNameLabel = new System.Windows.Forms.Label();
            this.stationTimeLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.mandatoryLabel = new System.Windows.Forms.Label();
            this.mandatoryLabel2 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.stationDefinitionLabel = new System.Windows.Forms.Label();
            this.stationTime = new System.Windows.Forms.TextBox();
            this.stationManCount = new System.Windows.Forms.TextBox();
            this.stationManCountLabel = new System.Windows.Forms.Label();
            this.stations = new System.Windows.Forms.DataGridView();
            this.panelDefinitionLabel = new System.Windows.Forms.Label();
            this.totalPanelCountLabel = new System.Windows.Forms.Label();
            this.stationCountLabel = new System.Windows.Forms.Label();
            this.panelCount = new System.Windows.Forms.TextBox();
            this.deleteStationButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.stationIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stations)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DarkRed;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(1196, 511);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(150, 46);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Geri";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // stationName
            // 
            this.stationName.Location = new System.Drawing.Point(382, 303);
            this.stationName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stationName.Name = "stationName";
            this.stationName.Size = new System.Drawing.Size(278, 29);
            this.stationName.TabIndex = 6;
            // 
            // stationNameLabel
            // 
            this.stationNameLabel.AutoSize = true;
            this.stationNameLabel.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stationNameLabel.ForeColor = System.Drawing.Color.White;
            this.stationNameLabel.Location = new System.Drawing.Point(217, 301);
            this.stationNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stationNameLabel.Name = "stationNameLabel";
            this.stationNameLabel.Size = new System.Drawing.Size(131, 31);
            this.stationNameLabel.TabIndex = 22;
            this.stationNameLabel.Text = "Durak Adı :";
            // 
            // stationTimeLabel
            // 
            this.stationTimeLabel.AutoSize = true;
            this.stationTimeLabel.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stationTimeLabel.ForeColor = System.Drawing.Color.White;
            this.stationTimeLabel.Location = new System.Drawing.Point(153, 372);
            this.stationTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stationTimeLabel.Name = "stationTimeLabel";
            this.stationTimeLabel.Size = new System.Drawing.Size(209, 31);
            this.stationTimeLabel.TabIndex = 29;
            this.stationTimeLabel.Text = "Durak Süresi (dk) : ";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightGreen;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(531, 505);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 50);
            this.saveButton.TabIndex = 30;
            this.saveButton.Text = "Kaydet";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Orange;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.Location = new System.Drawing.Point(159, 505);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(150, 50);
            this.resetButton.TabIndex = 31;
            this.resetButton.Text = "Sıfırla";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // mandatoryLabel
            // 
            this.mandatoryLabel.AutoSize = true;
            this.mandatoryLabel.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mandatoryLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.mandatoryLabel.Location = new System.Drawing.Point(663, 297);
            this.mandatoryLabel.Name = "mandatoryLabel";
            this.mandatoryLabel.Size = new System.Drawing.Size(18, 25);
            this.mandatoryLabel.TabIndex = 56;
            this.mandatoryLabel.Text = "*";
            // 
            // mandatoryLabel2
            // 
            this.mandatoryLabel2.AutoSize = true;
            this.mandatoryLabel2.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mandatoryLabel2.ForeColor = System.Drawing.Color.OrangeRed;
            this.mandatoryLabel2.Location = new System.Drawing.Point(663, 370);
            this.mandatoryLabel2.Name = "mandatoryLabel2";
            this.mandatoryLabel2.Size = new System.Drawing.Size(18, 25);
            this.mandatoryLabel2.TabIndex = 57;
            this.mandatoryLabel2.Text = "*";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Sylfaen", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.label35.Location = new System.Drawing.Point(0, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(0, 3);
            this.label35.TabIndex = 84;
            // 
            // stationDefinitionLabel
            // 
            this.stationDefinitionLabel.AutoSize = true;
            this.stationDefinitionLabel.Font = new System.Drawing.Font("Sylfaen", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stationDefinitionLabel.ForeColor = System.Drawing.Color.White;
            this.stationDefinitionLabel.Location = new System.Drawing.Point(271, 224);
            this.stationDefinitionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stationDefinitionLabel.Name = "stationDefinitionLabel";
            this.stationDefinitionLabel.Size = new System.Drawing.Size(306, 39);
            this.stationDefinitionLabel.TabIndex = 85;
            this.stationDefinitionLabel.Text = "İşlem (Durak) Bilgileri  ";
            // 
            // stationTime
            // 
            this.stationTime.Location = new System.Drawing.Point(382, 372);
            this.stationTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stationTime.Name = "stationTime";
            this.stationTime.Size = new System.Drawing.Size(278, 29);
            this.stationTime.TabIndex = 86;
            // 
            // stationManCount
            // 
            this.stationManCount.Location = new System.Drawing.Point(382, 434);
            this.stationManCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stationManCount.Name = "stationManCount";
            this.stationManCount.Size = new System.Drawing.Size(278, 29);
            this.stationManCount.TabIndex = 88;
            // 
            // stationManCountLabel
            // 
            this.stationManCountLabel.AutoSize = true;
            this.stationManCountLabel.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stationManCountLabel.ForeColor = System.Drawing.Color.White;
            this.stationManCountLabel.Location = new System.Drawing.Point(199, 432);
            this.stationManCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stationManCountLabel.Name = "stationManCountLabel";
            this.stationManCountLabel.Size = new System.Drawing.Size(149, 31);
            this.stationManCountLabel.TabIndex = 87;
            this.stationManCountLabel.Text = "Adam Sayısı :";
            // 
            // stations
            // 
            this.stations.AllowUserToAddRows = false;
            this.stations.AllowUserToDeleteRows = false;
            this.stations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stations.Location = new System.Drawing.Point(719, 280);
            this.stations.Name = "stations";
            this.stations.ReadOnly = true;
            this.stations.Size = new System.Drawing.Size(627, 206);
            this.stations.TabIndex = 90;
            this.stations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stations_CellContentClick);
            // 
            // panelDefinitionLabel
            // 
            this.panelDefinitionLabel.AutoSize = true;
            this.panelDefinitionLabel.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelDefinitionLabel.ForeColor = System.Drawing.Color.White;
            this.panelDefinitionLabel.Location = new System.Drawing.Point(774, 231);
            this.panelDefinitionLabel.Name = "panelDefinitionLabel";
            this.panelDefinitionLabel.Size = new System.Drawing.Size(488, 31);
            this.panelDefinitionLabel.TabIndex = 89;
            this.panelDefinitionLabel.Text = "Daha önceden tanımlanmış duraklar aşağıdadır.";
            // 
            // totalPanelCountLabel
            // 
            this.totalPanelCountLabel.AutoSize = true;
            this.totalPanelCountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(144)))), ((int)(((byte)(1)))));
            this.totalPanelCountLabel.Font = new System.Drawing.Font("Sylfaen", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalPanelCountLabel.Location = new System.Drawing.Point(970, 523);
            this.totalPanelCountLabel.Name = "totalPanelCountLabel";
            this.totalPanelCountLabel.Size = new System.Drawing.Size(121, 22);
            this.totalPanelCountLabel.TabIndex = 94;
            this.totalPanelCountLabel.Text = "Toplam Durak:";
            // 
            // stationCountLabel
            // 
            this.stationCountLabel.AutoSize = true;
            this.stationCountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(144)))), ((int)(((byte)(1)))));
            this.stationCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stationCountLabel.Location = new System.Drawing.Point(1108, 524);
            this.stationCountLabel.Name = "stationCountLabel";
            this.stationCountLabel.Size = new System.Drawing.Size(14, 20);
            this.stationCountLabel.TabIndex = 93;
            this.stationCountLabel.Text = ":";
            // 
            // panelCount
            // 
            this.panelCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(144)))), ((int)(((byte)(1)))));
            this.panelCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelCount.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panelCount.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelCount.Location = new System.Drawing.Point(970, 511);
            this.panelCount.Multiline = true;
            this.panelCount.Name = "panelCount";
            this.panelCount.ReadOnly = true;
            this.panelCount.Size = new System.Drawing.Size(174, 45);
            this.panelCount.TabIndex = 92;
            // 
            // deleteStationButton
            // 
            this.deleteStationButton.BackColor = System.Drawing.Color.Brown;
            this.deleteStationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteStationButton.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteStationButton.Location = new System.Drawing.Point(746, 510);
            this.deleteStationButton.Name = "deleteStationButton";
            this.deleteStationButton.Size = new System.Drawing.Size(150, 45);
            this.deleteStationButton.TabIndex = 91;
            this.deleteStationButton.Text = "Seçili Durağı Sil";
            this.deleteStationButton.UseVisualStyleBackColor = false;
            this.deleteStationButton.Click += new System.EventHandler(this.deleteStationButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateButton.ForeColor = System.Drawing.Color.Black;
            this.updateButton.Location = new System.Drawing.Point(347, 505);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(150, 50);
            this.updateButton.TabIndex = 95;
            this.updateButton.Text = "Güncelle";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // stationIdLabel
            // 
            this.stationIdLabel.AutoSize = true;
            this.stationIdLabel.Location = new System.Drawing.Point(923, 201);
            this.stationIdLabel.Name = "stationIdLabel";
            this.stationIdLabel.Size = new System.Drawing.Size(50, 22);
            this.stationIdLabel.TabIndex = 96;
            this.stationIdLabel.Text = "label1";
            this.stationIdLabel.Visible = false;
            // 
            // DurakTanımlama
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1620, 876);
            this.ControlBox = false;
            this.Controls.Add(this.stationIdLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.totalPanelCountLabel);
            this.Controls.Add(this.stationCountLabel);
            this.Controls.Add(this.panelCount);
            this.Controls.Add(this.deleteStationButton);
            this.Controls.Add(this.stations);
            this.Controls.Add(this.panelDefinitionLabel);
            this.Controls.Add(this.stationManCount);
            this.Controls.Add(this.stationManCountLabel);
            this.Controls.Add(this.stationTime);
            this.Controls.Add(this.stationDefinitionLabel);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.mandatoryLabel2);
            this.Controls.Add(this.mandatoryLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.stationTimeLabel);
            this.Controls.Add(this.stationNameLabel);
            this.Controls.Add(this.stationName);
            this.Controls.Add(this.backButton);
            this.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "DurakTanımlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DurakTanımlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.TextBox stationName;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label stationNameLabel;
		private System.Windows.Forms.Label stationTimeLabel;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.Label mandatoryLabel;
		private System.Windows.Forms.Label mandatoryLabel2;
		private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label stationDefinitionLabel;
        private System.Windows.Forms.TextBox stationTime;
        private System.Windows.Forms.TextBox stationManCount;
        private System.Windows.Forms.Label stationManCountLabel;
        private System.Windows.Forms.DataGridView stations;
        private System.Windows.Forms.Label panelDefinitionLabel;
        private System.Windows.Forms.Label totalPanelCountLabel;
        private System.Windows.Forms.Label stationCountLabel;
        private System.Windows.Forms.TextBox panelCount;
        private System.Windows.Forms.Button deleteStationButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label stationIdLabel;
    }
}