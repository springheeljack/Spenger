using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speng.Managers
{
    public static class TextureManager
    {
        public static Dictionary<string, Texture2D> Textures { get; private set; } = new Dictionary<string, Texture2D>();
        public static void LoadTextures()
        {
            //foreach (string dir in Directory.GetDirectories("Content/Texture"))
                foreach (string file in Directory.GetFiles("Content/Texture"))
                {
                    string s = Path.GetFileName("Content/Texture") + "/" + Path.GetFileNameWithoutExtension(file);
                    Textures.Add(Path.GetFileNameWithoutExtension(file), Global.content.Load<Texture2D>(s));
                }
        }
    }
}
