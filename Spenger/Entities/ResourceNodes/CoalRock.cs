using Microsoft.Xna.Framework;
using Spenger.Managers;
using Spenger.Items;

namespace Spenger.Entities.ResourceNodes
{
    public class CoalRock : ResourceNode
    {
        public CoalRock(Vector2 position) : base(position, TextureManager.Textures["CoalRock"], ItemType.Coal, 50, 100,"Coal Rock") { }
    }
}