using Microsoft.Xna.Framework;
using Spenger.Items;
using Spenger.Managers;

namespace Spenger.Entities.ResourceNodes
{
    public class IronRock : ResourceNode
    {

        public IronRock(Vector2 position) : base(position, TextureManager.Textures["IronRock"],ItemType.IronOre,50,100,"Iron Rock") { }
    }
}
