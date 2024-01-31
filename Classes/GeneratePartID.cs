using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Classes
{
    public class GeneratePartID
    {
        public static int id = 0;

        public static int AutoIncrement()
        {            
            for (int i = 0; i < Inventory.AllParts.Count; i++)
            {
                if (id == Inventory.AllParts[i].PartID)
                {
                    id++;
                }               
            }            
            return id;
        }
    }
}
