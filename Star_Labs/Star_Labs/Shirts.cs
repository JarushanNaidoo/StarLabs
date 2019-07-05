using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Labs
{
    class Shirts:Clothes//inherits from abstract clothes class
    {

        public Shirts()
        {
            Prices(price);
        }

        public override void Prices(Dictionary<string, int> price)//implments price
        {
            price["s"] = DefaultPriceList[0];
            price["m"] = DefaultPriceList[1];
            price["l"] = DefaultPriceList[2];
        }

        public void setName(string name)//mutator
        {
            this.name = name;
        }

        public void setSize(string size)//mutator
        {
            this.size = size;
        }

        public string getSize()//accessor
        {
            return size;
        }

        public int getPrice(string size)//accessor
        {
            return price[size];
        }
    }
}
