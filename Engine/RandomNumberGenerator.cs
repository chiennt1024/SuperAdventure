﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        private static Random _generator = new Random();
        public static int NumberBetween(int miniumValue, int maxiumValue)
        {
            return _generator.Next(miniumValue, maxiumValue + 1);
        }
    }
}
