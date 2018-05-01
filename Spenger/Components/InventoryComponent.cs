using Spenger.Items;
using System.Collections.Generic;

namespace Spenger.Components
{
    public class InventoryComponent : Component
    {
        //public Dictionary<ItemType, int> Inventory { get; private set; } = new Dictionary<ItemType, int>();
        public List<ItemStack> Inventory { get; private set; } = new List<ItemStack>();
        public int Capacity { get; private set; }
        public int Count { get { return Inventory.Count; } }
        public bool IsEmpty { get { return Inventory.Count == 0; } }

        public InventoryComponent(int capacity)
        {
            Capacity = capacity;
        }
        public void Add(ItemStack itemStack)
        {
            foreach(ItemStack i in Inventory)
            {
                i.Add(itemStack);
                if (itemStack.Count == 0)
                    return;
            }
            Inventory.Add(itemStack);
        }

        //public void AddItem(ItemType itemType)
        //{
        //    if (Inventory.ContainsKey(itemType))
        //        Inventory[itemType]++;
        //    else
        //        Inventory.Add(itemType, 1);
        //}

        //public bool CanAddItem(ItemType itemType)
        //{

        //}

        //public void RemoveItem(ItemType itemType)
        //{
        //    if (Inventory.ContainsKey(itemType))
        //    {
        //        Inventory[itemType]--;
        //        if (Inventory[itemType] == 0)
        //            Inventory.Remove(itemType);
        //    }
        //    else
        //        throw new Exception("Item to be removed is not present in inventory.");
        //}

        //public int ItemCount(ItemType itemType)
        //{
        //    if (Inventory.ContainsKey(itemType))
        //        return Inventory[itemType];
        //    else
        //        return 0;
        //}

        //public int ItemTypeCount
        //{
        //    get
        //    {
        //        return Inventory.Count;
        //    }
        //}

        //public int TotalItemCount
        //{
        //    get
        //    {
        //        int total = 0;
        //        foreach (var i in Inventory)
        //        {
        //            total += i.Value;
        //        }
        //        return total;
        //    }
        //}
    }
}