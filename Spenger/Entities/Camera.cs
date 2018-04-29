using Microsoft.Xna.Framework;
using Spenger.Components;
using Spenger.Entities;

namespace Spenger.Entities
{
    public class Camera : Entity, IUpdateable
    {
        public CameraComponent CameraComponent { get; private set; }
        public Camera(Entity follow)
        {
            AddComponent(new TransformComponent(Vector2.Zero, Vector2.Zero));
            CameraComponent = new CameraComponent(follow);
            AddComponent(CameraComponent);
        }
    }
}