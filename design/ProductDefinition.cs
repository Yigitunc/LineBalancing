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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using HatDengelemeProject.operations;
using System.Drawing.Text;
using MySqlX.XDevAPI.Common;
using static MetroFramework.Drawing.MetroPaint.BorderColor;
using System.Text.RegularExpressions;
using System.Collections;
using System.Reflection;

namespace TimeCalc
{
	public partial class ProductDefinition : Form
	{

        public ProductDefinition()
		{
			InitializeComponent();
		}

        List<System.Windows.Forms.TextBox> textBoxList = new List<System.Windows.Forms.TextBox>();
        private List<Label> labelList = new List<Label>();
        private List<System.Windows.Forms.ComboBox> comboBoxList = new List<System.Windows.Forms.ComboBox>();
        private void ProductDefinition_Load(object sender, EventArgs e)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            fillTheGrid();
            countPanels();

        }
        private void countPanels()
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            string query = $"SELECT COUNT(*) FROM products";
            DataTable result = databaseHelper.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                int recordCount = Convert.ToInt32(result.Rows[0][0]);
                panelCountLabel.Text = recordCount.ToString();
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
				if (item is System.Windows.Forms.TextBox)
				{
					item.Text = "";
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
            DatabaseHelper databaseHelper = new DatabaseHelper();
            if (productNameTextBox.Text == "" || productNameTextBox.Text == " ")
            {
                MessageBox.Show("Panel ismi boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // TextBox'ları kontrol etme
                foreach (System.Windows.Forms.TextBox textBox in textBoxList)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MessageBox.Show("Lütfen tüm dakikaları ve adam sayısı seçeneklerini doldurun. (Sadece gerektiği kadar adım sayısı ekleyin)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // ComboBox'ları kontrol etme
                foreach (System.Windows.Forms.ComboBox comboBox in comboBoxList)
                {
                    if (comboBox.SelectedItem == null)
                    {
                        MessageBox.Show("Lütfen tüm rotaları seçin. (Sadece gerektiği kadar adım sayısı ekleyin)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                String routeList = "";
                String routeTimesList = "";
                String routeManList = "";

                int i = 0;
                int x = 0;
                int y = 0;
                int k = -1;

                foreach (Control item in this.Controls)
                {
                    if (item.Name == "productNameTextBox" || item.Name == "panelRouteCountCombobox")
                        continue;

                    if (item is System.Windows.Forms.ComboBox)
                        routeList += item.Text + ",";

                    if (item is System.Windows.Forms.TextBox)
                    {

                        if (item.Name == "timeTextBox" + x)
                        {
                            routeTimesList += item.Text + ",";
                            x += 1;

                        }
                        if (item.Name == "manTextBox" + y)
                        {
                            routeManList += item.Text + ",";
                            y += 1;
                        }
                    }
                    i++;
                }
                routeList = routeList.Remove(routeList.Length - 1);
                routeTimesList = routeTimesList.Remove(routeTimesList.Length - 1);
                routeManList = routeManList.Remove(routeManList.Length - 1);

                try
                {
                    string query = $"INSERT INTO products (product_name, product_route_count, product_route, product_route_times, product_route_man_count) " +
                        $"VALUES ('{productNameTextBox.Text}', '{panelRouteCountCombobox.Text}', '{routeList}', '{routeTimesList}', '{routeManList}')";
                    databaseHelper.ExecuteNonQuery(query);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Kayıt Seçmeniz Lazım." + error.Message);
                }


                MessageBox.Show("Veriler başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillTheGrid();
                countPanels();

                System.Windows.Forms.TextBox selectedTextBox = textBoxList[0];
                System.Windows.Forms.TextBox selectedTextBox2 = textBoxList[1];
                System.Windows.Forms.TextBox selectedTextBox3 = textBoxList[2];
            }
        }

        private void createComboboxAndTextBoxes(int count, Boolean cellClick) {
            DatabaseHelper databaseHelper = new DatabaseHelper();

            // TextBox ları temizleme
            if (textBoxList.Count != 0)
            {
                for (int i = textBoxList.Count - 1; i >= 0; i--)
                {
                    System.Windows.Forms.TextBox textBox = textBoxList[i];
                   // if (string.IsNullOrWhiteSpace(textBox.Text))
                   // {
                        this.Controls.Remove(textBox);
                        textBox.Dispose();
                        textBoxList.RemoveAt(i);
                    //}
                }
            }

            // ComboBox'ları temizleme
            if (comboBoxList.Count != 0)
            {
                for (int i = comboBoxList.Count - 1; i >= 0; i--)
                {
                    System.Windows.Forms.ComboBox comboBox = comboBoxList[i];
                    //if (comboBox.SelectedItem == null)
                    //{
                        this.Controls.Remove(comboBox);
                        comboBox.Dispose();
                        comboBoxList.RemoveAt(i);
                    //}
                }
            }

            // Label'ları temizleme
            foreach (Label label in labelList)
            {
                this.Controls.Remove(label);
                label.Dispose();
            }
            labelList.Clear();

            int textBoxCount    = count; // Toplam TextBox sayısı
            int labelCount      = count; // Toplam Label sayısı
            int comboBoxCount   = count; // Toplam ComboBox sayısı

            for (int i = 0; i <= textBoxCount; i++)
            {
                System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                textBox.Name = "timeTextBox" + i.ToString();
                textBox.Location = new Point(400, 223 + (i * 25)); // TextBox'ların konumu
                textBox.Size = new Size(50, 25);
                this.Controls.Add(textBox);
                textBoxList.Add(textBox);

                System.Windows.Forms.TextBox textBox2 = new System.Windows.Forms.TextBox();
                textBox2.Name = "manTextBox" + i.ToString();
                textBox2.Location = new Point(500 , 223 + (i * 25)); // TextBox'ların konumu
                textBox2.Size = new Size(50, 25);
                this.Controls.Add(textBox2);
                textBoxList.Add(textBox2);
            }
            int labelCountText = 1;
            for (int i = 0; i <= labelCount; i++)
            {
                Label label = new Label();
                label.Text = "Label " + (i + 1);
                label.Location = new Point(90, 225 + (i * 25)); // Label'ların konumu
                label.Size = new Size(71, 23);
                label.Font = new Font("Sylfaen", 12); // Arial fontu, 12pt boyutu
                label.Text = labelCountText + ".Adım";
                label.ForeColor = Color.White; // Kırmızı renk
                this.Controls.Add(label);
                labelList.Add(label);
                labelCountText++;
            }

            for (int i = 0; i <= comboBoxCount; i++)
            {
                System.Windows.Forms.ComboBox comboBox = new System.Windows.Forms.ComboBox();
                comboBox.Name = "stationCombobox" + (i + 1);
                comboBox.Location = new Point(175, 225 + (i * 25)); // ComboBox'ların konumu
                comboBox.Size = new Size(178, 23);
                comboBox.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);

                if (cellClick == false)
                {
                    string query = $"SELECT station_name FROM stations";
                    DataTable result = databaseHelper.ExecuteQuery(query);

                    foreach (DataRow row in result.Rows)
                    {
                        comboBox.Items.Add(row["station_name"].ToString());
                    }
                }
                

                this.Controls.Add(comboBox);
                comboBoxList.Add(comboBox);
            }
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)sender;
            string comboBoxName = comboBox.Name;
            string comboBoxText = comboBox.Text;

            string timeQuery = $"SELECT station_time FROM stations where station_name = '{comboBoxText}'";
            DataTable result = databaseHelper.ExecuteQuery(timeQuery);
            string time = result.Rows[0]["station_time"].ToString();

            string manQuery = $"SELECT station_man_count FROM stations where station_name = '{comboBoxText}'";
            DataTable result2 = databaseHelper.ExecuteQuery(manQuery);
            string man = result2.Rows[0]["station_man_count"].ToString();
            if (man == "")
                man = "0";
            


            string pattern = @"\d+";
            Match match = Regex.Match(comboBoxName, pattern);
            int number = int.Parse(match.Value);

            foreach (Control item in this.textBoxList)
            {
                if (item.Name == "timeTextBox" + (number - 1).ToString())
                    item.Text = time;
                if (item.Name == "manTextBox" + (number - 1).ToString())
                    item.Text = man;
            }


            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

                createComboboxAndTextBoxes(panelRouteCountCombobox.SelectedIndex, false);
        }

        private void deletePanelButton_Click(object sender, EventArgs e)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            if (panels.RowCount > 0)
            {
                try
                {
                    string productId = panels.CurrentRow.Cells[0].Value.ToString();
                    string query = $"SELECT * FROM products WHERE product_id = {productId}";
                    DataTable result = databaseHelper.ExecuteQuery(query);

                    if (result.Rows.Count > 0)
                    {
                        string productName = result.Rows[0]["product_name"].ToString();

                        string isim = productId + " id numaralı " + productName + " isimli panel";

                        DialogResult situation = MessageBox.Show(isim + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                        if (DialogResult.Yes == situation)
                        {
                            string deleteQuery = $"DELETE FROM products WHERE product_id = {productId}";
                            databaseHelper.ExecuteNonQuery(deleteQuery);

                            MessageBox.Show("Kayıt Silindi.");
                            fillTheGrid();
                            countPanels();

                            foreach (Control item in this.Controls)
                            {
                                if (item is System.Windows.Forms.TextBox)
                                {
                                    item.Text = "";
                                }
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
                    MessageBox.Show("Kayıt Seçmeniz Lazım." + error.Message);
                }

            }
            else MessageBox.Show("Kayıt Seçmeniz Lazım.");
        }
        private void fillTheGrid()
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();

            string query = $"SELECT * FROM products";
            DataTable result = databaseHelper.ExecuteQuery(query);

            panels.DataSource = result;
            panels.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);

            panels.Columns[0].Width = 50;
            panels.Columns[0].HeaderText = "ID";
            panels.Columns[1].Width = 100;
            panels.Columns[1].HeaderText = "Panel adı";
            panels.Columns[2].Width = 60;
            panels.Columns[2].HeaderText = "Rota Sayısı";
            panels.Columns[3].Width = 369;
            panels.Columns[3].HeaderText = "Panel Rotası";
            panels.Columns[4].Width = 130;
            panels.Columns[4].HeaderText = "Rota Dakikaları";
            panels.Columns[5].Width = 130;
            panels.Columns[5].HeaderText = "Rota iş güçleri";
            panels.Columns[6].Width = 80;
            panels.Columns[6].HeaderText = "Rota Süresi";

        }

        private void panels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();

            try
            {
                string panelId = panels.CurrentRow.Cells[0].Value.ToString();
                string query = $"SELECT * FROM products WHERE product_id = {panelId}";
                DataTable result = databaseHelper.ExecuteQuery(query);

                if (result.Rows.Count > 0)
                {
                    string routeCount = result.Rows[0]["product_route_count"].ToString();
                    createComboboxAndTextBoxes(Convert.ToInt32(routeCount) - 1,false);

                    string routeListDb = result.Rows[0]["product_route"].ToString();
                    List<string> routeList = routeListDb.Split(',').ToList();

                    string routeTimeListdb = result.Rows[0]["product_route_times"].ToString();
                    List<string> routeTimesList = routeTimeListdb.Split(',').ToList();

                    string routeManListdb = result.Rows[0]["product_route_man_count"].ToString();
                    List<string> routeManList = routeManListdb.Split(',').ToList();

                    int i = 1;
                    int x = 0;
                    int y = 0;
                    int k = -1;
                    foreach (Control item in this.Controls)
                    {
                        if (item.Name == "panelAdi" || item.Name == "panelRouteCountCombobox")
                            continue;

                        if (item is System.Windows.Forms.ComboBox comboBox)
                        {
                            if (item.Name == "stationCombobox" + i)
                            {
                                comboBox.Text = routeList[i-1];
                                i++;
                            }
                        }

                        if (item is System.Windows.Forms.TextBox)
                        {

                            if (item.Name == "timeTextBox" + x)
                            {
                                k++;
                                item.Text = routeTimesList[x];
                                x += 1;   

                            }
                            if (item.Name == "manTextBox" + y)
                            {
                                item.Text = routeManList[y];
                                y += 1;
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Kayıt bulunamadı.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Bir hata oluştu. Hata : " + error.Message);
            }
        }
    }
}