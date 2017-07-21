using System;
using System.Collections.Generic;
using System.Text;

namespace Caesar
{
    public static class MyExtensions
    {
        public static bool IsLetter(this char ch)
        {

            return ch.IsUpper() || ch.IsLower();
        }

        public static bool IsUpper(this char ch)
        {
            return (ch >= 'A' && ch <= 'Z');
        }
        private static bool IsLower(this char ch)
        {
            return (ch >= 'a' && ch <= 'z');
        }
    }
}
