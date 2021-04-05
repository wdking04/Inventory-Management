using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W.King_c968
{
    public class OutsourcedPart : Part
    {
        public string CompanyName { get; set; }

        //  Constructor
      

        public OutsourcedPart(int partID, string name, int inStock, decimal price, int max, int min, string compName) //bool isOutsourced)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price.ToString();
            Max = max;
            Min = min;
            CompanyName = compName;
            //IsOutsourced = isOutsourced;
        }
    }
}

