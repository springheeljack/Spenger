using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spenger.Managers;
using Spenger.Entities;
using Spenger.Entities.ResourceNodes;

namespace Spenger
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

            ItemManager.Initialize();

            var player = new Player(new Vector2(100));
            EntityManager.AddEntity(player);
            Camera camera = new Camera(player);
            EntityManager.AddEntity(camera);
            Global.camera = camera;

            EntityManager.AddEntity(new CoalRock(new Vector2(50)));

            EntityManager.AddEntity(new IronRock(new Vector2(150)));

            //Map.LoadMap("Content/Map/map1.smap");
            Map.LoadMap("Content/Map/map2.smap");
            Map.InitializeTextures();

            UIManager.Initialize(player);
        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            Global.gameTime = gameTime;

            InputManager.Update();

            EntityManager.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied,SamplerState.PointClamp, null, null, null, null);

            Map.Draw();

            EntityManager.Draw();

            UIManager.Draw();

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}