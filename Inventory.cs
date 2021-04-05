

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W.King_c968
{

    class Inventory
    {
        //Products
        public static BindingList<Product> prod = new BindingList<Product>();
        public static BindingList<Product> Products { get { return prod; } set { prod = value; } }//new

        //AllParts
        public static BindingList<Part> allParts = new BindingList<Part>();
        public static BindingList<Part> AllParts { get { return allParts; } set { allParts = value; } }//new


        // Products Methods
        public static void AddProduct(Product prod)
        {
            Products.Add(prod);
        }

        
        public static Product LookupProduct(int productID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == productID)
                {
                    return prod;
                }
            }
            Product emptyProd = new W.King_c968.Product();
            return emptyProd;
        }

        public static void UpdateProduct(int productID, Product updatedProd)
        {
            foreach (Product currentProd in Products)
            {
                if (currentProd.ProductID == productID)
                {
                    currentProd.Name = updatedProd.Name;
                    currentProd.InStock = updatedProd.InStock;
                    currentProd.Price = updatedProd.Price;
                    currentProd.Max = updatedProd.Max;
                    currentProd.Min = updatedProd.Min;
                    currentProd.AssociatedParts = updatedProd.AssociatedParts;
                    return;
                }
            }

        }
        //Product Constructors
        public static Product CurrentProduct { get; set; }
        public static int CurrentProductID { get; set; }
        public static int CurrentProductIndex { get; set; }

        // Parts Methods
        public static void AddPart(Part part)
        {
            allParts.Add(part);

        }

        
        public bool DeletePart(Part part)
        {
            try
            {
                allParts.Remove(part);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Part LookupPart(int partID)
        {
            foreach (Part part in allParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            Part emptyPart = null;
            return emptyPart;
        }

        public static void UpdatePart(int partID, Part updatedPart)   // New to mirror products on line 41
        {
            foreach (Part currentPart in allParts)
            {
                if (currentPart.PartID == partID)
                {
                    currentPart.Name = updatedPart.Name;
                    currentPart.InStock = updatedPart.InStock;
                    currentPart.Price = updatedPart.Price;
                    currentPart.Max = updatedPart.Max;
                    currentPart.Min = updatedPart.Min;
                    //currentPart.IsOutsourced = updatedPart.IsOutsourced;
                    return;
                }
            }

        }

        //Part Constructors      
        public static Part CurrentPart { get; set; }
        public static int CurrentPartID { get; set; }
        public static int CurrentPartIndex { get; set; }
    }
}
    