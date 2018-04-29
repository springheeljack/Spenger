using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Speng.Managers;
using Spenger.Entities;
using Spenger.Managers;

namespace Speng
{
    public class Game : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Game()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            Global.content = Content;
            IsMouseVisible = true;
            graphics.PreferredBackBufferWidth = Global.WindowWidth;
            graphics.PreferredBackBufferHeight = Global.WindowHeight;
            Window.Position = new Point(200);

        }

        protected override void Initialize()
        {


            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Global.spriteBatch = spriteBatch;

            TextureManager.LoadTextures();

            EntityManager.AddEntity(new Player(new Vector2(100)));
        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            Global.gameTime = gameTime;

            EntityManager.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            EntityManager.Draw();

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
