using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Labs
{
    class Golfer:Shirts//inherits from Shirts class
    {

        public Golfer(string name, string size)
        {
            this.name = name;
            this.size = size;
            Prices(price);
        }

        public override void Prices(Dictionary<string, int> price)//implements price change
        {
            price["s"] = DefaultPriceList[0] * 2;
            price["m"] = DefaultPriceList[1] * 2;
            price["l"] = DefaultPriceList[2] * 2;
        }

    }
}
