using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RomanizerLib
{
    public static class Helpers
    {
        public static IEnumerable<KeyValuePair<int, string>> GetReferenceData()
        {
            var path = @"C:\Users\indra\Desktop\romannumerals.csv";
            var lines = File.ReadAllLines(path);
            var romans = new List<KeyValuePair<int, string>>(lines.Length);

            foreach (var l in lines)
            {
                var s = l.Split(new char[] { ',' });

                var r = new KeyValuePair<int, string>(Int32.Parse(s[0]), s[1].ToString());
                romans.Add(r);
            }

            return romans;
        }
    }
}
