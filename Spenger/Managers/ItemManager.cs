using Microsoft.Xna.Framework.Graphics;
using Spenger.Items;
using System.Collections.Generic;

namespace Spenger.Managers
{
    public static class ItemManager
    {
        static Dictionary<ItemType, Item> Dict = new Dictionary<ItemType, Item>();
        public static void Initialize()
        {
            AddNewItem(ItemType.Coal, "Coal", TextureManager.Textures["Coal"]);
            AddNewItem(ItemType.IronOre, "Iron Ore", TextureManager.Textures["IronOre"]);
        }
        static void AddNewItem(ItemType itemType,string name, Texture2D texture)
        {
            Dict.Add(itemType, new Item(name, texture, itemType));
        }
        public static Item GetItem(ItemType itemType)
        {
            return Dict[itemType];
        }
    }
}
