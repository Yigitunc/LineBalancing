using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using HatDengelemeProject.design;

namespace TimeCalc
{
	public partial class MainPage : Form
	{

		public MainPage()
		{
			InitializeComponent();
		}
		public abstract class ToolStripRenderer
		{

		}
		class MenuColorTable : ProfessionalColorTable
		{
			public MenuColorTable()
			{
				// see notes
				base.UseSystemColors = false;
			}
			public override System.Drawing.Color MenuBorder
			{
				get { return Color.Fuchsia; }
			}
			public override System.Drawing.Color MenuItemBorder
			{
				get { return Color.FromArgb(62, 66, 73); }
			}
			public override Color MenuItemSelected
			{
				get { return Color.Red; }
			}
			public override Color MenuItemSelectedGradientBegin
			{
				get { return Color.FromArgb(62, 66, 73); }
			}
			public override Color MenuItemSelectedGradientEnd
			{
				get { return Color.FromArgb(62, 66, 73); }
			}

		}

		protected override void OnPaint(PaintEventArgs e)
		{
			ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(54, 57, 63), ButtonBorderStyle.Solid);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
            this.IsMdiContainer = true;
            foreach (Control control in this.Controls)
            {
                // #2
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    // #3
                    client.BackColor = Color.FromArgb(54, 57, 63);
                    // 4#
                    break;
                }
            }

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
		}

		private void button1_Click(object sender, EventArgs e)
		{

			DurakTanımlama lpta = new DurakTanımlama();
			lpta.Name = "deneme";

			if (Application.OpenForms["deneme"] == null)
			{

				lpta.Show();
			}
			else lpta.Focus();

		}
        private Form formInstance;

        public static class FormManager
        {
            private static Form currentForm;

            public static void OpenForm<T>(Form parentForm) where T : Form, new()
            {
                if (currentForm != null && !currentForm.IsDisposed && currentForm.GetType() == typeof(T))
                {
                    return; 
                }
                if (currentForm != null && !currentForm.IsDisposed)
                {
                    currentForm.Close();
                }

                T form = new T();
                form.FormClosed += (sender, e) => currentForm = null; // Form kapatıldığında currentForm'u null'a ayarla
                form.StartPosition = FormStartPosition.Manual;
				//form.TopMost = true;
                parentForm.LocationChanged += (sender, e) => AdjustFormLocation(form, parentForm); // Ana formun lokasyon değişikliklerini dinle

                AdjustFormLocation(form, parentForm); // İlk konum ayarlaması için AdjustFormLocation metodunu çağır

                form.Show();
                currentForm = form;
            }

            private static void AdjustFormLocation(Form form, Form parentForm)
            {
                // Ana formun tam ortasında yeni formu yerleştir
                int x = parentForm.Left + (parentForm.Width - form.Width) / 2 + 72;
                int y = parentForm.Top + (parentForm.Height - form.Height) / 2 + 11;
                form.Location = new Point(x, y);
                form.Activated += (sender, e) => { form.TopMost = true; }; // Form aktive olduğunda TopMost özelliğini true olarak ayarla
                form.Deactivate += (sender, e) => { form.TopMost = false; }; // Form deaktive olduğunda TopMost özelliğini false olarak ayarla

            }
        }

   
        private void aLIMToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (!newWindow.IsDisposed)
                newWindow.Close();
            newWindow = new DurakTanımlama();
            this.ClientSize = newWindow.Size;
            newWindow.MdiParent = this;
            newWindow.Dock = DockStyle.Fill;
            this.MinimumSize = this.Size;
            newWindow.Show();

            //FormManager.OpenForm<DurakTanımlama>(this);
        }

        private void satımToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!newWindow.IsDisposed)
				newWindow.Close();

            newWindow = new ProductDefinition();
            this.ClientSize = newWindow.Size;
            newWindow.MdiParent = this;
            newWindow.Dock = DockStyle.Fill;
            this.MinimumSize = this.Size;
            newWindow.Show();
            //FormManager.OpenForm<ProductDefinition>(this);
        }
		Form newWindow = new Form();
        private void laptoplarToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (!newWindow.IsDisposed)
                newWindow.Close();
            newWindow = new OrderOfManufacture();
            this.ClientSize = newWindow.Size;
            newWindow.MdiParent = this;
            newWindow.Dock = DockStyle.Fill;
            this.MinimumSize = this.Size;
            newWindow.Show();

            //OpenForm<OrderOfManufacture>();
            //FormManager.OpenForm<OrderOfManufacture>(this);
        }

        private void grafikToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (!newWindow.IsDisposed)
                newWindow.Close();

            newWindow = new ResultOfSimulation();
            this.ClientSize = newWindow.Size;
            newWindow.MdiParent = this;
            newWindow.Dock = DockStyle.Fill;
            this.MinimumSize = this.Size;
            newWindow.Show();
        }
        private void metroButton4_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void metroButton1_Click(object sender, EventArgs e)
		{


			ProductDefinition lpts = new ProductDefinition();
			lpts.Name = "deneme";

			if (Application.OpenForms["deneme"] == null)
			{

				lpts.Show();
			}
			else lpts.Focus();
		}

		private void metroButton2_Click(object sender, EventArgs e)
		{
			DurakTanımlama lpta = new DurakTanımlama();
			lpta.Name = "deneme";

			if (Application.OpenForms["deneme"] == null)
			{

				lpta.Show();
			}
			else lpta.Focus();
		}

		private void metroButton3_Click(object sender, EventArgs e)
		{
			OrderOfManufacture laptops = new OrderOfManufacture();
			laptops.Name = "deneme";

			if (Application.OpenForms["deneme"] == null)
			{

				laptops.Show();
			}
			else laptops.Focus();
		}
		private void button1_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<Simulation>(this);
        }
    }
}
