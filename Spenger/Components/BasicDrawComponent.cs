using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Spenger.Components
{
    public class BasicDrawComponent : Component, IDrawableComponent
    {
        public void Draw()
        {
            TextureComponent texture = Parent.GetComponent<TextureComponent>();
            Global.spriteBatch.Draw(texture.Texture, Global.camera.CalculateDrawingPosition(Parent.transform.Position), null, Color.White, 0, Vector2.Zero, Global.camera.CameraComponent.ZoomLevel, SpriteEffects.None, 0);

        }
    }
}