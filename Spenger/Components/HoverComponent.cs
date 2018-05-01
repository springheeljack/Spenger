using Spenger.Extensions;
using Spenger.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spenger.Components
{
    public class HoverComponent : Component, IUpdateableComponent
    {
        public void Update()
        {
            var pos = Global.camera.CalculateDrawingPosition(Parent.transform.Position);
            if (InputManager.CurrentMouseState.Position.Intersects(pos, Parent.transform.Size * Global.camera.CameraComponent.ZoomLevel))
                UIManager.HoverEntity = Parent;
        }
    }
}