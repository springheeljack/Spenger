using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Spenger.Managers
{
    public enum MouseButtons
    {
        Left,
        Right
    }

    public static class InputManager
    {
        static KeyboardState CurrentKeyboardState;
        static KeyboardState LastKeyboardState;

        public static MouseState CurrentMouseState { get; private set; }
        static MouseState LastMouseState;

        public static Rectangle MouseRectangle { get; private set; }
        public static int ScrollWheelDelta { get; private set; }
        public static bool ScrolledUp { get; private set; }
        public static bool ScrolledDown { get; private set; }

        public static void Update()
        {
            LastKeyboardState = CurrentKeyboardState;
            CurrentKeyboardState = Keyboard.GetState();

            LastMouseState = CurrentMouseState;
            CurrentMouseState = Mouse.GetState();

            MouseRectangle = new Rectangle(CurrentMouseState.Position, new Point(1));

            ScrollWheelDelta = CurrentMouseState.ScrollWheelValue - LastMouseState.ScrollWheelValue;
            ScrolledUp = ScrollWheelDelta > 0;
            ScrolledDown = ScrollWheelDelta < 0;
        }

        public static bool IsKeyUp(Keys key)
        {
            return CurrentKeyboardState.IsKeyUp(key);
        }
        public static bool IsKeyDown(Keys key)
        {
            return CurrentKeyboardState.IsKeyDown(key);
        }
        public static bool IsKeyHit(Keys key)
        {
            return CurrentKeyboardState.IsKeyDown(key) && LastKeyboardState.IsKeyUp(key);
        }
        public static bool IsButtonUp(MouseButtons mouseButton)
        {
            if (mouseButton == MouseButtons.Left)
                return CurrentMouseState.LeftButton == ButtonState.Released;
            else

                return CurrentMouseState.RightButton == ButtonState.Released;
        }
        public static bool IsButtonDown(MouseButtons mouseButton)
        {
            if (mouseButton == MouseButtons.Left)
                return CurrentMouseState.LeftButton == ButtonState.Pressed;
            else

                return CurrentMouseState.RightButton == ButtonState.Pressed;
        }
        public static bool IsButtonHit(MouseButtons mouseButton)
        {
            if (mouseButton == MouseButtons.Left)
                return CurrentMouseState.LeftButton == ButtonState.Pressed && LastMouseState.LeftButton == ButtonState.Released;
            else

                return CurrentMouseState.RightButton == ButtonState.Pressed && LastMouseState.RightButton == ButtonState.Released;
        }
    }
}