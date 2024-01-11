using HatDengelemeProject.operations;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TimeCalc.Simulation;

namespace TimeCalc.models
{
    internal class StationModel : BaseThread
    {
        private static Form SimulationForm = new Simulation();
        private bool isLock = false;
        private bool isRunning = false;
        private bool isLockedList = false;
        private object lockObject = new object(); 

        public event ComboBoxValueDelegate ComboBoxValueChanged;

        int stationId;
        String stationName;
        String stationTime;
        public ConcurrentQueue<ProductModel> waitingProducts ;

        ProductModel current_panel;
        Thread thread;

        public StationModel (String stationName) {
            this.stationName = stationName;
            thread = new Thread(Start);
            waitingProducts = new ConcurrentQueue<ProductModel>();
            timer = new System.Timers.Timer();

            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }
        public void startTimer()
        {
            timer.Start();
        }
        public void stopTimer()
        {
            timer.Stop();
        }
        public void resetTimer()
        {
            DraggableGroupBox draggableGroupBox2 = draggableGroupBoxList.FirstOrDefault(d => d.Name == stationName);
            if (draggableGroupBox2 != null)
            {
                Label targetLabel = draggableGroupBox2.Controls.OfType<Label>().FirstOrDefault(l => l.Name == stationName + "timer");
                if (targetLabel != null)
                {
                    if (targetLabel.InvokeRequired)
                    {
                        targetLabel.Invoke(new Action(() =>
                        {
                            targetLabel.Text = "0";
                        }));
                    }
                    else
                    {
                        targetLabel.Text = "0";
                    }
                }
            }
        }
        public void Start() {
        }

        public int getStationId() {  return stationId; }
        public String getStationName() {  return stationName; }
        public String getStationTime() {  return stationTime; }
        public void setStationTime(string stationTime) {  this.stationTime = stationTime; }

        public async void AddElementToQueueAsync(ProductModel productModel, StationModel lastStation)
        {
            if (stationName.Contains("BEKLEME"))
            {
                Task.Run(() => startProcess());
            }
            if (this.waitingProducts.Count == 0)
            {
                emptyWaitingList();
                EnqueueProduct(productModel);
                addWaitingList();
                Console.WriteLine("---------------------------------");

                Task.Run(() => startProcess());

            }

            else
            {
                Console.WriteLine("---------------------------------");

                EnqueueProduct(productModel);
                addWaitingList();
            }
        }
        public void updateProcessValue(ProductModel currentProduct)
        {
            Acquire();
            if (this.waitingProducts.Count >= 0)
            {
                SimulationForm = new Simulation();

                DraggableGroupBox draggableGroupBox = draggableGroupBoxList.FirstOrDefault(d => d.Name == stationName);
                if (draggableGroupBox != null)
                {

                    Label targetLabel = draggableGroupBox.Controls.OfType<Label>().FirstOrDefault(l => l.Name == stationName + "processValue");
                    if (targetLabel != null)
                    {
                        if (targetLabel.InvokeRequired)
                        {
                            targetLabel.Invoke(new Action(() => { targetLabel.Text = currentProduct.GetProductName(); }));
                        }
                        else
                        {
                            targetLabel.Text = currentProduct.GetProductName();
                        }
                    }
                }
            }
            Release();
        }

