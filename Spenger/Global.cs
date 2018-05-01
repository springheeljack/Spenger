using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spenger.Entities;
using System;

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
        public static Point WindowSize = new Point(WindowWidth, WindowHeight);
        public static Vector2 HalfWindowSize = WindowSize.ToVector2() / 2;
        public static Player player;
        public static Random random = new Random();
    }
}