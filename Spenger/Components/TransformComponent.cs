using Microsoft.Xna.Framework;

namespace Spenger.Components
{
    public class TransformComponent : Component
    {
        public Vector2 Position;
        public Vector2 Size;
        public Rectangle Rectangle
        {
            get { return new Rectangle(Position.ToPoint(), Size.ToPoint()); }
        }
        public TransformComponent(Vector2 position, Vector2 size)
        {
            Position = position;
            Size = size;
        }
    }
}