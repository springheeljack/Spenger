using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spenger.Components;
using Spenger.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spenger.Entities.ResourceNodes
{
    public abstract class ResourceNode : Entity, IUpdateable, IDrawable
    {
        public static Vector2 Size { get; private set; } = new Vector2(16);
        public ResourceNode(Vector2 position,Texture2D texture)
        {
            AddComponent(new TransformComponent(position, Size));
            AddComponent(new TextureComponent(texture));
            AddComponent(new BasicDrawComponent());
        }
    }
}