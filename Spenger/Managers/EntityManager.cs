using Spenger.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Spenger.Managers
{
    public static class EntityManager
    {
        private static List<Entity> Entities = new List<Entity>();

        public static void Update()
        {
            foreach (IUpdateable u in Entities.OfType<IUpdateable>())
                u.Update();
        }

        public static void Draw()
        {
            foreach (IDrawable d in Entities.OfType<IDrawable>())
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
