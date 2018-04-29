using Microsoft.Xna.Framework;
using Spenger.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spenger.Entities
{
    public class Player : Entity, IUpdateable, IDrawable
    {
        private static string TexturePath = "Player";
        static Vector2 Size = new Vector2(16);
        public Player(Vector2 position)
        {
            AddComponent(new TransformComponent(position, new Vector2(32)));
            AddComponent(new TextureComponent(TexturePath));
            AddComponent(new BasicDrawComponent());
            AddComponent(new ControlComponent());
        }

        public void Update()
        {
            foreach (IUpdateableComponent u in Components.OfType<IUpdateableComponent>())
            {
                u.Update();
            }
        }

        public void Draw()
        {
            foreach (IDrawableComponent d in Components.OfType<IDrawableComponent>())
            {
                d.Draw();
            }
        }
    }
}