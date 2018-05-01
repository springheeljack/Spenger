using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spenger.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spenger.Entities.Storage
{
    public abstract class Storage : Entity, IDrawable, IUpdateable
    {
        static Vector2 Size = new Vector2(16);
        public Storage(Vector2 position, Texture2D texture)
        {
            AddComponent(new TransformComponent(position, Size));
            AddComponent(new TextureComponent(texture));
            AddComponent(new BasicDrawComponent());
            AddComponent(new InventoryComponent());
            AddComponent(new HoverComponent());
        }
    }
}