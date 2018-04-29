using Microsoft.Xna.Framework;
using Spenger.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spenger.Entities.ResourceNodes
{
    public class IronRock : ResourceNode
    {

        public IronRock(Vector2 position) : base(position, TextureManager.Textures["IronRock"]) { }
    }
}
