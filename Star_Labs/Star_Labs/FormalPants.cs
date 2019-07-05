using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Labs
{
    class FormalPants:Pants//inherits from Pants class
    {
        public FormalPants(string name, string size)
        {
            this.name = name;
            this.size = size;
            Prices(price);
        }

        public override void Prices(Dictionary<string, int> price)//implments price change
        {
            price["s"] = DefaultPriceList[0] + 30;
            price["m"] = DefaultPriceList[1] + 30;
            price["l"] = DefaultPriceList[2] + 30;
        }
    }
}
