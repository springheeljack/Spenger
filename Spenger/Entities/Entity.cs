using Spenger.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spenger.Entities
{
    public abstract class Entity
    {
        protected List<Component> Components = new List<Component>();
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
        }
    }
}