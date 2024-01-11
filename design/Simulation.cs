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
using System.Collections.Concurrent;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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
        int commaCount = 0;
        
        private void LabelTextChangedEventHandler(object sender, EventArgs e)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();

            string labelText = finishedProductsLabel.Text;

            int commaCount = labelText.Count(c => c == ',');
            finishedPanelCount.Text = (commaCount).ToString();
            List<string> stringList = finishedProductsLabel.Text.Split(',').ToList();
            string lastElement = stringList[stringList.Count - 1];

            foreach (Label label in finishedPanelNames.Controls)
            {
                string labelname = label.Text;
                if (labelname == lastElement)
                {
                    foreach (Label count in finishedProductsCount.Controls)
                    {
                        if (count.Name == label.Text + "count")
                        {
                            if (count.Text == "" || count.Text == " ")
                            {
                                count.Text = "0".ToString();   
                            }
                            int oldCount = int.Parse(count.Text);
                            count.Text = (1 + oldCount).ToString();
                        }
                    }
                }
            }

            if (commaCount == panelCount && commaCount != 0)
            {
                Cursor newCursor = Cursors.Default;
                timer1.Stop();
                foreach (var item in allStationsList)
                {
                    item.stopTimer();
                }
                float totalTime = 1.00f;
                float clockValue = float.Parse(clock.Text);
                seconds = 0;
                milliseconds = 0;
                switch (ratioCombobox.SelectedIndex)
                {
                    case 0: // 1 DK = 10 SN
                        totalTime = clockValue / 10 ;
                        break;
                    case 1: // 1 DK = 5 SN
                        totalTime = clockValue / 5;
                        break;
                    case 2: // 1 dk = 1 sn                       
                        totalTime = clockValue;
                        break;
                    case 3: // 5 dk = 1 sn                       
                        totalTime = clockValue * 5;
                        break;
                    case 4: // 10 dk = 1 sn
                        totalTime = clockValue * 10;
                        break;
                    case 5: // 30 dk = 1 sn
                        totalTime = clockValue * 30;
                        break;
                    case 6: // 60 dk = 1 sn
                        totalTime = clockValue * 60;
                        break;
                    case 7: // 120 dk = 1 sn
                        totalTime = clockValue * 120;
                        break;
                    case 8: // 180 dk = 1 sn
                        totalTime = clockValue * 180;
                        break;
                    case 9: // 240 dk = 1 sn
                        totalTime = clockValue * 240;
                        break;
                    case 10: // 300 dk = 1 sn
                        totalTime = clockValue * 300;
                        break;

                }


                string query = $"UPDATE order_of_manufacture SET order_time = '{totalTime/10}' WHERE order_name = '{existingOrderCombobox.Text}'";
                databaseHelper.ExecuteNonQuery(query);

                foreach (Control control in this.Controls)
                {
                    if (control is Button)
                    {
                        control.Cursor = newCursor;
                        control.Enabled = true;
                    }
                }
            }
        }

        static List<StationModel> allStationsList = new List<StationModel>();

        private void Grafikler_Load(object sender, EventArgs e)
		{
            finishedProductsLabel.TextChanged += LabelTextChangedEventHandler;

            ratioCombobox.SelectedIndex = 2;
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

                    draggableGroupBoxList.Add(finishedProducts);
                    this.Controls.Add(finishedProducts);
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
        private System.Windows.Forms.Timer timer1;


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
            draggableGroupBox.Size = new Size(270, 115);

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

            if (textboxValue.Contains("BEKLEME"))
            {

                draggableGroupBox.Controls.Add(labelDefinition(
                "onProcessLabel",
                "İŞLEMDE",
                new Font("Microsoft Sans Serif", 11),
                new Point(100, 42),
                Color.Green,
                new Size(73, 20)));



                draggableGroupBox.Controls.Add(labelDefinition(
               textboxValue + "processValue",
               "",
               new Font("Microsoft Sans Serif", 11),
               new Point(5, 68),
               Color.White,
               new Size(200, 20)));

                draggableGroupBox.Controls.Add(labelDefinition(
                textboxValue + "waitingList",
                "",
                new Font("Microsoft Sans Serif", 10),
                new Point(250, 68),
                Color.White,
                new Size(10, 10)));

            }
            else {
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
               textboxValue + "processValue",
               "",
               new Font("Microsoft Sans Serif", 11),
               new Point(5, 68),
               Color.White,
               new Size(105, 20)));

                draggableGroupBox.Controls.Add(labelDefinition(
                textboxValue + "waitingList",
                "",
                new Font("Microsoft Sans Serif", 10),
                new Point(115, 68),
                Color.White,
                new Size(150, 20)));

                draggableGroupBox.Controls.Add(labelDefinition(
                textboxValue + "bostakiSüre",
                "Boştaki Süre :",
                new Font("Microsoft Sans Serif", 11),
                new Point(5, 89),
                Color.White,
                new Size(110, 20)));

                draggableGroupBox.Controls.Add(labelDefinition(
                textboxValue + "timer",
                "0",
                new Font("Microsoft Sans Serif", 11),
                new Point(120, 89),
                Color.White,
                new Size(40, 20)));
            }
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
                tooltip.Show(labelname.Text, labelname, labelname.Location.X-140 + labelname.Width, labelname.Location.Y-50);
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

        private static int panelCount = 0;
        private async void button1_Click(object sender, EventArgs e)
        {

            if (existingOrderCombobox.Text == "" || existingOrderCombobox.Text == " ")
            {
                MessageBox.Show("Üretim sırasını seçiniz.");
            }
            else
            {

                foreach (var item in allStationsList)
                {
                    item.resetTimer();
                }

                finishedProductsLabel.Text = "0";
                counter = 1;
                timer1 = new System.Windows.Forms.Timer();
                timer1.Tick += timer1_Tick;
                timer1.Dispose();
                //timer1.Interval = 1000;
                timer1.Start();
                clock.Text = "0";
                clearGroupBox2(finishedPanelNames, finishedProductsCount, finishedPanelNames2, finishedProductsCount2);


                DatabaseHelper databaseHelper = new DatabaseHelper();
                string query = $"SELECT order_list FROM order_of_manufacture where order_name = '{existingOrderCombobox.Text}'";
                DataTable result = databaseHelper.ExecuteQuery(query);

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
                            orderMap.Add(newStationModel, productRouteTimeList[y]);
                            if (newStationModel.getStationName() != "")
                            {
                                y++;
                            }
                        }

                        //ProductModel product = new ProductModel(item + "-" + i.ToString(), orderMap);
                        ProductModel product = new ProductModel(item, orderMap);
                        orderMap.Keys.First().waitingProducts.Enqueue(product);
                        //orderManufacture.Add(item + "-" + i.ToString());
                        orderManufacture.Add(item );
                        i++;
                    }
                    panelCount = i;

                    Cursor newCursor = Cursors.No;

                    foreach (Control control in this.Controls)
                    {
                        if (control is Button)
                        {
                            if (control.Name != "button1")
                            {
                                control.Cursor = newCursor;
                                control.Enabled = false;
                            }
  
                        }
                    }
                    int t = 0;
                    List<string> distinctList = stationNames.Distinct().ToList();

                    foreach (var group in distinctList)
                    {
                        if (t <= 10)
                        {
                            string panelName = group;
                            finishedPanelNames.Controls.Add(labelDefinition(
                            panelName,
                            panelName,
                            new Font("Microsoft Sans Serif", 12),
                            new Point(10, (t * 25) + 50),
                            Color.White,
                            new Size(125, 20)));

                            finishedProductsCount.Controls.Add(labelDefinition(
                            panelName + "count",
                            "0",
                            new Font("Microsoft Sans Serif", 12),
                            new Point(40, (t * 25) + 50),
                            Color.White,
                            new Size(50, 20)));
                        }
                        else
                        {
                            string panelName = group;
                            finishedPanelNames.Controls.Add(labelDefinition(
                            panelName,
                            panelName,
                            new Font("Microsoft Sans Serif", 12),
                            new Point(10, (t * 25) + 50),
                            Color.White,
                            new Size(125, 20)));

                            finishedProductsCount.Controls.Add(labelDefinition(
                            panelName + "count",
                            "0",
                            new Font("Microsoft Sans Serif", 12),
                            new Point(40, (t * 25) + 50),
                            Color.White,
                            new Size(50, 20)));
                        }
                        t++;
                    }
                    foreach (var item in allStationsList)
                    {
                        item.startTimer();
                    }

                    List<Task> tasks = new List<Task>();
                    foreach (var item in allStationsList)
                    {
                        Task task = Task.Run(() =>
                        {
                            item.firstStartProcess();
                        });
                        tasks.Add(task);
                    }

                    await Task.WhenAll(tasks);
                   
                }
            }

        }
        private int seconds = 0;
        private int milliseconds = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter <= 999999999)
            {
                milliseconds++;

                if (milliseconds >= 10)
                {
                    milliseconds = 0;
                    seconds++;
                }

                clock.Text = string.Format("{0}.{1:0}", seconds, milliseconds);
            }
        
            else
            {
                timer1.Stop();
            }
        }
        private void timer_Tick(object sender, EventArgs e, Label clock)
        {
            if (counter <= 999999999)
            {
                milliseconds++;

                if (milliseconds >= 10)
                {
                    milliseconds = 0;
                    seconds++;
                }

                clock.Text = string.Format("{0}.{1:0}", seconds, milliseconds);
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

        private void clearGroupBox2(System.Windows.Forms.GroupBox panelType1, System.Windows.Forms.GroupBox panelValue1, System.Windows.Forms.GroupBox panelType2, System.Windows.Forms.GroupBox panelValue2)
        {
            List<Label> labelsToRemove = new List<Label>();

            foreach (Control control in panelType1.Controls)
            {
                if (control is Label label && label.Name != "panelTypeLabel11")
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
                if (control is Label label && label.Name != "panelCountLabel11")
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
                if (control is Label label && label.Name != "panelTypeLabel22")
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
                if (control is Label label && label.Name != "panelCountLabel22")
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
        public static int totalPanelCount = 0;
        List<string> stationNames = new List<string>();
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
                    stationNames.Clear();
                    string stationName = result.Rows[0]["order_list"].ToString();
                    stationNames = stationName.Split(',').ToList();

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
                            totalPanelCount += panelCount;
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
                case 0: // 1 DK = 10 SN
                    ratio = 10000.00;
                    break;
                case 1: // 1 DK = 5 SN
                    ratio = 5000.00;
                    break;
                case 2: // 1 dk = 1 sn                       
                    ratio = 1000.00;
                    break;
                case 3: // 5 dk = 1 sn                       
                    ratio = 200.00;
                    break;
                case 4: // 10 dk = 1 sn
                    ratio = 100.10;
                    break;
                case 5: // 30 dk = 1 sn
                    ratio = 33.333333333333333333333333333333333333333333;
                    break;
                case 6: // 60 dk = 1 sn
                    ratio = 16.66666666666667;
                    break;
                case 7: // 120 dk = 1 sn
                    ratio = 8.333333333333;
                    break;
                case 8: // 180 dk = 1 sn
                    ratio = 5.5555555555555;
                    break;
                case 9: // 240 dk = 1 sn
                    ratio = 4.16666666666666;
                    break;
                case 10: // 300 dk = 1 sn
                    ratio = 3.33333333333333333333;
                    break;
               
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void paneller_Enter(object sender, EventArgs e)
        {

        }

        private void finishedProductsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
