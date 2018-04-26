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
        private Dictionary<Type, Component> Components = new Dictionary<Type, Component>();
        public T GetComponent<T>()
        {
            return Components[T];
        }
        public void AddComponent(EComponentType EComponentType, Component component)
        {
            Components.Add(EComponentType, component);
        }
    }
}