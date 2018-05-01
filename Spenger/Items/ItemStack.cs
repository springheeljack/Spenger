namespace Spenger.Items
{
    public class ItemStack
    {
        public static int MaxSize { get; private set; } = 10;
        public ItemType ItemType { get; private set; }
        public int Count { get; private set; }
        public bool IsEmpty { get { return Count == 0; } }
        public ItemStack(ItemType itemType, int count)
        {
            ItemType = itemType;
            Count = count;
        }
        public void Add(ItemStack itemStack)
        {
            if (ItemType == itemStack.ItemType)
            {
                Count += itemStack.Count;
                itemStack.Count = 0;
                if (Count>MaxSize)
                {
                    int remainder = Count - MaxSize;
                    Count = MaxSize;
                    itemStack.Count = remainder;
                }
            }
        }
    }
}
