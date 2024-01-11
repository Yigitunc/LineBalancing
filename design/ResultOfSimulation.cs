using HatDengelemeProject.operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HatDengelemeProject.design
{
    public partial class ResultOfSimulation : Form
    {
        public ResultOfSimulation()
        {
            InitializeComponent();
        }

        private void ResultOfSimulation_Load(object sender, EventArgs e)
        {

            DatabaseHelper databaseHelper = new DatabaseHelper();
            this.AutoScaleMode = AutoScaleMode.None;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            fillTheGrid();

        }
        private void fillTheGrid()
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();

            string query = $"SELECT * FROM order_of_manufacture";
            DataTable result = databaseHelper.ExecuteQuery(query);

            panels.DataSource = result;
            panels.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);

            panels.Columns[0].Width = 45;
            panels.Columns[0].HeaderText = "ID";
            panels.Columns[1].Width = 150;
            panels.Columns[1].HeaderText = "Rota Adı";
            panels.Columns[2].Width = 80;
            panels.Columns[2].HeaderText = "Rota Süresi";
            panels.Columns[3].Width = 80;
            panels.Columns[3].HeaderText = "Ürün Sayısı";
            panels.Columns[4].Width = 975;
            panels.Columns[4].HeaderText = "Ürünler";


        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
