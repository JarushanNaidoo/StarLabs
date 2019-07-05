using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Labs
{
    class Basket
    {
        public Basket()
        {

        }

        public List<Shirts> Shirts = new List<Shirts>();
        public List<Pants> Pants = new List<Pants>();

        public int ShirtTotal()//returns total price from shirts list
        {
            int total = 0;

            for (int i =0; i< Shirts.Count; i++)
            {
                total += Shirts[i].getPrice(Shirts[i].getSize());
            }

            return total;
        }

        public int PantsTotal()//returns total price from pants list
        {
            int total = 0;

            for (int i = 0; i < Shirts.Count; i++)
            {
                total += Pants[i].getPrice(Pants[i].getSize());
            }

            return total;
        }

        public int getTotalPrice()//returns total price of items in basket
        {
            return ShirtTotal() + PantsTotal();
        }
    }
}
