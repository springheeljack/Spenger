using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speng
{
    public abstract class Entity
    {
        private Dictionary<ComponentType, Component> Components;
    }
}