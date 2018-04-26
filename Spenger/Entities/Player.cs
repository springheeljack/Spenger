using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spenger.Entities
{
    public class Player : Entity, IUpdateable,IDrawable
    {
        static Vector2 Size = new Vector2(16);
        public Player(Vector2 position)
        {
            
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}