using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimeCalc.models
{
    internal class ProductModel
    {
        int productId;
        String productName;
        double productWaitTime;
        public Dictionary<StationModel, string> orderMap = new Dictionary<StationModel, string>();

        //List<StationModel> productRoute;   
        //List<String> productRouteTimes;
        public String GetProductName() {
            return this.productName;
        }
        public ProductModel(String productName, Dictionary<StationModel, string>orderMap)
        {
            //this.productId = id;
            this.productName = productName;
            this.orderMap = orderMap;
        }
        public void process()
        {
            Console.WriteLine(productName+" product is running on thread of .");
        }

    }
}
