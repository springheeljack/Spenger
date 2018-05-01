using Microsoft.Xna.Framework;
using Spenger.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spenger.Entities.Storage
{
    public class Chest : Storage
    {
        public Chest(Vector2 position) : base(position, TextureManager.Textures["Chest_C"])
        {

        }

    }
}