        public void emptyProcessValue(StationModel lastStation, bool waitingStation)
        {
            Acquire();

            DraggableGroupBox draggableGroupBox = draggableGroupBoxList.FirstOrDefault(d => d.Name == lastStation.stationName);
            if (draggableGroupBox != null)
            {
                Label targetLabel = draggableGroupBox.Controls.OfType<Label>().FirstOrDefault(l => l.Name == lastStation.stationName + "processValue");
                if (waitingStation == true)
                {
                    string lastProducts = "";
                    string[] stationNames = targetLabel.Text.Split(',');

                    if (stationNames.Length > 1)
                    {
                        lastProducts = string.Join(",", stationNames, 1, stationNames.Length - 1);
                    }
                    if (targetLabel.InvokeRequired)
                    {
                        targetLabel.Invoke(new Action(() => { targetLabel.Text = lastProducts; }));
                    }
                    else
                    {
                        targetLabel.Text = lastProducts;
                    }
                }
                else
                {
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
            Release();
        }

        public void addWaitingList()
        {
            lock (this.waitingProducts) 
            { 
                if (this.waitingProducts.Count > 0)
                {
                    foreach (var item in this.waitingProducts)
                    {
                        SimulationForm = new Simulation();
                        ProductModel currentProduct = new ProductModel();
                        currentProduct = item;

                        DraggableGroupBox draggableGroupBox = draggableGroupBoxList.FirstOrDefault(d => d.Name == stationName);
                        if (draggableGroupBox != null)
                        {
                            Label targetLabel = draggableGroupBox.Controls.OfType<Label>().FirstOrDefault(l => l.Name == stationName + "waitingList");
                            if (targetLabel != null && !stationName.Contains("BEKLEME"))
                            {
                                String originalString = targetLabel.Text;
                                String newString = item.GetProductName();
                                if (!originalString.Contains(newString))
                                {
                                    originalString += newString + ",";
                                }

                                if (targetLabel.InvokeRequired)
                                {
                                    targetLabel.Invoke(new Action(() =>
                                    {
                                        targetLabel.Text = originalString;
                                    }));
                                }
                                else
                                {
                                    targetLabel.Text = originalString;
                                }
                            }
                        }
                    }
                }
            }
        }
        public void EnqueueProduct(ProductModel product)
        {
            waitingProducts.Enqueue(product);

            if (this.waitingProducts.Count > 0)
            {
                isRunning = true;
                timer.Stop();
                DraggableGroupBox draggableGroupBox = draggableGroupBoxList.FirstOrDefault(d => d.Name == stationName);
                if (draggableGroupBox != null)
                {

                    Label targetLabel = draggableGroupBox.Controls.OfType<Label>().FirstOrDefault(l => l.Name == stationName + "waitingList");
                    if (targetLabel != null)
                    {
                        String originalString = "";
                        foreach (var item in this.waitingProducts)
                        {
                            originalString += item.GetProductName() + ",";
                        }
                        if (targetLabel.InvokeRequired)
                        {
                            targetLabel.Invoke(new Action(() =>
                            {
                                targetLabel.Text = originalString;
                            }));
                        }
                        else
                        {
                            targetLabel.Text = originalString;
                        }
                    }

                }
            }
        }

        private System.Timers.Timer timer;

        private void Timer_Elapsed(object sender, EventArgs e)
        {
            DraggableGroupBox draggableGroupBox2 = draggableGroupBoxList.FirstOrDefault(d => d.Name == stationName);
            if (draggableGroupBox2 != null)
            {
                Label targetLabel = draggableGroupBox2.Controls.OfType<Label>().FirstOrDefault(l => l.Name == stationName + "timer");
                if (targetLabel != null)
                {
                    int oldCount = int.Parse(targetLabel.Text);

                    if (targetLabel.InvokeRequired)
                    {
                        targetLabel.Invoke(new Action(() =>
                        {
                            targetLabel.Text = (oldCount + 1).ToString();
                        }));
                    }
                    else
                    {
                        targetLabel.Text = (oldCount + 1).ToString();
                    }
                }
            }
        }

        public ProductModel DequeueProduct()
        {
            lock (lockObject)
            {
                waitingProducts.TryDequeue(out ProductModel product);

                DraggableGroupBox draggableGroupBox = draggableGroupBoxList.FirstOrDefault(d => d.Name == stationName);
                if (draggableGroupBox != null)
                {
                    Label targetLabel = draggableGroupBox.Controls.OfType<Label>().FirstOrDefault(l => l.Name == stationName + "waitingList");
                    if (targetLabel != null)
                    {
                        String originalString = "";
                        foreach (var item in this.waitingProducts)
                        {
                            originalString += item.GetProductName() + ",";
                        }
                        if (targetLabel.InvokeRequired)
                        {
                            targetLabel.Invoke(new Action(() =>
                            {
                                targetLabel.Text = originalString;
                            }));
                        }
                        else
                        {
                            targetLabel.Text = originalString;
                        }
                    }

                    Label targetLabel2 = draggableGroupBox.Controls.OfType<Label>().FirstOrDefault(l => l.Name == stationName + "processValue");

                    if (targetLabel2 != null && stationName.Contains("BEKLEME") && product != null)
                    {
                        if (targetLabel2.InvokeRequired)
                        {
                            targetLabel2.BeginInvoke(new Action(() => { targetLabel2.Text += product.GetProductName() + ","; }));
                        }
                        else
                        {
                            targetLabel2.Text += product.GetProductName() + ",";
                        }
                    }
                    else if (targetLabel2 != null && product != null)
                    {
                        if (targetLabel2.InvokeRequired)
                        {
                            targetLabel2.BeginInvoke(new Action(() => { targetLabel2.Text = product.GetProductName(); }));
                        }
                        else
                        {
                            targetLabel2.Text = product.GetProductName();
                        }
                    }
                }
                return product;
            }
        }
        public ProductModel PeekProduct()
        {
            waitingProducts.TryPeek(out ProductModel product);
            return product;
        }

        public void emptyWaitingList()
        {
            DraggableGroupBox draggableGroupBox = draggableGroupBoxList.FirstOrDefault(d => d.Name == stationName);
            if (draggableGroupBox != null)
            {
                Label targetLabel = draggableGroupBox.Controls.OfType<Label>().FirstOrDefault(l => l.Name == stationName + "waitingList");
                if (targetLabel != null)
                {
                    string newList = "";

                    if (targetLabel.InvokeRequired)
                    {
                        targetLabel.BeginInvoke(new Action(() =>
                        {
                            targetLabel.Text = newList;
                        }));
                    }
                    else
                    {
                        targetLabel.Text = newList;
                    }
                }
            }
        }
     
        public void firstStartProcess()
        {
            while (waitingProducts.Count > 0 && PeekProduct() != null && current_panel == null)
            {
                if (waitingProducts.Count > 1)
                {
                    addWaitingList();
                }
                current_panel = DequeueProduct();
                if (current_panel != null)
                    RunThread();
                current_panel = null;
            }
        }
        public void startProcess()
        {
            if (stationName.Contains("BEKLEME") && waitingProducts.Count > 0 && PeekProduct() != null)
            {
                current_panel = DequeueProduct();
                if (current_panel != null)
                    RunThread();
                current_panel = null;
            }
            while (waitingProducts.Count > 0 && PeekProduct() != null && current_panel == null)
            {
                current_panel = DequeueProduct();
                if (current_panel != null)
                    RunThread();
                current_panel = null;
            }
        }

        public void Acquire()
        {
            lock (this)
            {
                while (isLockedList)
                {
                    Monitor.Wait(this);
                }
                isLockedList = true;
            }
        }

        public void Release()
        {
            lock (this)
            {
                isLockedList = false;
                Monitor.Pulse(this);
            }
        }

        public override void RunThread()
        {
            if (stationName.Contains("BEKLEME"))
            {
                current_panel.process();
                emptyProcessValue(this, true);
            }
            else
            {
                if (current_panel != null)
                {
                    lock (current_panel)
                    {
                        current_panel.process();
                        emptyProcessValue(this, false);
                        isLock = false;
                    }
                }
            }
        }
    }
}