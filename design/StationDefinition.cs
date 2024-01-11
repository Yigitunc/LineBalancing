using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlTypes;
using MySql.Data;
using MySql.Data.MySqlClient;
using HatDengelemeProject.operations;
using System.Xml.Linq;

namespace TimeCalc
{
	public partial class DurakTanımlama : Form
	{

        public DurakTanımlama()
		{
			InitializeComponent();
		}
        private void DurakTanımlama_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            stationName.Text = "";
            stationTime.Text = "0";
            fillTheGrid();
            countStations();


        }
        private void countStations()
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            string query = $"SELECT COUNT(*) FROM stations";
            DataTable result = databaseHelper.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                int recordCount = Convert.ToInt32(result.Rows[0][0]);
                stationCountLabel.Text = recordCount.ToString();
            }
        }


        private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			foreach (Control item in this.Controls)
			{
				if (item is TextBox)
				{
					item.Text = "";
				}
			}
		}
		
		private void button1_Click(object sender, EventArgs e)
		{
            DatabaseHelper databaseHelper = new DatabaseHelper();

            string stationTimeText = stationTime.Text.Trim();
            string stationManCountText = stationManCount.Text.Trim();
            bool stationExist = false;
            int stationTimeValue;
            int stationManCountValue;

            string queryy = $"SELECT station_name FROM stations WHERE station_name = '{stationName.Text}'";
            DataTable result = databaseHelper.ExecuteQuery(queryy);

            if (result.Rows.Count > 0)
            {
                string productName = result.Rows[0]["station_name"].ToString();
                if (productName.Length != 0)
                {
                    stationExist = true;
                    MessageBox.Show("Aynı isimle panel kaydedemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (stationExist == false)
            {

                if (!int.TryParse(stationTimeText, out stationTimeValue))
                {
                    MessageBox.Show("Geçerli bir istasyon süresi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(stationManCountText, out stationManCountValue))
                {
                    MessageBox.Show("Geçerli bir istasyon personel sayısı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                if (!(stationName.Text == "" || stationName.Text == " " || stationTime.Text == "" || stationTime.Text == " "))
                {
                    try
                    {
                        if (stationManCount.Text == "")
                        {
                            string query = $"INSERT INTO stations (station_name, station_time) VALUES ('{stationName.Text}', '{stationTime.Text}')";
                            databaseHelper.ExecuteNonQuery(query);
                        }
                        else
                        {
                            string query = $"INSERT INTO stations (station_name, station_time, station_man_count) VALUES ('{stationName.Text}', '{stationTime.Text}', '{stationManCount.Text}')";
                            databaseHelper.ExecuteNonQuery(query);
                        }

                        MessageBox.Show("Kayıt Başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillTheGrid();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Bir hata oluştu. Hata : " + error.Message);
                    }
                }
                else MessageBox.Show("Lütfen Boşlukları Doldurun.");
            }
         
        }

        private void deleteStationButton_Click(object sender, EventArgs e)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            if (stations.RowCount > 0)
            {
                try
                {
                    string stationId = stations.CurrentRow.Cells[0].Value.ToString();
                    string query = $"SELECT * FROM stations WHERE station_id = {stationId}";
                    DataTable result = databaseHelper.ExecuteQuery(query);

                    if (result.Rows.Count > 0)
                    {
                        string stationName = result.Rows[0]["station_name"].ToString();

                        string isim = stationId + " id numaralı " + stationName + " isimli durak";

                        DialogResult situation = MessageBox.Show(isim + "kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                        if (DialogResult.Yes == situation)
                        {
                            string deleteQuery = $"DELETE FROM stations WHERE station_id = {stationId}";
                            databaseHelper.ExecuteNonQuery(deleteQuery);

                            MessageBox.Show("Kayıt Silindi.");
                            fillTheGrid();
                            countStations();

                            foreach (Control item in this.Controls)
                            {
                                if (item is System.Windows.Forms.TextBox)
                                    item.Text = "";
                            }
                        }
                        else
                            MessageBox.Show("Vazgeçildi.");
                    }
                    else
                        MessageBox.Show("Kayıt bulunamadı.");

                    fillTheGrid();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Bir hata oluştu." + error.Message);
                }

            }
            else MessageBox.Show("Kayıt Seçmeniz Lazım.");
        }
        private void fillTheGrid()
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();

            string query = $"SELECT * FROM stations";
            DataTable result = databaseHelper.ExecuteQuery(query);

            stations.DataSource = result;

            stations.Columns[0].Width = 103;
            stations.Columns[0].HeaderText = "İstasyon id";
            stations.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            stations.Columns[1].Width = 198;
            stations.Columns[1].HeaderText = "İstasyon adı";
            stations.Columns[2].Width = 128;
            stations.Columns[2].HeaderText = "İstasyon süresi";
            stations.Columns[3].Width = 138;
            stations.Columns[3].HeaderText = "İstasyon iş gücü";

        }

        private void stations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();

            try
            {
                string stationId = stations.CurrentRow.Cells[0].Value.ToString();
                string query = $"SELECT * FROM stations WHERE station_id = {stationId}";
                DataTable result = databaseHelper.ExecuteQuery(query);

                if (result.Rows.Count > 0)
                {
                    stationName.Text = result.Rows[0]["station_name"].ToString();
                    stationTime.Text = result.Rows[0]["station_time"].ToString();
                    stationIdLabel.Text = result.Rows[0]["station_id"].ToString();

                    if (result.Rows[0]["station_man_count"].ToString().Length != 0)
                    stationManCount.Text = result.Rows[0]["station_man_count"].ToString();
                }
                else
                    MessageBox.Show("Kayıt bulunamadı.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Bir hata oluştu. Hata : " + error.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string stationTimeText = stationTime.Text.Trim();
            string stationManCountText = stationManCount.Text.Trim();

            int stationTimeValue;
            int stationManCountValue;

            if (!int.TryParse(stationTimeText, out stationTimeValue))
            {
                MessageBox.Show("Geçerli bir istasyon süresi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(stationManCountText, out stationManCountValue))
            {
                MessageBox.Show("Geçerli bir istasyon personel sayısı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DatabaseHelper databaseHelper = new DatabaseHelper();

            if (!(stationName.Text == "" || stationName.Text == " " || stationTime.Text == "" || stationTime.Text == " " || stationIdLabel.Text == "label1"))
            {
                try
                {
                    int stationId = int.Parse(stationIdLabel.Text);

                    string query = $"UPDATE stations SET station_name = '{stationName.Text}', station_time = '{stationTime.Text}', station_man_count = '{stationManCount.Text}' WHERE station_id = '{stationId}'";
                    databaseHelper.ExecuteNonQuery(query);

                    MessageBox.Show("Güncelleme başarılı.");
                    fillTheGrid();
                    
                }
                catch (Exception error)
                {
                    MessageBox.Show("Bir hata oluştu. Hata: " + error.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boşlukları Doldurun.");
            }

        }
    }
}

