﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Thickener
{
    public static class Thickener
    {
        private static Dictionary<char, char> mappings = new Dictionary<char, char>
        {
            { 'a','卂' },
            { 'b','乃' },
            { 'c','匚' },
            { 'd','刀' },
            { 'e','乇' },
            { 'f','下' },
            { 'g','厶' },
            { 'h','卄' },
            { 'i','工' },
            { 'j','丁' },
            { 'k','长' },
            { 'l','乚' },
            { 'm','从' },
            { 'n','几' },
            { 'o','口' },
            { 'p','尸' },
            { 'q','㔿' },
            { 'r','尺' },
            { 's','丂' },
            { 't','丅' },
            { 'u','凵' },
            { 'v','リ' },
            { 'w','山' },
            { 'x','乂' },
            { 'y','丫' },
            { 'z','乙' },
        };

        public static string Thicken(this string s)
        {
            return new string(s.ToCharArray()
                .Select(c => c.Thicken())
                .ToArray());
        }

        public static char Thicken(this char c)
        {
            return mappings
                .ContainsKey(char.ToLowerInvariant(c))
                ? mappings.FirstOrDefault(d => d.Key == char.ToLowerInvariant(c)).Value
                : c;
        }
    }
}
