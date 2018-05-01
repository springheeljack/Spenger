using Spenger.Components;
using System.Collections.Generic;
using System.Linq;

namespace Spenger.Entities
{
    public abstract class Entity
    {
        protected List<Component> Components = new List<Component>();
        public TransformComponent transform;
        //public string Name { get; private set; } = "No name set";

        public T GetComponent<T>() where T : Component
        {
            foreach (Component c in Components)
                if (c is T)
                    return c as T;
            return null;
        }
        public void AddComponent(Component component)
        {
            component.Parent = this;
            Components.Add(component);
            if (component is TransformComponent)
                transform = component as TransformComponent;
        }
        public void Update()
        {
            foreach (IUpdateableComponent u in Components.OfType<IUpdateableComponent>())
            {
                u.Update();
            }
        }

        public void Draw()
        {
            foreach (IDrawableComponent d in Components.OfType<IDrawableComponent>())
            {
                d.Draw();
            }
        }
    }
}