using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using HatDengelemeProject.operations;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace TimeCalc
{
	public partial class OrderOfManufacture : Form
	{
        private List<Label> labelList = new List<Label>();
        private List<System.Windows.Forms.ComboBox> comboBoxList = new List<System.Windows.Forms.ComboBox>();

        public OrderOfManufacture()
		{
			InitializeComponent();
		}
        private void LoadDataToComboBox()
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();

            string query = $"SELECT order_name FROM order_of_manufacture";
            DataTable result = databaseHelper.ExecuteQuery(query);

            existingOrderCombobox.Items.Clear();

            foreach (DataRow row in result.Rows)
            {
                existingOrderCombobox.Items.Add(row["order_name"].ToString());
            }
        }

        private void OrderOfManufacture_Load(object sender, EventArgs e)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            string query = $"SELECT * FROM order_of_manufacture";
            DataTable result = databaseHelper.ExecuteQuery(query);
            if (result.Rows.Count > 0)
                LoadDataToComboBox();
            
        }

        private void createComboboxAndLabels(int count, Boolean cellClick)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();

            // ComboBox'ları temizleme
            if (comboBoxList.Count != 0)
            {
                for (int i = comboBoxList.Count - 1; i >= 0; i--)
                {
                    System.Windows.Forms.ComboBox comboBox = comboBoxList[i];
                   // if (comboBox.SelectedItem == null)
                   // {
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

            int labelCount = count;
            int comboBoxCount = count;
            int between25and50Label = 0;
            int between50and75Label = 0;
            int between75and100Label = 0;

            if (labelCount <= 50)
                this.Width = 1100;
            else if (labelCount > 50 && labelCount <= 75)
                this.Width = 1100;
            else if (labelCount > 75 && labelCount <= 100)
                this.Width = 1600;


            int labelCountText = 1;
            for (int i = 0; i <= labelCount; i++)
            {
                if (i < 25)
                {
                    Label label = new Label();
                    label.Text = "Label " + (i + 1);
                    label.Location = new Point(85, 75 + (i * 25)); // Label'ların konumu
                    label.Size = new Size(71, 23);
                    label.Font = new Font("Sylfaen", 12); // Arial fontu, 12pt boyutu
                    label.Text = labelCountText + ".Adım";
                    label.ForeColor = Color.White; // Kırmızı renk
                    this.Controls.Add(label);
                    labelList.Add(label);
                    labelCountText++;
                }
                else if (i >= 25 && i < 50)
                {
                    Label label = new Label();
                    label.Text = "Label " + (i + 1);
                    label.Location = new Point(420, 75 + (between25and50Label * 25)); // Label'ların konumu
                    label.Size = new Size(71, 23);
                    label.Font = new Font("Sylfaen", 12); // Arial fontu, 12pt boyutu
                    label.Text = labelCountText + ".Adım";
                    label.ForeColor = Color.White; // Kırmızı renk
                    this.Controls.Add(label);
                    labelList.Add(label);
                    labelCountText++;
                    between25and50Label++;
                }
                else if (i >= 50 && i < 75)
                {
                    Label label = new Label();
                    label.Text = "Label " + (i + 1);
                    label.Location = new Point(755, 75 + (between50and75Label * 25)); // Label'ların konumu
                    label.Size = new Size(71, 23);
                    label.Font = new Font("Sylfaen", 12); // Arial fontu, 12pt boyutu
                    label.Text = labelCountText + ".Adım";
                    label.ForeColor = Color.White; // Kırmızı renk
                    this.Controls.Add(label);
                    labelList.Add(label);
                    labelCountText++;
                    between50and75Label++;
                }
                else if (i >= 75 && i <= 100)
                {
                    Label label = new Label();
                    label.Text = "Label " + (i + 1);
                    label.Location = new Point(1090, 75 + (between75and100Label * 25)); // Label'ların konumu
                    label.Size = new Size(71, 23);
                    label.Font = new Font("Sylfaen", 12); // Arial fontu, 12pt boyutu
                    label.Text = labelCountText + ".Adım";
                    label.ForeColor = Color.White; // Kırmızı renk
                    this.Controls.Add(label);
                    labelList.Add(label);
                    labelCountText++;
                    between75and100Label++;
                }
            }

            int between25and50Combobox = 0;
            int between50and75Combobox = 0;
            int between75and100Combobox = 0;

            for (int i = 0; i <= comboBoxCount; i++)
            {
                if (i < 25)
                {
                    System.Windows.Forms.ComboBox comboBox = new System.Windows.Forms.ComboBox();
                    comboBox.Name = "comboBox" + (i + 1);
                    comboBox.Location = new Point(175, 75 + (i * 25)); // ComboBox'ların konumu
                    comboBox.Size = new Size(178, 23);
                    this.Controls.Add(comboBox);
                    comboBoxList.Add(comboBox);

                    if (cellClick == false)
                    {
                        string query = $"SELECT product_name FROM products";
                        DataTable result = databaseHelper.ExecuteQuery(query);

                        foreach (DataRow row in result.Rows)
                            comboBox.Items.Add(row["product_name"].ToString());
                    }
                }
                else if (i >= 25 && i < 50)
                {
                    System.Windows.Forms.ComboBox comboBox = new System.Windows.Forms.ComboBox();
                    comboBox.Name = "comboBox" + (i + 1);
                    comboBox.Location = new Point(510, 75 + (between25and50Combobox * 25)); // ComboBox'ların konumu
                    comboBox.Size = new Size(178, 23);
                    this.Controls.Add(comboBox);
                    comboBoxList.Add(comboBox);
                    between25and50Combobox++;
                    if (cellClick == false)
                    {
                        string query = $"SELECT product_name FROM products";
                        DataTable result = databaseHelper.ExecuteQuery(query);

                        foreach (DataRow row in result.Rows)
                            comboBox.Items.Add(row["product_name"].ToString());
                    }
                }
                else if (i >= 50 && i < 75)
                {
                    System.Windows.Forms.ComboBox comboBox = new System.Windows.Forms.ComboBox();
                    comboBox.Name = "comboBox" + (i + 1);
                    comboBox.Location = new Point(845, 75 + (between50and75Combobox * 25)); // ComboBox'ların konumu
                    comboBox.Size = new Size(178, 23);
                    this.Controls.Add(comboBox);
                    comboBoxList.Add(comboBox);
                    between50and75Combobox++;
                    if (cellClick == false)
                    {
                        string query = $"SELECT product_name FROM products";
                        DataTable result = databaseHelper.ExecuteQuery(query);

                        foreach (DataRow row in result.Rows)
                            comboBox.Items.Add(row["product_name"].ToString());
                    }
                }
                else if (i >= 75 && i <= 100)
                {
                    System.Windows.Forms.ComboBox comboBox = new System.Windows.Forms.ComboBox();
                    comboBox.Name = "comboBox" + (i + 1);
                    comboBox.Location = new Point(1180, 75 + (between75and100Combobox * 25)); // ComboBox'ların konumu
                    comboBox.Size = new Size(178, 23);
                    this.Controls.Add(comboBox);
                    comboBoxList.Add(comboBox);
                    between75and100Combobox++;
                    if (cellClick == false)
                    {
                        string query = $"SELECT product_name FROM products";
                        DataTable result = databaseHelper.ExecuteQuery(query);

                        foreach (DataRow row in result.Rows)
                            comboBox.Items.Add(row["product_name"].ToString());
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            createComboboxAndLabels(productCountCombobox.SelectedIndex,false);
            orderNameTextBox.Text = "";
        }

        private void existingOrderCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();

            //existingOrderCount 
            try
            {
                string orderName = existingOrderCombobox.Text;
                string query = $"SELECT * FROM order_of_manufacture WHERE order_name = '{orderName}'";
                DataTable result = databaseHelper.ExecuteQuery(query);

                if (result.Rows.Count > 0)
                {
                    string orderCount = result.Rows[0]["order_count"].ToString();
                    string orderListdb = result.Rows[0]["order_list"].ToString();
                    List<string> orderList = orderListdb.Split(',').ToList();

                    productCountCombobox.Text = orderCount; 
                    createComboboxAndLabels(Convert.ToInt32(orderCount) - 1,false);

                    orderNameTextBox.Text = orderName;
                    int i = 0;
                    foreach (Control item in this.Controls)
                    {
                        if (item.Name == "productCountCombobox" || item.Name == "existingOrderCombobox")
                            continue;

                        if (item is ComboBox)
                        {
                            item.Text = orderList[i];
                            i++;
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


        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            string oldOrderList = "";
            string orderList = "";

            foreach (Control item in this.Controls)
            {
                if (item.Name == "productCountCombobox" || item.Name == "existingOrderCombobox")
                    continue;

                if (item is ComboBox && item.ToString().Length > 0)
                    oldOrderList += item.Text + ",";
            }
            orderList = oldOrderList.Remove(oldOrderList.Length - 1);
            if (orderNameTextBox.Text == existingOrderCombobox.Text)
            {
                string orderCount = productCountCombobox.Text;
                string orderNameDb = orderNameTextBox.Text;

                // INSERT INTO sorgusu oluşturun
                string query = $"UPDATE order_of_manufacture SET order_count = '{orderCount}', order_list = '{orderList}'  WHERE order_name = '{orderNameDb}'";

                databaseHelper.ExecuteNonQuery(query);

                MessageBox.Show("Kayıt başarıyla güncellendi.");
            }
            else if (!(orderNameTextBox.Text == "" || orderNameTextBox.Text == " "))
            {
                string orderCount = productCountCombobox.Text;
                string orderNameDb = orderNameTextBox.Text;

                // INSERT INTO sorgusu oluşturun
                string query = $"INSERT INTO order_of_manufacture (order_count, order_list, order_name) VALUES ('{orderCount}', '{orderList}', '{orderNameDb}')";

                databaseHelper.ExecuteNonQuery(query);

                MessageBox.Show("Kayıt başarıyla eklendi.");
                existingOrderCombobox.Items.Add(orderNameDb);
            }
            else
                MessageBox.Show("Sıralama adını kontrol ediniz.");

        }


        private void deleteOrder_Click(object sender, EventArgs e)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
                try
                {
                    DialogResult situation = MessageBox.Show(orderNameTextBox.Text + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                    if (DialogResult.Yes == situation)
                    {
                    string deleteQuery = $"DELETE FROM order_of_manufacture WHERE order_name = '{orderNameTextBox.Text}'";
                    databaseHelper.ExecuteNonQuery(deleteQuery);

                    MessageBox.Show("Kayıt Silindi.");

                    existingOrderCombobox.Items.Remove(orderNameTextBox.Text);
                    orderNameTextBox.Text = "";
                    productCountCombobox.Text = "0";


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
                           // }
                        }
                    }

                    // Label'ları temizleme
                    foreach (Label label in labelList)
                    {
                        this.Controls.Remove(label);
                        label.Dispose();
                    }
                    labelList.Clear();

                    

                    }
                    else
                        MessageBox.Show("Vazgeçildi.");
                    
                }
                catch (Exception error)
                {
                    MessageBox.Show("Kayıt Seçmeniz Lazım." + error.Message);
                }
            
        }
    }
}
