﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spenger.Extensions
{
    public static class PointExtension
    {
        public static bool Intersects(this Point point,Vector2 position,Vector2 size)
        {
            return point.X >= position.X && point.Y >= position.Y && point.X <= position.X + size.X && point.Y <= position.Y + size.Y;
        }
    }
}
