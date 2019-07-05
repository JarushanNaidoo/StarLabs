using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Clothes
{
    protected string name;
    protected string size;
    protected Dictionary<string, int> price = new Dictionary();

    public abstract void Prices(Dictionary<string, int> price);
    
}
