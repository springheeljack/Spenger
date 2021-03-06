﻿using Microsoft.Xna.Framework;
using Spenger.Components;

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
        public Vector2 CalculateDrawingPosition(Vector2 position)
        {
            Vector2 newPos = position;
            newPos -= CameraComponent.Centre;
            newPos *= CameraComponent.ZoomLevel;
            newPos += Global.HalfWindowSize;
            return newPos;
        }
    }
}