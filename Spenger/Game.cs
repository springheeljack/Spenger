using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spenger.Managers;
using Spenger.Entities;
using Spenger.Entities.ResourceNodes;
using Spenger.Entities.Storage;

namespace Spenger
{
    public class Game : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        const int numOfFrameTimes = 100;
        double[] frameTimes = new double[numOfFrameTimes];
        int currentFrameTime = 0;
        public static double AverageFrameTime { get; private set; }

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
            //graphics.PreferMultiSampling = true;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Global.spriteBatch = spriteBatch;

            TextureManager.Load();

            ItemManager.Initialize();

            var player = new Player(new Vector2(100));
            EntityManager.AddEntity(player);
            Global.player = player;
            Camera camera = new Camera(player);
            EntityManager.AddEntity(camera);
            Global.camera = camera;

            EntityManager.AddEntity(new CoalRock(new Vector2(50)));

            EntityManager.AddEntity(new IronRock(new Vector2(150)));

            EntityManager.AddEntity(new Chest(new Vector2(250)));

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

            frameTimes[currentFrameTime] = gameTime.ElapsedGameTime.TotalSeconds;
            currentFrameTime++;
            if (currentFrameTime == numOfFrameTimes)
                currentFrameTime = 0;

            AverageFrameTime = 0;
            for (int i = 0; i < numOfFrameTimes; i++)
                AverageFrameTime += frameTimes[i];
            AverageFrameTime /= numOfFrameTimes;

            InputManager.Update();

            EntityManager.Update();

            UIManager.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied, SamplerState.PointClamp, null, null, null, null);

            Map.Draw();

            EntityManager.Draw();

            UIManager.Draw();

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}