using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W.King_c968
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Inventory.AddProduct(new Product(1, "Red Bicycle", 15, 11.44m, 25, 1));
            Inventory.AddProduct(new Product(2, "Yellow Bicycle", 19, 9.68m, 20, 1));
            Inventory.AddProduct(new Product(3, "Blue Bicycle", 5, 12.77m, 25, 1));





            Inventory.AddPart(new InHousePart(1, "Wheel", 15, 12.11m, 25, 5, 101 /*false)*/));
            Inventory.AddPart(new InHousePart(2, "Pedal", 11, 8.22m, 25, 5, 102 /*false)*/));
            Inventory.AddPart(new OutsourcedPart(3, "Chain", 12, 8.33m, 25, 5, "AliExpress" /*true)*/));





            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
    }
}


