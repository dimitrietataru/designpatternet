﻿using Decorator.Interfaces;

namespace Decorator.Cookies
{
    public class BakedCookie : AbstractCookie
    {
        public override string GetDescription() => "Baked cookie";
    }
}
