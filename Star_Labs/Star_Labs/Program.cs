using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Basket basket = new Basket();

            string name = "Marvel";
            string size = "m";
            Shirts tshirt = new Tshirt(name, size);
            basket.Shirts.Add(tshirt);

            name = "Polo";
            size = "s";
            Shirts golfer = new Golfer(name, size);
            basket.Shirts.Add(golfer);

            name = "Levi";
            size = "m";
            Pants jeans = new Jeans(name, size);
            basket.Pants.Add(jeans);

            name = "Fabio";
            size = "l";
            Pants fp = new FormalPants(name, size);
            basket.Pants.Add(fp);

            Console.WriteLine($"Your total price is R{basket.getTotalPrice()}");
            Console.ReadLine();
         
        }
    }
}
