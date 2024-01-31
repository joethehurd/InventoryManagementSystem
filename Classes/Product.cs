using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Classes
{
    public class Product
    {
        // properties
        public BindingList<Part> AssociatedParts = new BindingList<Part>();      
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; } // aka Inventory in the GUI Mock Up   
        public int Max { get; set; }
        public int Min { get; set; }

        private int productIndex;

        // functions        
        public void AddAssociatedPart(Part part)
        {            
            Inventory.Products[productIndex].AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int id)
        {            
            bool partExists = false;

            foreach (Part p in Inventory.Products[productIndex].AssociatedParts)
            {
                if (p.PartID == id)
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

        public Part LookupAssociatedPart(int id)
        {            
            bool partIsInHouse = false;
            Inhouse inHousePart = new Inhouse();
            Outsourced outsourcedPart = new Outsourced();

            foreach (Part p in Inventory.Products[productIndex].AssociatedParts)
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
        
        public void SetProductIndex(int index)
        {
            productIndex = index;
        }
    }
}
