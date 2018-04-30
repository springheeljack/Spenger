using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spenger.Components;
using Spenger.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spenger.Managers
{
    public static class UIManager
    {
        static Player Player;
        static float ZoomLevel = 2.0f;

        public static void Initialize(Player player)
        {
            Player = player;
        }

        public static void Update()
        {

        }

        public static void Draw()
        {
            ControlComponent control = Player.GetComponent<ControlComponent>();
            if (control.IsInventoryOpen)
            {
                InventoryComponent inventory = Player.GetComponent<InventoryComponent>();
                List<KeyValuePair<ItemType, int>> list = inventory.Inventory.ToList();
                int i = 0;
                for (; i < inventory.ItemTypeCount; i++)
                {
                    Vector2 pos = new Vector2(i % 10, i / 10);
                    pos *= 16 * ZoomLevel;
                    pos += new Vector2(100);
                    Global.spriteBatch.Draw(TextureManager.Textures["ItemSlot"], pos, null, Color.White, 0, Vector2.Zero, ZoomLevel, SpriteEffects.None, 0);
                    Global.spriteBatch.Draw(ItemManager.GetItem(list[i].Key).Texture, pos, null, Color.White, 0, Vector2.Zero, ZoomLevel, SpriteEffects.None, 0);
                }
                int max = (i + 10) - i % 10;
                for (; i < max; i++)
                {
                    Vector2 pos = new Vector2(i % 10, i / 10);
                    pos *= 16 * ZoomLevel;
                    pos += new Vector2(100);
                    Global.spriteBatch.Draw(TextureManager.Textures["ItemSlot"], pos, null, Color.White, 0, Vector2.Zero, ZoomLevel, SpriteEffects.None, 0);
                }

                Rectangle inventoryRectangle = new Rectangle(100, 100, 160 * (int)ZoomLevel, 16 * (i / 10) * (int)ZoomLevel);
                if (inventoryRectangle.Intersects(InputManager.MouseRectangle))
                {
                    Vector2 mousePos = InputManager.MouseRectangle.Location.ToVector2();
                    Vector2 pos = mousePos;
                    pos -= new Vector2(100);
                    pos.X %= 32;
                    pos.Y %= 32;
                    pos = mousePos - pos;
                    Global.spriteBatch.Draw(TextureManager.Textures["16xSquare"], pos, null, new Color(1f, 1f, 1f, 0.5f), 0, Vector2.Zero, ZoomLevel, SpriteEffects.None, 0);
                }
            }
        }
    }
}