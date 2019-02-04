using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanizerLib
{
    public class Romanizer
    {
        private readonly IEnumerable<KeyValuePair<int, string>> _dictionary = Helpers.GetReferenceData().Where(x =>
        {
            switch (x.Key)
            {
                case 1:
                case 5:
                case 10:
                case 50:
                case 100:
                case 500:
                case 1000:
                    return true;
                    break;
                default:
                return false;
            }
        });

        public string Translate(int i)
        {
            if (_dictionary.Any(x => x.Key == i))
            {
                return _dictionary.FirstOrDefault(x => x.Key == i).Value;
            }

            return i.ToString();
        }

        private string CalculateRoman(int i)
        {
            return i.ToString();
        }

    }
}
