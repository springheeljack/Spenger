using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Spenger.Extensions
{
    public static class SpriteBatchExtension
    {
        const int NumOfShadowOffsets = 8;
        static Vector2[] ShadowOffsets = new Vector2[NumOfShadowOffsets]
        {
            new Vector2(-1, -1),
            new Vector2(-1, 0),
            new Vector2(-1, 1),
            new Vector2(0, -1),
            new Vector2(0, 1),
            new Vector2(1, -1),
            new Vector2(1, 0),
            new Vector2(1, 1)
        };

        const int NumOfOffsets = 4;
        static Vector2[] Offsets = new Vector2[NumOfOffsets]
        {
            new Vector2(-0.5f,-0.5f),
            new Vector2(-0.5f,0.5f),
            new Vector2(0.5f,-0.5f),
            new Vector2(0.5f,0.5f),
        };

        public static void DrawShadowedString(this SpriteBatch spriteBatch, SpriteFont spriteFont, string text, Vector2 position, Color color)
        {
            Color shadowColor = color * 0.25f;
            shadowColor.A = 255;
            for (int i = 0; i < NumOfShadowOffsets; i++)
                spriteBatch.DrawString(spriteFont, text, (position + ShadowOffsets[i]).ToPoint().ToVector2(), shadowColor, 0, Vector2.Zero, 1, SpriteEffects.None, 0);
            spriteBatch.DrawString(spriteFont, text, position.ToPoint().ToVector2(), color, 0, Vector2.Zero, 1f, SpriteEffects.None, 0);
        }
    }
}