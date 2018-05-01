using Spenger.Items;

namespace Spenger.Components
{
    public class ResourceNodeComponent : Component
    {
        public ItemType Item { get; private set; }
        public int Count { get; private set; }
        public ResourceNodeComponent(ItemType item, int count)
        {
            Item = item;
            Count = count;
        }
    }
}