using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Spenger.Entities;
using Spenger.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spenger.Components
{
    public class CameraComponent : Component, IUpdateableComponent
    {
        //public float ZoomLevel { get; private set; } = 1.0f;
        public Entity Follow;

        public CameraComponent(Entity follow)
        {
            Follow = follow;
        }

        public void Update()
        {
            Parent.transform.Position = Follow.transform.Position - new Vector2(Global.WindowWidth / 2.0f, Global.WindowHeight / 2.0f);
            Parent.transform.Position += Follow.transform.Size / 2;
        }
    }
}