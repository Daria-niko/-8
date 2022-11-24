using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_8
{
    internal class users
    {
        public string Name;
        public int minute;
        public float sec;

        public users(string names, int letter_minute, float letter_sec)
        {
            Name = names;
            minute = letter_minute;
            sec = letter_sec;
        }

       
    }
}
