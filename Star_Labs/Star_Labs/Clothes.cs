using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Labs
{
    abstract class Clothes
    {
        //attributes of all clothes
        protected string name;
        protected string size;
        protected List<int> DefaultPriceList = new List<int>{10,20,30};
        protected Dictionary<string, int> price = new Dictionary<string, int>();//maps a price(value) to a unique size(key)

        public abstract void Prices(Dictionary<string, int> price);//abstract method to be implmented based on item prices

    }
}
