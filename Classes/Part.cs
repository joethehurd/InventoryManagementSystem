using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Classes
{
    public abstract class Part
    {
        // properties
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; } // aka Inventory in the GUI Mock Up        
        public int Max { get; set; }
        public int Min { get; set; }
    }
}
