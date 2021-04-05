using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W.King_c968
{
    public class InHousePart : Part
    {
        public int MachineID { get; set; }

        //  Constructor

    
        public InHousePart(int partID, string name, int inStock, decimal price, int max, int min, int machineID) //bool isOutsourced)
        
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price.ToString();
            Max = max;
            Min = min;
            MachineID = machineID;
            //IsOutsourced = isOutsourced;
            
        }
    }
}
    
