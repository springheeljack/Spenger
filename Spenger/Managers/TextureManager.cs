using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;

namespace Spenger.Managers
{
    public static class TextureManager
    {
        public static Dictionary<string, Texture2D> Textures { get; private set; } = new Dictionary<string, Texture2D>();
        public static string TexturePath { get; } = "Texture";

        public static SpriteFont LargeFont { get; private set; }
        public static SpriteFont MediumFont { get; private set; }
        public static SpriteFont SmallFont { get; private set; }

        public static void Load()
        {
            foreach (string dir in Directory.GetDirectories("Content/" + TexturePath))
                foreach (string file in Directory.GetFiles(dir))
                {
                    string s = TexturePath + "/" + Path.GetFileName(dir) + "/" + Path.GetFileNameWithoutExtension(file);
                    Textures.Add(Path.GetFileNameWithoutExtension(file), Global.content.Load<Texture2D>(s));
                }
            LargeFont = Global.content.Load<SpriteFont>("Font/large");
            MediumFont = Global.content.Load<SpriteFont>("Font/medium");
            SmallFont = Global.content.Load<SpriteFont>("Font/small");
        }
    }
}
