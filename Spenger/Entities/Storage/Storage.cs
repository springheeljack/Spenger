using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spenger.Components;

namespace Spenger.Entities.Storage
{
    public abstract class Storage : Entity, IDrawable, IUpdateable
    {
        static Vector2 Size = new Vector2(16);
        public Storage(Vector2 position, Texture2D texture, string name)
        {
            AddComponent(new TransformComponent(position, Size));
            AddComponent(new TextureComponent(texture));
            AddComponent(new BasicDrawComponent());
            AddComponent(new InventoryComponent(100));
            AddComponent(new SelectComponent(name));
        }
    }
}