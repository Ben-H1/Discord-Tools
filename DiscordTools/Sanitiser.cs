using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DiscordTools
{
    class Sanitiser
    {
        public string alphaOnly(string text)
        {
            Regex rgx = new Regex("[^a-zA-Z\\s]");
            return rgx.Replace(text, "");
        }
    }
}
