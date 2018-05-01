using Microsoft.Xna.Framework;
using Spenger.Components;
using Spenger.Managers;

namespace Spenger.Entities
{
    public class Player : Entity, IUpdateable, IDrawable
    {
        static Vector2 Size = new Vector2(16);
        public static float Reach { get; private set; } = 64f;

        public Player(Vector2 position)
        {
            AddComponent(new TransformComponent(position, Size));
            AddComponent(new TextureComponent(TextureManager.Textures["Player_D"]));
            AddComponent(new BasicDrawComponent());
            AddComponent(new ControlComponent());
            var inv = new InventoryComponent(30);
            AddComponent(inv);
        }
    }
}