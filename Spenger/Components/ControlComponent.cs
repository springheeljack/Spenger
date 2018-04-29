using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
using Spenger.Entities;

namespace Spenger.Components
{
    public class ControlComponent : Component, IUpdateableComponent
    {
        public ControlComponent()
        {
        }

        public void Update()
        {
            TransformComponent tc = Parent.GetComponent<TransformComponent>();
            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.W))
                tc.Position.Y--;
            if (keyboardState.IsKeyDown(Keys.S))
                tc.Position.Y++;
            if (keyboardState.IsKeyDown(Keys.A))
                tc.Position.X--;
            if (keyboardState.IsKeyDown(Keys.D))
                tc.Position.X++;
        }
    }
}
