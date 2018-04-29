using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Speng;
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
        public BasicDrawComponent()
        {

        }

        public void Draw()
        {
            TextureComponent texture = Parent.GetComponent<TextureComponent>();
            TransformComponent transform = Parent.GetComponent<TransformComponent>();
            Global.spriteBatch.Draw(texture.Texture, transform.Rectangle, Color.White);
        }
    }
}