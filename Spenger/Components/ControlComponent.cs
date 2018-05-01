using Microsoft.Xna.Framework;
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
            var movement = new Vector2(0);
            if (InputManager.IsKeyDown(Keys.W))
                movement.Y--;
            if (InputManager.IsKeyDown(Keys.S))
                movement.Y++;
            if (InputManager.IsKeyDown(Keys.A))
                movement.X--;
            if (InputManager.IsKeyDown(Keys.D))
                movement.X++;
            if (movement.LengthSquared() != 0f)
                movement.Normalize();
            Parent.transform.Position += movement;

            TextureComponent texture = Parent.GetComponent<TextureComponent>();
            if (movement.X < 0)
                texture.Texture = TextureManager.Textures["Player_L"];
            else if (movement.X > 0)
                texture.Texture = TextureManager.Textures["Player_R"];
            else if (movement.Y < 0)
                texture.Texture = TextureManager.Textures["Player_U"];
            else if (movement.Y > 0)
                texture.Texture = TextureManager.Textures["Player_D"];

            //Inventory
            if (InputManager.IsKeyHit(Keys.E))
            {
                IsInventoryOpen = !IsInventoryOpen;
            }

            //Left click
            if (InputManager.IsButtonHit(MouseButtons.Left))
            {

            }

            //Right click
            if (InputManager.IsButtonHit(MouseButtons.Right))
            {

            }
        }
    }
}