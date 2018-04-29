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
        public Entity Parent;
        //public Component(Entity parent)
        //{
        //    Parent = parent;
        //}
        public Component()
        {
        }
    }
}