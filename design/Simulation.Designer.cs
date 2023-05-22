namespace TimeCalc
{
	partial class Simulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulation));
            this.backButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ratioCombobox = new System.Windows.Forms.ComboBox();
            this.paneller = new System.Windows.Forms.GroupBox();
            this.panelValue2 = new System.Windows.Forms.GroupBox();
            this.panelCountLabel2 = new System.Windows.Forms.Label();
            this.panelValue1 = new System.Windows.Forms.GroupBox();
            this.panelCountLabel = new System.Windows.Forms.Label();
            this.panelType2 = new System.Windows.Forms.GroupBox();
            this.panelTypeLabel2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.panelType1 = new System.Windows.Forms.GroupBox();
            this.panelTypeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.secondLabel = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.resetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.existingOrderCombobox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.paneller.SuspendLayout();
            this.panelValue2.SuspendLayout();
            this.panelValue1.SuspendLayout();
            this.panelType2.SuspendLayout();
            this.panelType1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DarkRed;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(1671, 328);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(150, 50);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Geri";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Zaman Ölçeği";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ratioCombobox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(1333, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 80);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // ratioCombobox
            // 
            this.ratioCombobox.FormattingEnabled = true;
            this.ratioCombobox.Items.AddRange(new object[] {
            "1 dk = 1 sn",
            "10 dk = 1 sn",
            "30 dk = 1 sn",
            "60 dk = 1 sn",
            "120 dk = 1 sn",
            "180 dk = 1 sn",
            "240 dk = 1 sn",
            "300 dk = 1 sn"});
            this.ratioCombobox.Location = new System.Drawing.Point(18, 41);
            this.ratioCombobox.Name = "ratioCombobox";
            this.ratioCombobox.Size = new System.Drawing.Size(111, 21);
            this.ratioCombobox.TabIndex = 63;
            this.ratioCombobox.SelectedIndexChanged += new System.EventHandler(this.ratioCombobox_SelectedIndexChanged);
            // 
            // paneller
            // 
            this.paneller.Controls.Add(this.panelValue2);
            this.paneller.Controls.Add(this.panelValue1);
            this.paneller.Controls.Add(this.panelType2);
            this.paneller.Location = new System.Drawing.Point(1308, 417);
            this.paneller.Name = "paneller";
            this.paneller.Size = new System.Drawing.Size(539, 445);
            this.paneller.TabIndex = 18;
            this.paneller.TabStop = false;
            // 
            // panelValue2
            // 
            this.panelValue2.Controls.Add(this.panelCountLabel2);
            this.panelValue2.Location = new System.Drawing.Point(439, 0);
            this.panelValue2.Name = "panelValue2";
            this.panelValue2.Size = new System.Drawing.Size(100, 445);
            this.panelValue2.TabIndex = 21;
            this.panelValue2.TabStop = false;
            // 
            // panelCountLabel2
            // 
            this.panelCountLabel2.AutoSize = true;
            this.panelCountLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelCountLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panelCountLabel2.Location = new System.Drawing.Point(22, 16);
            this.panelCountLabel2.Name = "panelCountLabel2";
            this.panelCountLabel2.Size = new System.Drawing.Size(52, 20);
            this.panelCountLabel2.TabIndex = 12;
            this.panelCountLabel2.Text = "ADET";
            // 
            // panelValue1
            // 
            this.panelValue1.Controls.Add(this.panelCountLabel);
            this.panelValue1.Location = new System.Drawing.Point(138, 0);
            this.panelValue1.Name = "panelValue1";
            this.panelValue1.Size = new System.Drawing.Size(100, 445);
            this.panelValue1.TabIndex = 20;
            this.panelValue1.TabStop = false;
            // 
            // panelCountLabel
            // 
            this.panelCountLabel.AutoSize = true;
            this.panelCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelCountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.panelCountLabel.Location = new System.Drawing.Point(22, 16);
            this.panelCountLabel.Name = "panelCountLabel";
            this.panelCountLabel.Size = new System.Drawing.Size(52, 20);
            this.panelCountLabel.TabIndex = 10;
            this.panelCountLabel.Text = "ADET";
            // 
            // panelType2
            // 
            this.panelType2.Controls.Add(this.panelTypeLabel2);
            this.panelType2.Location = new System.Drawing.Point(301, 0);
            this.panelType2.Name = "panelType2";
            this.panelType2.Size = new System.Drawing.Size(139, 445);
            this.panelType2.TabIndex = 21;
            this.panelType2.TabStop = false;
            // 
            // panelTypeLabel2
            // 
            this.panelTypeLabel2.AutoSize = true;
            this.panelTypeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelTypeLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panelTypeLabel2.Location = new System.Drawing.Point(3, 16);
            this.panelTypeLabel2.Name = "panelTypeLabel2";
            this.panelTypeLabel2.Size = new System.Drawing.Size(94, 20);
            this.panelTypeLabel2.TabIndex = 11;
            this.panelTypeLabel2.Text = "PANEL TİPİ";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.ForestGreen;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startButton.ForeColor = System.Drawing.Color.Black;
            this.startButton.Location = new System.Drawing.Point(1321, 328);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(150, 50);
            this.startButton.TabIndex = 19;
            this.startButton.Text = "Başlat";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelType1
            // 
            this.panelType1.Controls.Add(this.panelTypeLabel);
            this.panelType1.Location = new System.Drawing.Point(1308, 417);
            this.panelType1.Name = "panelType1";
            this.panelType1.Size = new System.Drawing.Size(139, 445);
            this.panelType1.TabIndex = 19;
            this.panelType1.TabStop = false;
            // 
            // panelTypeLabel
            // 
            this.panelTypeLabel.AutoSize = true;
            this.panelTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelTypeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.panelTypeLabel.Location = new System.Drawing.Point(3, 16);
            this.panelTypeLabel.Name = "panelTypeLabel";
            this.panelTypeLabel.Size = new System.Drawing.Size(94, 20);
            this.panelTypeLabel.TabIndex = 9;
            this.panelTypeLabel.Text = "PANEL TİPİ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(1308, 456);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 2);
            this.panel1.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.secondLabel);
            this.groupBox2.Controls.Add(this.clock);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(1610, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 80);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secondLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.secondLabel.Location = new System.Drawing.Point(173, 29);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(26, 20);
            this.secondLabel.TabIndex = 10;
            this.secondLabel.Text = "sn";
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clock.ForeColor = System.Drawing.SystemColors.Control;
            this.clock.Location = new System.Drawing.Point(125, 31);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(18, 20);
            this.clock.TabIndex = 9;
            this.clock.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(7, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Operation Time: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Orange;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.Location = new System.Drawing.Point(1495, 328);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(150, 50);
            this.resetButton.TabIndex = 51;
            this.resetButton.Text = "Sıfırla";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1309, 239);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 35);
            this.label1.TabIndex = 67;
            this.label1.Text = "Üretim sırasını seçmek için :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // existingOrderCombobox
            // 
            this.existingOrderCombobox.FormattingEnabled = true;
            this.existingOrderCombobox.Items.AddRange(new object[] {
            "abc sıralaması",
            "def sıralaması"});
            this.existingOrderCombobox.Location = new System.Drawing.Point(1650, 248);
            this.existingOrderCombobox.Name = "existingOrderCombobox";
            this.existingOrderCombobox.Size = new System.Drawing.Size(178, 21);
            this.existingOrderCombobox.TabIndex = 66;
            this.existingOrderCombobox.SelectedIndexChanged += new System.EventHandler(this.existingOrderCombobox_SelectedIndexChanged);
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1894, 952);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.existingOrderCombobox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelType1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.paneller);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Simulation";
            this.Text = "Simülasyon";
            this.Load += new System.EventHandler(this.Grafikler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.paneller.ResumeLayout(false);
            this.panelValue2.ResumeLayout(false);
            this.panelValue2.PerformLayout();
            this.panelValue1.ResumeLayout(false);
            this.panelValue1.PerformLayout();
            this.panelType2.ResumeLayout(false);
            this.panelType2.PerformLayout();
            this.panelType1.ResumeLayout(false);
            this.panelType1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox paneller;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox panelValue2;
        private System.Windows.Forms.GroupBox panelValue1;
        private System.Windows.Forms.GroupBox panelType1;
        private System.Windows.Forms.GroupBox panelType2;
        private System.Windows.Forms.Label panelCountLabel2;
        private System.Windows.Forms.Label panelCountLabel;
        private System.Windows.Forms.Label panelTypeLabel2;
        private System.Windows.Forms.Label panelTypeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ComboBox ratioCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox existingOrderCombobox;
    }
}