using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
using TimeCalc.models;
using System.Reflection;
using System.Threading;

using HatDengelemeProject.operations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TimeCalc
{
	public partial class Simulation : Form
	{
		public Simulation()
		{
			InitializeComponent();
		}

        private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
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

        private void Grafikler_Load(object sender, EventArgs e)
		{
            ratioCombobox.SelectedIndex = 0;
            DatabaseHelper databaseHelper = new DatabaseHelper();

            string firstQuery = $"SELECT * FROM order_of_manufacture";
            DataTable firstResult = databaseHelper.ExecuteQuery(firstQuery);
            if (firstResult.Rows.Count > 0)
                LoadDataToComboBox();

            int xCoordinate = 50;
            int yCoordinate = 40;

            try
            {
                string query = $"SELECT station_name FROM stations";
                DataTable result = databaseHelper.ExecuteQuery(query);

                if (result.Rows.Count > 0)
                {
                    int recordCount = Convert.ToInt32(result.Rows.Count);

                    string stationName ;

                    for (int i = 1; i < recordCount + 1 ; i++)
                    {
                        stationName = result.Rows[i-1]["station_name"].ToString();

                        DraggableGroupBox draggableGroupBox = definingGroupBoxes(stationName, xCoordinate, yCoordinate);
                        xCoordinate += 310;
                        if (i % 4 == 0)
                        {
                            yCoordinate += 130;
                            xCoordinate = 50;
                        }
                        draggableGroupBoxList.Add(draggableGroupBox);
                        this.Controls.Add(draggableGroupBox);

                    }

                }
                else
                    MessageBox.Show("Kayıtlı istasyon bulunamadı.");

            }
            catch (Exception error)
            {
                MessageBox.Show("Bir hata oluştu." + error.Message);
            }

        }

        static public List<DraggableGroupBox> draggableGroupBoxList = new List<DraggableGroupBox>();
        static public double ratio = 1000;


        public List<DraggableGroupBox> DraggableGroupBoxList
        {
            get { return draggableGroupBoxList; }
            set { draggableGroupBoxList = value; }
        }

        private DraggableGroupBox definingGroupBoxes(String textboxValue,int xCoordinate, int yCoordinate)
		{
            DraggableGroupBox draggableGroupBox = new DraggableGroupBox();
            draggableGroupBox.Name = textboxValue;
            draggableGroupBox.Location = new Point(xCoordinate, yCoordinate);
            draggableGroupBox.Size = new Size(270, 100);

            TextBox textBox1 = new TextBox();
            textBox1.Name = "textBox1";
			textBox1.Text = textboxValue;
            textBox1.Location = new Point(2 , 8);
			textBox1.Multiline = true;
			textBox1.Size = new Size(266, 30);
            textBox1.Font = new Font("Microsoft Sans Serif", 12);
			textBox1.ReadOnly = true;
			textBox1.Cursor = Cursors.No;
            textBox1.TextAlign = HorizontalAlignment.Center;
            draggableGroupBox.Controls.Add(textBox1);

            draggableGroupBox.Controls.Add(labelDefinition(
            "onProcessLabel",
            "İŞLEMDE",
            new Font("Microsoft Sans Serif", 11),
            new Point(5, 42),
            Color.Green,
            new Size(73, 20)));

            draggableGroupBox.Controls.Add(labelDefinition(
           "onWaitingLabel",
           "BEKLEYENLER",
           new Font("Microsoft Sans Serif", 11),
           new Point(115, 42),
           Color.Red,
           new Size(150, 20)));

            draggableGroupBox.Controls.Add(labelDefinition(
           textboxValue+"processValue",
           "-",
           new Font("Microsoft Sans Serif", 11),
           new Point(5, 68),
           Color.White,
           new Size(105, 20)));

            draggableGroupBox.Controls.Add(labelDefinition(
            textboxValue+"waitingList",
            "-", 
            new Font("Microsoft Sans Serif", 10),
            new Point(115, 68),
            Color.White,
            new Size(150, 20)));

            return draggableGroupBox;

        }

        private Label labelDefinition(String labelName, String text, Font font, Point point, Color color, Size size)
        {
            Label labelname = new Label();
            labelname.Location = point;
            labelname.Text = text;
            labelname.Font = font;
            labelname.ForeColor = color;
            labelname.Size = size;
            labelname.Name = labelName;

            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(labelname, labelname.Text);
            labelname.MouseHover += (sender, e) => {
                tooltip.Show(labelname.Text, labelname, labelname.Location.X-115 + labelname.Width, labelname.Location.Y-70);
            };
            labelname.MouseLeave += (sender, e) => {
                tooltip.Hide(labelname);
            };

            return labelname;
        }

        private int counter = 1;

        public void SetComboBoxValue(String text)
        {
            existingOrderCombobox.Text = text;

        }
        public delegate void ComboBoxValueDelegate(string value);


        private async void button1_Click(object sender, EventArgs e)
        {
            if (existingOrderCombobox.Text == "" || existingOrderCombobox.Text == " ")
            {
                MessageBox.Show("Üretim sırasını seçiniz.");
            }
            else
            {

                timer1.Start();

                DatabaseHelper databaseHelper = new DatabaseHelper();
                string query = $"SELECT order_list FROM order_of_manufacture where order_name = '{existingOrderCombobox.Text}'";
                DataTable result = databaseHelper.ExecuteQuery(query);

                List<StationModel> allStationsList = new List<StationModel>();

                foreach (Control control in Controls)
                {
                    if (control is System.Windows.Forms.GroupBox groupBox)
                    {
                        foreach (Control groupBoxControl in groupBox.Controls)
                        {
                            if (groupBoxControl is TextBox textBox && textBox.Name == "textBox1")
                            {
                                StationModel stationModel = new StationModel(textBox.Text);
                                allStationsList.Add(stationModel);
                            }
                        }
                    }
                }
                if (result.Rows.Count > 0)
                {
                    string orderListdb = result.Rows[0]["order_list"].ToString();
                    List<string> orderList = orderListdb.Split(',').ToList();
                    List<string> orderManufacture = new List<string>();

                    int i = 0;
                    foreach (var item in orderList)
                    {
                        string routeQuery = $"SELECT product_route,product_route_times FROM products where product_name = '{item}'";
                        DataTable routeResult = databaseHelper.ExecuteQuery(routeQuery);
                        string productRoute = routeResult.Rows[0]["product_route"].ToString();
                        List<string> productRouteList = productRoute.Split(',').ToList();

                        string productRouteTimes = routeResult.Rows[0]["product_route_times"].ToString();
                        List<string> productRouteTimeList = productRouteTimes.Split(',').ToList();

                        List<StationModel> productStationsList = new List<StationModel>();
                        Dictionary<StationModel, string> orderMap = new Dictionary<StationModel, string>();

                        int y = 0;
                        foreach (var station in productRouteList)
                        {
                            StationModel newStationModel = allStationsList.Find(x => x.getStationName().Equals(station));
                            //newStationModel.setStationTime(productRouteTimeList[y]);
                            //productStationsList.Add(newStationModel);
                            orderMap.Add(newStationModel, productRouteTimeList[y]);
                            if (newStationModel.getStationName() != "")
                            {
                                y++;
                            }
                        }

                        ProductModel product = new ProductModel(item + "-" + i.ToString(), orderMap);
                        orderMap.Keys.First().waitingProducts.Enqueue(product);
                        orderManufacture.Add(item + "-" + i.ToString());
                        i++;
                    }
                    foreach (var item in allStationsList)
                    {
                        item.firstStart();
                    }
                    await Task.Run(() =>
                    {
                        foreach (var item in allStationsList)
                        {
                            item.startProcess();
                        }
                    });
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter <= 100)
            {
                clock.Text = counter.ToString();
                counter++;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearGroupBox(panelType1, panelValue1, panelType2, panelValue2);
            existingOrderCombobox.Text = "";
            timer1.Stop();
            counter = 0;
            clock.Text = "0";
        }

        private void clearGroupBox(System.Windows.Forms.GroupBox panelType1, System.Windows.Forms.GroupBox panelValue1, System.Windows.Forms.GroupBox panelType2, System.Windows.Forms.GroupBox panelValue2)
        {
            List<Label> labelsToRemove = new List<Label>();

            foreach (Control control in panelType1.Controls)
            {
                if (control is Label label && label.Name != "panelTypeLabel")
                    labelsToRemove.Add(label);
            }

            foreach (Label label in labelsToRemove)
            {
                panelType1.Controls.Remove(label);
                label.Dispose();
            }
            labelsToRemove.Clear();

            ///////////////////////////////

            foreach (Control control in panelValue1.Controls)
            {
                if (control is Label label && label.Name != "panelCountLabel")
                    labelsToRemove.Add(label);
            }

            foreach (Label label in labelsToRemove)
            {
                panelValue1.Controls.Remove(label);
                label.Dispose();
            }
            labelsToRemove.Clear();

            ///////////////////////////////

            foreach (Control control in panelType2.Controls)
            {
                if (control is Label label && label.Name != "panelTypeLabel2")
                    labelsToRemove.Add(label);
            }

            foreach (Label label in labelsToRemove)
            {
                panelType2.Controls.Remove(label);
                label.Dispose();
            }
            labelsToRemove.Clear();

            ///////////////////////////////
            foreach (Control control in panelValue2.Controls)
            {
                if (control is Label label && label.Name != "panelCountLabel2")
                    labelsToRemove.Add(label);
            }

            foreach (Label label in labelsToRemove)
            {
                panelValue2.Controls.Remove(label);
                label.Dispose();
            }
            labelsToRemove.Clear();

            ///////////////////////////////
        }

        private void existingOrderCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            clearGroupBox(panelType1, panelValue1, panelType2, panelValue2);

            try
            {
                string orderName = existingOrderCombobox.Text;
                string query = $"SELECT * FROM order_of_manufacture WHERE order_name = '{orderName}'";
                DataTable result = databaseHelper.ExecuteQuery(query);

                if (result.Rows.Count > 0)
                {
                    string stationName = result.Rows[0]["order_list"].ToString();
                    List<string> stationNames = stationName.Split(',').ToList();

                    stationNames.RemoveAll(item => item == "");

                    var groups = stationNames.GroupBy(x => x);
                    int i = 0;
                    foreach (var group in groups)
                    {     
                        if (i <= 10)
                        {
                            string panelName = group.Key;
                            int panelCount = group.Count();
                            panelType1.Controls.Add(labelDefinition(
                            panelName,
                            panelName,
                            new Font("Microsoft Sans Serif", 12),
                            new Point(10, (i * 25) + 50),
                            Color.White,
                            new Size(125, 20)));

                            panelValue1.Controls.Add(labelDefinition(
                            panelCount.ToString(),
                            panelCount.ToString(),
                            new Font("Microsoft Sans Serif", 12),
                            new Point(40, (i * 25) + 50),
                            Color.White,
                            new Size(50, 20)));
                        }
                        else
                        {
                            string panelName = group.Key;
                            int panelCount = group.Count();
                            panelType2.Controls.Add(labelDefinition(
                            panelName,
                            panelName,
                            new Font("Microsoft Sans Serif", 12),
                            new Point(40, (i*25) + 50),
                            Color.White,
                            new Size(20, 20)));

                            panelValue2.Controls.Add(labelDefinition(
                            panelCount.ToString(),
                            panelCount.ToString(),
                            new Font("Microsoft Sans Serif", 12),
                            new Point(40, (i * 25) + 50),
                            Color.White,
                            new Size(20, 20)));
                        }
                        i++;
                    }
                }
                else
                    MessageBox.Show("Kayıt bulunamadı.");

            }
            catch (Exception error)
            {
                MessageBox.Show("Bir hata oluştu." + error.Message);
            }

        }

        private void ratioCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ratioCombobox.SelectedIndex;

            switch (selectedIndex)
            {
                case 0: // 1 dk = 1 sn
                    ratio = 1000.00;
                    break;
                case 1: // 10 dk = 1 sn
                    ratio = 100;
                    break;
                case 2: // 30 dk = 1 sn
                    ratio = 33.33;
                    break;
                case 3: // 60 dk = 1 sn
                    ratio = 16.66;
                    break;
                case 4: // 120 dk = 1 sn
                    ratio = 8.33;
                    break;
                case 5: // 180 dk = 1 sn
                    ratio = 5.55;
                    break;
                case 6: // 240 dk = 1 sn
                    ratio = 4.16;
                    break;
                case 7: // 300 dk = 1 sn
                    ratio = 3.33;
                    break;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
