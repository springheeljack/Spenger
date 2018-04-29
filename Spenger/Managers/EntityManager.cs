using Spenger.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spenger.Managers
{
    public static class EntityManager
    {
        private static List<Entity> Entities = new List<Entity>();

        public static void Update()
        {
            foreach (IUpdateable u in Entities)
                u.Update();
        }

        public static void Draw()
        {
            foreach (IDrawable d in Entities)
                d.Draw();
        }

        public static void AddEntity(Entity entity)
        {
            Entities.Add(entity);
        }

        public static void RemoveEntity(Entity entity)
        {
            Entities.Remove(entity);
        }
    }
}
