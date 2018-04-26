using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speng.Components
{
    public class BasicDrawComponent : DComponent
    {
        public BasicDrawComponent(Entity parent) : base(parent) { }
        public Texture2D Texture { get; private set; }
        public override void Draw()
        {

        }
    }
}