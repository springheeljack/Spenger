using Microsoft.Xna.Framework;

namespace Spenger.Components
{
    public class BasicDrawComponent : Component, IDrawableComponent
    {
        public void Draw()
        {
            TextureComponent texture = Parent.GetComponent<TextureComponent>();
            Global.spriteBatch.Draw(texture.Texture, Parent.transform.DrawingRectangle, Color.White);
        }
    }
}