using Microsoft.Xna.Framework;
using Spenger.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public TransformComponent(Entity parent,Vector2 position,Vector2 size) : base(parent)
        {
            Position = position;
            Size = size;
        }
    }
}