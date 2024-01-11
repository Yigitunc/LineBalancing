namespace TimeCalc
{
	partial class MainPage
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aLIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laptoplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grafikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLIMToolStripMenuItem,
            this.satımToolStripMenuItem,
            this.laptoplarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.grafikToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(144, 861);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aLIMToolStripMenuItem
            // 
            this.aLIMToolStripMenuItem.AutoSize = false;
            this.aLIMToolStripMenuItem.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aLIMToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aLIMToolStripMenuItem.Name = "aLIMToolStripMenuItem";
            this.aLIMToolStripMenuItem.Size = new System.Drawing.Size(135, 90);
            this.aLIMToolStripMenuItem.Text = "Durak Tanımlama";
            this.aLIMToolStripMenuItem.Click += new System.EventHandler(this.aLIMToolStripMenuItem_Click);
            // 
            // satımToolStripMenuItem
            // 
            this.satımToolStripMenuItem.AutoSize = false;
            this.satımToolStripMenuItem.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satımToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.satımToolStripMenuItem.Name = "satımToolStripMenuItem";
            this.satımToolStripMenuItem.Size = new System.Drawing.Size(135, 90);
            this.satımToolStripMenuItem.Text = "Panel Tanımlama";
            this.satımToolStripMenuItem.Click += new System.EventHandler(this.satımToolStripMenuItem_Click);
            // 
            // laptoplarToolStripMenuItem
            // 
            this.laptoplarToolStripMenuItem.AutoSize = false;
            this.laptoplarToolStripMenuItem.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.laptoplarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.laptoplarToolStripMenuItem.Name = "laptoplarToolStripMenuItem";
            this.laptoplarToolStripMenuItem.Size = new System.Drawing.Size(135, 90);
            this.laptoplarToolStripMenuItem.Text = "İmalat Sıralaması";
            this.laptoplarToolStripMenuItem.Click += new System.EventHandler(this.laptoplarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 90);
            this.toolStripMenuItem1.Text = "Simülasyon Ekranı";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // grafikToolStripMenuItem
            // 
            this.grafikToolStripMenuItem.AutoSize = false;
            this.grafikToolStripMenuItem.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grafikToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.grafikToolStripMenuItem.Name = "grafikToolStripMenuItem";
            this.grafikToolStripMenuItem.Size = new System.Drawing.Size(135, 90);
            this.grafikToolStripMenuItem.Text = "Simülasyon Sonuçları";
            this.grafikToolStripMenuItem.Click += new System.EventHandler(this.grafikToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(1466, 988);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(238, 115);
            this.button4.TabIndex = 4;
            this.button4.Text = "Çıkış";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1640, 894);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 55);
            this.button1.TabIndex = 46;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1684, 861);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem aLIMToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem satımToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem laptoplarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem grafikToolStripMenuItem;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

