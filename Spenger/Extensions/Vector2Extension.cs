using Microsoft.Xna.Framework;

namespace Spenger.Extensions
{
    public static class Vector2Extension
    {
        public static float Distance(this Vector2 v, Vector2 vector)
        {
            return (v - vector).Length();
        }
        public static float DistanceSquared(this Vector2 v, Vector2 vector)
        {
            return (v - vector).LengthSquared();
        }
    }
}
