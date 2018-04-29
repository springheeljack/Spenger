using Spenger.Components;
using System.Collections.Generic;
using System.Linq;

namespace Spenger.Entities
{
    public abstract class Entity
    {
        protected List<Components.Component> Components = new List<Components.Component>();
        public TransformComponent transform;
        public T GetComponent<T>() where T : Components.Component
        {
            foreach (Components.Component c in Components)
                if (c is T)
                    return c as T;
            return null;
        }
        public void AddComponent(Components.Component component)
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