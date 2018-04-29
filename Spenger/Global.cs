using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spenger.Entities;

namespace Spenger
{
    public static class Global
    {
        public static GameTime gameTime;
        public static SpriteBatch spriteBatch;
        public static ContentManager content;
        public static Camera camera;
        public static int WindowWidth = 1280;
        public static int WindowHeight = 720;
    }
}
