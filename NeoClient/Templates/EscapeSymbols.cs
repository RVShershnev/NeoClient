using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoClient.Templates
{
    public static class EscapeSymbols
    {
        public const string DoubleQoutes = @"""";


        public const string Point = @".";


        static Dictionary<string, string> Symbols = new Dictionary<string, string>();
    
        static EscapeSymbols()
        {
            Symbols.Add(DoubleQoutes, $"\\{DoubleQoutes}");
            Symbols.Add(Point, $"{Point}");
        }

        public static string ConvertToCypher(string value)
        {
            for (var i = 0; i < Symbols.Count; i++)
            {
                var rep = Symbols.ElementAt(i);
                value = value?.Replace(rep.Key, rep.Value);
            }
            return value;
        }

    }
}
