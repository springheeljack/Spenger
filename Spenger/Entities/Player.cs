using Microsoft.Xna.Framework;
using Spenger.Components;
using Spenger.Managers;
using System.Linq;

namespace Spenger.Entities
{
    public class Player : Entity, IUpdateable, IDrawable
    {
        static Vector2 Size = new Vector2(16);

        public Player(Vector2 position)
        {
            AddComponent(new TransformComponent(position, Size));
            AddComponent(new TextureComponent(TextureManager.Textures["Player_D"]));
            AddComponent(new BasicDrawComponent());
            AddComponent(new ControlComponent());
            var inv = new InventoryComponent();
            inv.AddItem(ItemType.Coal);
            AddComponent(inv);
        }
    }
}