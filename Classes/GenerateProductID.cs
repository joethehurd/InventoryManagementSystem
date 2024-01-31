using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Classes
{
    public class GenerateProductID
    {
        public static int id = 0;

        public static int AutoIncrement()
        {
            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                if (id == Inventory.Products[i].ProductID)
                {
                    id++;
                }
            }
            return id;
        }
    }
}
