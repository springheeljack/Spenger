using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Spenger.Components;
using Spenger.Entities;
using Spenger.Entities.ResourceNodes;
using Spenger.Entities.Storage;
using Spenger.Extensions;
using Spenger.Items;
using System;
using System.Collections.Generic;

namespace Spenger.Managers
{
    public static class UIManager
    {
        static Player Player;
        static float ZoomLevel = 2.5f;
        public static Entity HoveredEntity { get; set; } = null;
        public static Entity SelectedEntity { get; set; } = null;
        public static bool HoveredInRange { private get; set; } = false;
        public static bool SelectedInRange { private get; set; } = false;
        static Vector2 PlayerInventoryPosition = new Vector2(100);
        static Vector2 OtherInventoryPosition = new Vector2(800, 100);
        static Vector2 FPSPosition = new Vector2(10);
        static Color Transparent = new Color(1f, 1f, 1f, 0.5f);
        static Color HoveredInRangeColor = Color.Yellow;
        static Color HoveredOutRangeColor = Color.Red;
        static Color SelectedInRangeColor = Color.Lime;
        static Color SelectedOutRangeColor = new Color(255,127,0);
        static int TileWidth = 16;
        static int Columns = 10;

        public static void Initialize(Player player)
        {
            Player = player;
        }

        public static void Update()
        {
            if (Player.GetComponent<ControlComponent>().IsInventoryOpen && InventoryRectangle(Player.GetComponent<InventoryComponent>(), PlayerInventoryPosition).Intersects(InputManager.MouseRectangle))
            {
                if (InputManager.IsButtonHit(MouseButtons.Left))
                {
                    if (InputManager.IsKeyDown(Keys.LeftShift))
                    {

                    }
                }
            }
            else
            {

                //Hover and selection
                HoveredEntity = null;
                HoveredInRange = false;
                foreach (Entity e in EntityManager.Entities)
                {
                    SelectComponent select = e.GetComponent<SelectComponent>();
                    if (select != null)
                    {
                        var pos = Global.camera.CalculateDrawingPosition(select.Parent.transform.Position);
                        if (InputManager.CurrentMouseState.Position.Intersects(pos, select.Parent.transform.Size * Global.camera.CameraComponent.ZoomLevel))
                        {
                            HoveredEntity = e;
                            if (e.transform.Position.Distance(Global.player.transform.Position) <= Player.Reach)
                                HoveredInRange = true;
                            break;
                        }
                    }
                }

                if (InputManager.IsButtonHit(MouseButtons.Left))
                {

                    SelectedEntity = null;
                    if (HoveredEntity != null)
                    {
                        SelectedEntity = HoveredEntity;
                        HoveredEntity = null;
                    }

                }

                if (SelectedEntity != null)
                {
                    if (SelectedEntity == HoveredEntity)
                        HoveredEntity = null;

                    SelectedInRange = SelectedEntity.transform.Position.Distance(Global.player.transform.Position) <= Player.Reach;
                }

                if (InputManager.IsButtonHit(MouseButtons.Right))
                    if (HoveredInRange == true)
                        if (HoveredEntity is ResourceNode)
                        {
                            Player.GetComponent<InventoryComponent>().Add(new ItemStack(HoveredEntity.GetComponent<ResourceNodeComponent>().Item, 1));
                        }
            }
        }

        public static void Draw()
        {
            //FPS
            Global.spriteBatch.DrawShadowedString(TextureManager.MediumFont, Math.Round((1.0 / Game.AverageFrameTime), 2).ToString(), FPSPosition, Color.Red);

            //Hover and selection
            if (HoveredEntity != null)
            {
                var pos = Global.camera.CalculateDrawingPosition(HoveredEntity.transform.Position);
                Global.spriteBatch.Draw(TextureManager.Textures["Reticle"], pos, null, HoveredInRange ? HoveredInRangeColor : HoveredOutRangeColor, 0, Vector2.Zero, Global.camera.CameraComponent.ZoomLevel, SpriteEffects.None, 0);
                var textOffset = new Vector2(0, TileWidth * Global.camera.CameraComponent.ZoomLevel);
                Global.spriteBatch.DrawShadowedString(TextureManager.SmallFont, HoveredEntity.GetComponent<SelectComponent>().Name, pos + textOffset, HoveredInRange ? HoveredInRangeColor : HoveredOutRangeColor);
            }
            if (SelectedEntity != null)
            {
                var pos = Global.camera.CalculateDrawingPosition(SelectedEntity.transform.Position);
                Global.spriteBatch.Draw(TextureManager.Textures["Reticle"], pos, null, SelectedInRange ? SelectedInRangeColor : SelectedOutRangeColor, 0, Vector2.Zero, Global.camera.CameraComponent.ZoomLevel, SpriteEffects.None, 0);
                var textOffset = new Vector2(0, TileWidth * Global.camera.CameraComponent.ZoomLevel);
                Global.spriteBatch.DrawShadowedString(TextureManager.SmallFont, SelectedEntity.GetComponent<SelectComponent>().Name, pos + textOffset, SelectedInRange ? SelectedInRangeColor : SelectedOutRangeColor);
            }

            //Inventory
            ControlComponent control = Player.GetComponent<ControlComponent>();
            if (control.IsInventoryOpen)
                DrawInventory(Player.GetComponent<InventoryComponent>(), PlayerInventoryPosition);

            if (SelectedEntity is Storage)
                if (SelectedInRange)
                    DrawInventory(SelectedEntity.GetComponent<InventoryComponent>(), OtherInventoryPosition);
        }

        static void DrawInventory(InventoryComponent inventory, Vector2 position)
        {
            List<ItemStack> list = inventory.Inventory;

            for (int i = 0; i < inventory.Capacity; i++)
            {
                Vector2 pos = new Vector2(i % Columns, i / Columns);
                pos *= TileWidth * ZoomLevel;
                pos += position;
                Global.spriteBatch.Draw(TextureManager.Textures["ItemSlot"], pos, null, Color.White, 0, Vector2.Zero, ZoomLevel, SpriteEffects.None, 0);
                if (i < inventory.Count)
                {
                    Global.spriteBatch.Draw(ItemManager.GetItem(list[i].ItemType).Texture, pos, null, Color.White, 0, Vector2.Zero, ZoomLevel, SpriteEffects.None, 0);
                    pos += new Vector2(ZoomLevel * 2);
                    Global.spriteBatch.DrawShadowedString(TextureManager.SmallFont, list[i].Count.ToString(), pos, Color.White);
                }
            }

            Rectangle inventoryRectangle = InventoryRectangle(inventory, position);
            if (inventoryRectangle.Intersects(InputManager.MouseRectangle))
            {
                Vector2 mousePos = InputManager.MouseRectangle.Location.ToVector2();
                Vector2 pos = mousePos;
                pos -= position;
                pos.X %= TileWidth * ZoomLevel;
                pos.Y %= TileWidth * ZoomLevel;
                pos = mousePos - pos;
                Global.spriteBatch.Draw(TextureManager.Textures["16xSquare"], pos, null, Transparent, 0, Vector2.Zero, ZoomLevel, SpriteEffects.None, 0);
            }
        }

        static Rectangle InventoryRectangle(InventoryComponent inventory, Vector2 position)
        {
            return new Rectangle(position.ToPoint(), new Vector2(TileWidth * Columns * ZoomLevel, TileWidth * (inventory.Capacity / Columns) * ZoomLevel).ToPoint());
        }
    }
}