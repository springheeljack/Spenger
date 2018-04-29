using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spenger.Managers
{
    public static class InputManager
    {
        static KeyboardState CurrentKeyboardState;
        static KeyboardState LastKeyboardState;

        static MouseState CurrentMouseState;
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
    }
}
