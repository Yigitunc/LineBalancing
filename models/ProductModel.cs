using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TimeCalc.Simulation;


namespace TimeCalc.models
{
    internal class ProductModel
    {
        private static Form SimulationForm2 = new Simulation();
        private static object lockObject;
        private static Queue<string> labelUpdates;

        int productId;
        String productName;
        double productWaitTime;
        public Dictionary<StationModel, string> orderMap = new Dictionary<StationModel, string>();

        public String GetProductName() {
            return this.productName;
        }
        public ProductModel(String productName, Dictionary<StationModel, string> orderMap)
        {
            //this.productId = id;
            this.productName = productName;
            this.orderMap = orderMap;
        }
        public ProductModel()
        {

        }
        public void logger()
        {
            Console.WriteLine("**************************");
            Console.WriteLine(" - İstasyon ismi  : " + orderMap.First().Key.getStationName());
            Console.WriteLine(" - Bekleyenler sayısı : " + orderMap.First().Key.waitingProducts.Count);
            Console.WriteLine(" - İstasyondaki panel  : " + this.GetProductName());
            Console.WriteLine("**************************");
        }

        public void process()
        {
            int stationTime = (int)(double.Parse(this.orderMap.First().Value) * ratio);
            Thread.Sleep(stationTime);
            StationModel lastStation = this.orderMap.First().Key;
            this.orderMap.Remove(this.orderMap.First().Key);
            this.nextStation(lastStation);
        }
        public void nextStation(StationModel lastStation)
        {
            if (orderMap.Count() > 0)
            {
                if (lastStation.waitingProducts.Count < 1)
                {
                    lastStation.startTimer();
                }
                StationModel firstStationModel = orderMap.First().Key;
                firstStationModel.AddElementToQueueAsync(this,lastStation);
            }
            else
            {
                lastStepProduct(lastStation);
            }
        }

        public void lastStepProduct(StationModel lastStation)
        {
            SimulationForm2 = new Simulation();

            DraggableGroupBox draggableGroupBox = draggableGroupBoxList.FirstOrDefault(d => d.Name == "finishedProducts");
            if (draggableGroupBox != null)
            {
                Label targetLabel = draggableGroupBox.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "finishedProductsLabel");
                if (targetLabel != null)
                {
                    if (targetLabel.InvokeRequired)
                    {
                        targetLabel.Invoke(new Action(() => { targetLabel.Text += " ," +productName ; }));
                    }
                    else
                    {
                        targetLabel.Text +=  productName + " - ";
                    }
                }
            }
            lastStepStation(lastStation);
        }
        public void lastStepStation(StationModel lastStation)
        {
            SimulationForm2 = new Simulation();

            DraggableGroupBox draggableGroupBox = draggableGroupBoxList.FirstOrDefault(d => d.Name == lastStation.getStationName());
            if (draggableGroupBox != null)
            {
                Label targetLabel = draggableGroupBox.Controls.OfType<Label>().FirstOrDefault(l => l.Name == lastStation.getStationName() + "processValue");
                if (targetLabel != null)
                {
                    if (targetLabel.InvokeRequired)
                    {
                        targetLabel.Invoke(new Action(() => { targetLabel.Text = ""; }));
                    }
                    else
                    {
                        targetLabel.Text = "";
                    }
                }
            }
        }
        static public int x = 0;
    }
}

