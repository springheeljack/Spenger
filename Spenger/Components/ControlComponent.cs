using Microsoft.Xna.Framework.Input;
using Spenger.Managers;

namespace Spenger.Components
{
    public class ControlComponent : Component, IUpdateableComponent
    {
        public bool IsInventoryOpen { get; private set; } = false;

        public void Update()
        {
            //Movement
            if (InputManager.IsKeyDown(Keys.W))
                Parent.transform.Position.Y--;
            if (InputManager.IsKeyDown(Keys.S))
                Parent.transform.Position.Y++;
            if (InputManager.IsKeyDown(Keys.A))
                Parent.transform.Position.X--;
            if (InputManager.IsKeyDown(Keys.D))
                Parent.transform.Position.X++;

            //Inventory
            if (InputManager.IsKeyHit(Keys.E))
            {
                IsInventoryOpen = !IsInventoryOpen;
            }
        }
    }
}
