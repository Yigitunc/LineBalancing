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

		private void aLIMToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DurakTanımlama durakTanımlama = new DurakTanımlama();
            durakTanımlama.Name = "deneme";

			if (Application.OpenForms["deneme"] == null)
			{
                durakTanımlama.Show();
			}
			else durakTanımlama.Focus();

		}

		private void satımToolStripMenuItem_Click(object sender, EventArgs e)
		{

			ProductDefinition lpts = new ProductDefinition();
			lpts.Name = "deneme";

			if (Application.OpenForms["deneme"] == null)
			{

				lpts.Show();
			}
			else lpts.Focus();
		}

		private void laptoplarToolStripMenuItem_Click(object sender, EventArgs e)
		{

			OrderOfManufacture imalat = new OrderOfManufacture();
            imalat.Name = "deneme";

			if (Application.OpenForms["deneme"] == null)
			{
                imalat.Show();
			}
			else imalat.Focus();
		}

		private void grafikToolStripMenuItem_Click(object sender, EventArgs e)
		{

			Simulation simulation = new Simulation();
            simulation.Name = "deneme";

			if (Application.OpenForms["deneme"] == null)
			{

                simulation.Show();
			}
			else simulation.Focus();
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

		private void Form1_Shown(object sender, EventArgs e)
		{



		}

		private void button2_Click(object sender, EventArgs e)
		{



		}
    }
}
