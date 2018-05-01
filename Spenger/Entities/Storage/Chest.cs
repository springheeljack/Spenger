using Microsoft.Xna.Framework;
using Spenger.Managers;

namespace Spenger.Entities.Storage
{
    public class Chest : Storage
    {
        public Chest(Vector2 position) : base(position, TextureManager.Textures["Chest_C"], "Chest")
        {

        }
    }
}