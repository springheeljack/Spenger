using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spenger.Components
{
    public class InventoryComponent : Component
    {
        public Dictionary<ItemType, int> Inventory { get; private set; } = new Dictionary<ItemType, int>();

        public void AddItem(ItemType itemType)
        {
            if (Inventory.ContainsKey(itemType))
                Inventory[itemType]++;
            else
                Inventory.Add(itemType, 1);
        }

        public void RemoveItem(ItemType itemType)
        {
            if (Inventory.ContainsKey(itemType))
            {
                Inventory[itemType]--;
                if (Inventory[itemType] == 0)
                    Inventory.Remove(itemType);
            }
            else
                throw new Exception("Item to be removed is not present in inventory.");
        }

        public int ItemCount(ItemType itemType)
        {
            if (Inventory.ContainsKey(itemType))
                return Inventory[itemType];
            else
                return 0;
        }

        public int ItemTypeCount
        {
            get
            {
                return Inventory.Count;
            }
        }

        public int TotalItemCount
        {
            get
            {
                int total = 0;
                foreach (var i in Inventory)
                {
                    total += i.Value;
                }
                return total;
            }
        }
    }
}