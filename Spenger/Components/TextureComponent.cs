using Microsoft.Xna.Framework.Graphics;
using Speng.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spenger.Components
{
    public class TextureComponent : Component
    {
        public Texture2D Texture;
        public TextureComponent(string texturePath)
        {
            Texture = TextureManager.Textures[texturePath];
        }
    }
}
