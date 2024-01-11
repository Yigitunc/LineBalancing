namespace HatDengelemeProject.design
{
    partial class ResultOfSimulation
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
            this.panels = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panels)).BeginInit();
            this.SuspendLayout();
            // 
            // panels
            // 
            this.panels.AllowUserToAddRows = false;
            this.panels.AllowUserToDeleteRows = false;
            this.panels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panels.Location = new System.Drawing.Point(53, 44);
            this.panels.Name = "panels";
            this.panels.ReadOnly = true;
            this.panels.Size = new System.Drawing.Size(1374, 644);
            this.panels.TabIndex = 10;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DarkRed;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(643, 717);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(150, 50);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Geri";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ResultOfSimulation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1630, 837);
            this.ControlBox = false;
            this.Controls.Add(this.panels);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "ResultOfSimulation";
            this.Load += new System.EventHandler(this.ResultOfSimulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView panels;
        private System.Windows.Forms.Button backButton;
    }
}