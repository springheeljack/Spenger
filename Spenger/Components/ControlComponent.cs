using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spenger.Entities;

namespace Spenger.Components
{
    public class ControlComponent : Component, IUpdateableComponent
    {
        public ControlComponent(Entity parent) : base(parent)
        {
        }

        public void Update()
        {
            TransformComponent tc = Parent.GetComponent(TransformComponent);
        }
    }
}
