using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;

namespace Spenger.Managers
{
    public static class TextureManager
    {
        public static Dictionary<string, Texture2D> Textures { get; private set; } = new Dictionary<string, Texture2D>();
        public static string TexturePath { get; } = "Texture";
        public static void LoadTextures()
        {
            //foreach (string dir in Directory.GetDirectories("Content/Texture"))
            //    foreach (string file in Directory.GetFiles(dir))
            //    {
            //        string s = Path.GetFileName(dir) + "/" + Path.GetFileNameWithoutExtension(file);
            //        Textures.Add(Path.GetFileNameWithoutExtension(file), Global.content.Load<Texture2D>(s));
            //    }

            foreach (string dir in Directory.GetDirectories("Content/" + TexturePath))
                foreach (string file in Directory.GetFiles(dir))
                {
                    string s = TexturePath + "/" + Path.GetFileName(dir) + "/" + Path.GetFileNameWithoutExtension(file);
                    Textures.Add(Path.GetFileNameWithoutExtension(file), Global.content.Load<Texture2D>(s));
                }
        }
    }
}
