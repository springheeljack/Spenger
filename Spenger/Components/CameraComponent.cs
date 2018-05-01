using Microsoft.Xna.Framework;
using Spenger.Entities;
using Spenger.Managers;

namespace Spenger.Components
{
    public class CameraComponent : Component, IUpdateableComponent
    {
        public float ZoomLevel { get; private set; } = 2.0f;
        public Vector2 Centre { get; private set; }
        public Entity Follow;

        public CameraComponent(Entity follow)
        {
            Follow = follow;
        }

        public void Update()
        {
            Centre = Follow.transform.Position;
            Centre += Follow.transform.Size / 2.0f;

            if (InputManager.ScrolledUp)
                ZoomLevel *= 2f;
            else if (InputManager.ScrolledDown)
                ZoomLevel /= 2f;

            Parent.transform.Position = Follow.transform.Position - new Vector2(Global.WindowWidth / 2.0f, Global.WindowHeight / 2.0f) / ZoomLevel;
            Parent.transform.Position += Follow.transform.Size / 2;
        }
    }
}