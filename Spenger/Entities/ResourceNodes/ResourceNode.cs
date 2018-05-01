using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spenger.Components;
using Spenger.Items;

namespace Spenger.Entities.ResourceNodes
{
    public abstract class ResourceNode : Entity, IUpdateable, IDrawable
    {
        static Vector2 Size = new Vector2(16);
        public ResourceNode(Vector2 position,Texture2D texture,ItemType item, int count,string name)
        {
            AddComponent(new TransformComponent(position, Size));
            AddComponent(new TextureComponent(texture));
            AddComponent(new BasicDrawComponent());
            AddComponent(new SelectComponent(name));
            AddComponent(new ResourceNodeComponent(item, count));
        }
        public ResourceNode(Vector2 position, Texture2D texture, ItemType item, int countLowerBound,int countUpperBound,string name) : this(position,texture,item, Global.random.Next(countLowerBound, countUpperBound),name)
        {
            
        }
    }
}