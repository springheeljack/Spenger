using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speng
{
    enum ComponentType
    {
        Transform,
        Control,
        BasicDraw
    }

    public abstract class Component
    {
        public Entity Parent { get; private set; }
        public Component(Entity parent)
        {
            Parent = parent;
        }
    }

    public abstract class UComponent : Component
    {
        public UComponent(Entity parent) : base(parent) { }
        public abstract void Update();
    }

    public abstract class DComponent : Component
    {
        public DComponent(Entity parent) : base(parent) { }
        public abstract void Draw();
    }
}