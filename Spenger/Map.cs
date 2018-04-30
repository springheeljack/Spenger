using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spenger.Managers;
using System.IO;

namespace Spenger
{
    enum TileType : int
    {
        Water,
        Grass,
        Test,
        NumOfTileTypes
    }

    public static class Map
    {
        static byte[,] tiles = new byte[100, 100];
        static Texture2D[] tileTextures = new Texture2D[(int)TileType.NumOfTileTypes];

        public static void LoadMap(string mapPath)
        {
            byte[] data = File.ReadAllBytes(mapPath);

            for (int i = 0; i < 10000; i++)
            {
                tiles[i % 100, i / 100] = data[i];
            }
        }

        public static void CreateMap(string mapPath)
        {
            byte[] data = new byte[10000];
            for (int x = 0; x < 10000; x++)
                data[x] = 1;

            File.WriteAllBytes(mapPath, data);
        }

        public static void InitializeTextures()
        {
            tileTextures[(int)TileType.Grass] = TextureManager.Textures["Grass"];
            tileTextures[(int)TileType.Water] = TextureManager.Textures["Water"];
            tileTextures[(int)TileType.Test] = TextureManager.Textures["Test"];
        }

        public static void Draw()
        {
            for (int x = 0; x < 100; x++)
                for (int y = 0; y < 100; y++)
                {
                    var pos = new Vector2(x * 16, y * 16);
                    Global.spriteBatch.Draw(tileTextures[tiles[x, y]], Global.camera.CalculateDrawingPosition(pos), null, Color.White, 0, Vector2.Zero, Global.camera.CameraComponent.ZoomLevel, SpriteEffects.None, 0);
                }
        }
    }
}