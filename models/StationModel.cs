using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TimeCalc.Simulation;

namespace TimeCalc.models
{
    internal class StationModel 
    {
        int stationId;
        String stationName;
        String stationTime;
        public Queue<ProductModel> waitingProducts;
        ProductModel current_panel;

        public StationModel(String stationName) {
            this.stationName = stationName; 
            waitingProducts = new Queue<ProductModel>();
        }

        public int getStationId() {  return stationId; }
        public String getStationName() {  return stationName; }
        public String getStationTime() {  return stationTime; }
        public void setStationTime(string stationTime) {  this.stationTime = stationTime; }

        public event ComboBoxValueDelegate ComboBoxValueChanged;

        public void firstStart()
        {
            if (waitingProducts.Count > 0)
            {
                Simulation simulationForm = new Simulation();
                current_panel = waitingProducts.Peek();
                DraggableGroupBox draggableGroupBox = draggableGroupBoxList.FirstOrDefault(d => d.Name == stationName);
                if (draggableGroupBox != null)
                {
                    Label targetLabel = draggableGroupBox.Controls.OfType<Label>().FirstOrDefault(l => l.Name == stationName + "processValue");
                    if (targetLabel != null)
                    {
                        targetLabel.Text = this.current_panel.GetProductName();
                    }
                }
            }

        }
        public void startProcess()
        {
            if (waitingProducts.Count > 0)
            {
                current_panel = waitingProducts.Dequeue();

                Thread thread = new Thread(this.current_panel.process);
                Console.WriteLine("--------------"+stationName+" ");
                thread.Start();
                int stationTime = (int)(double.Parse(current_panel.orderMap[this]) * ratio);
                Thread.Sleep(stationTime);
                Console.Write("***************");
            }
        }

    }
}
