

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W.King_c968
{
    public abstract class Part
    {

        public int PartID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }

        private double price;
        public string Price
        {
            get { return price.ToString("C"); }
            set
            {
                if (value.StartsWith("$"))
                {
                    price = double.Parse(value.Substring(1));
                }
                else
                {
                    price = double.Parse(value);
                }

            }
        }

        
        public int Max { get; set; }
        public int Min { get; set; }
        //public bool IsOutsourced { get; set; }
    }
}