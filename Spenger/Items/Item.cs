using Microsoft.Xna.Framework.Graphics;

namespace Spenger.Items
{
    public enum ItemType
    {
        Coal,
        IronOre,
        IronIngot
    }

    public class Item
    {
        public Texture2D Texture { get; private set; }
        public string Name { get; private set; }
        public ItemType ItemType { get; private set; }

        public Item(string name, Texture2D texture, ItemType itemType)
        {
            Name = name;
            Texture = texture;
            ItemType = itemType;
        }
    }
}
