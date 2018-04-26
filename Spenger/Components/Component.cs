using Spenger.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spenger.Components
{
    public abstract class Component
    {
        public Entity Parent { get; private set; }
        public Component(Entity parent)
        {
            Parent = parent;
        }
    }

    //public abstract class UpdateableComponent : Component
    //{
    //    public UpdateableComponent(Entity parent) : base(parent) { }
    //    public abstract void Update();
    //}

    //public abstract class DrawableComponent : Component
    //{
    //    public DrawableComponent(Entity parent) : base(parent) { }
    //    public abstract void Draw();
    //}
}