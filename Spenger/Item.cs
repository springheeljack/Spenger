using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spenger
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
