using Microsoft.Xna.Framework.Graphics;
using Spenger.Managers;

namespace Spenger.Components
{
    public class TextureComponent : Component
    {
        public Texture2D Texture;
        //public TextureComponent(string texturePath)
        //{
        //    Texture = TextureManager.Textures[texturePath];
        //}
        public TextureComponent(Texture2D texture)
        {
            Texture = texture;
        }
    }
}
