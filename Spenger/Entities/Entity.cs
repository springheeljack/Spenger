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
        //private Dictionary<Type, Component> Components = new Dictionary<Type, Component>();
        private List<Component> Components = new List<Component>();
        public T GetComponent<T>() where T : Component
        {
            return (T)(Components.OfType<T>());
        }
        public void AddComponent(Component component)
        {
            Components.Add(component);
        }
    }
}