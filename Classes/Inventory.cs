using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Classes
{
    public class Inventory
    {
        // properties
        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static BindingList<Product> Products = new BindingList<Product>();        

        // initialize
        static Inventory()
        {           
            // create default parts
            AllParts.Add(
                new Inhouse { PartID = 0, Name = "Wheel", Price = 12.11m, InStock = 15, Max = 25, Min = 5, MachineID = 123 }
                );
            AllParts.Add(
                new Outsourced { PartID = 1, Name = "Pedal", Price = 8.22m, InStock = 11, Max = 25, Min = 5, CompanyName = "Bike Co" }
                );
            AllParts.Add(
                new Inhouse { PartID = 2, Name = "Chain", Price = 8.33m, InStock = 12, Max = 25, Min = 5, MachineID = 789 }
                );
            AllParts.Add(
                new Outsourced { PartID = 3, Name = "Seat", Price = 4.55m, InStock = 8, Max = 15, Min = 2, CompanyName = "Saddle Inc" }
                );

            // create default products
            Products.Add(
                new Product { ProductID = 0, Name = "Red Bicycle", Price = 11.44m, InStock = 15, Max = 25, Min = 1  }
                );
            Products.Add(
                new Product { ProductID = 1, Name = "Yellow Bicycle", Price = 9.66m, InStock = 19, Max = 20, Min = 1 }
                );
            Products.Add(
                new Product { ProductID = 2, Name = "Blue Bicycle", Price = 12.77m, InStock = 5, Max = 25, Min = 1, }
                );

            // associate default parts with products
            Products[0].AssociatedParts.Add(AllParts[0]);
            Products[0].AssociatedParts.Add(AllParts[0]);
            Products[0].AssociatedParts.Add(AllParts[1]);
            Products[0].AssociatedParts.Add(AllParts[1]);
            Products[0].AssociatedParts.Add(AllParts[2]);
            Products[0].AssociatedParts.Add(AllParts[3]);

            Products[1].AssociatedParts.Add(AllParts[0]);
            Products[1].AssociatedParts.Add(AllParts[0]);
            Products[1].AssociatedParts.Add(AllParts[1]);
            Products[1].AssociatedParts.Add(AllParts[1]);
            Products[1].AssociatedParts.Add(AllParts[2]);
            Products[1].AssociatedParts.Add(AllParts[3]);

            Products[2].AssociatedParts.Add(AllParts[0]);
            Products[2].AssociatedParts.Add(AllParts[0]);
            Products[2].AssociatedParts.Add(AllParts[1]);
            Products[2].AssociatedParts.Add(AllParts[1]);
            Products[2].AssociatedParts.Add(AllParts[2]);
            Products[2].AssociatedParts.Add(AllParts[3]);
        }
       
        // functions (parts)
        public static void AddPart(Part part)
        {           
            AllParts.Add(part);
        }

        public static bool DeletePart(Part part)
        {
            bool partExists = false;

            foreach(Part p in AllParts)
            {
                if (p == part)
                {
                    partExists = true;
                    break;
                }                
            }
            if (partExists)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        public static Part LookupPart(int id)
        {
            bool partIsInHouse = false;
            Inhouse inHousePart = new Inhouse();
            Outsourced outsourcedPart = new Outsourced();

            foreach (Part p in AllParts)
            {
                if (p.PartID == id)
                {
                    if (p.ToString().Contains("Inhouse"))
                    {
                        partIsInHouse = true;
                        inHousePart = (Inhouse)p;
                    }
                    else
                    {
                        partIsInHouse = false;
                        outsourcedPart = (Outsourced)p;
                    }             
                    
                    break;
                }
            }

            if (partIsInHouse == true)
            {                
                return inHousePart;
            }
            else
            {                
                return outsourcedPart;
            }                                        
        }

        public static void UpdatePart(int index, Part part)
        {
            AllParts.RemoveAt(index);
            AllParts.Insert(index, part);
        }

        // functions (products)
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public static bool RemoveProduct(int id)
        {
            bool productExists = false;

            foreach (Product p in Products)
            {
                if (p.ProductID == id)
                {
                    productExists = true;
                    break;
                }
            }
            if (productExists)
            {
                return true;
            }
            else
            {
                return false;
            }           
        }

        public static Product LookupProduct(int id)
        {            
            Product product = new Product();

            foreach (Product p in Products)
            {
                if (p.ProductID == id)
                {                    
                    product = p;
                    break;
                }
            }

            return product;           
        }

        public static void UpdateProduct(int index, Product product)
        {
            Products.RemoveAt(index);
            Products.Insert(index, product);
        }
    }
}
