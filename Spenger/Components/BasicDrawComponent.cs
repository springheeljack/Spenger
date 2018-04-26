using Microsoft.Xna.Framework.Graphics;
using Spenger.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spenger.Components
{
    public class BasicDrawComponent : Component, IDrawableComponent
    {
        public BasicDrawComponent(Entity parent) : base(parent) { }
        public Texture2D Texture { get; private set; }

        public void Draw()
        {

        }
    }
}