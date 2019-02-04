using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanizerLib
{
    public class Romanizer
    {
        private readonly IEnumerable<KeyValuePair<int, string>> _dictionary = Helpers.GetReferenceData().Where(x =>
        {
            switch (x.Key)
            {
                case 1:
                case 4:
                case 5:
                case 9:
                case 10:
                case 40:
                case 50:
                case 90:
                case 100:
                case 500:
                case 1000:
                    return true;
                    break;
                default:
                return false;
            }
        }).OrderByDescending(x=> x.Key);

        public string Translate(int i)
        {
            if (_dictionary.Any(x => x.Key == i))
            {
                return _dictionary.FirstOrDefault(x => x.Key == i).Value;
            }

            else return CalculateRoman(i);
        }

        private string CalculateRoman(int i)
        {
            var sb = new StringBuilder();
            var tmp = i;

            foreach (var x in _dictionary)
            {
                while (tmp - x.Key >= 0)
                {
                    //string.Format("{0} - {1} = {2}", tmp, x.Key, (tmp - x.Key)).Dump();
                    tmp = tmp - x.Key;
                    sb.Append(x.Value);

                }
            }

            return sb.ToString();
        }

    }
}
