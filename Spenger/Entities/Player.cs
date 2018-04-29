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
            AddComponent(new TransformComponent(position, new Vector2(32)));
            AddComponent(new TextureComponent(TextureManager.Textures["Player"]));
            AddComponent(new BasicDrawComponent());
            AddComponent(new ControlComponent());
        }
    }
}