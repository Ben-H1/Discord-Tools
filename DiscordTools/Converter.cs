using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DiscordTools
{
    class Converter
    {
        
        public string convertEachWord(string text, string before, string after)
        {
            string finalString = "";
            string[] parts = text.Split(' ');

            foreach (string part in parts)
            {
                finalString += before + part + after + " ";
            }

            return finalString;
        }

        public string convertEachLetter(string text, bool ignoreSpaces, string before, string after)
        {
            string finalString = "";
            char[] parts = text.ToCharArray();

            foreach (char part in parts)
            {
                if (ignoreSpaces) {
                    if (part != ' ') {
                        finalString += before + part + after;
                    }
                    else {
                        finalString += part;
                    }
                } else {
                    finalString += before + part + after;
                }
            }

            return finalString;
        }

        public string convertToFont(string text, string[] font)
        {
            string finalString = "";

            foreach (char letter in text)
            {
                int letterASC = (int)letter;

                if(letterASC >= 65 && letterASC <= 90) { //UPPER CASE
                    letterASC -= 65;
                    finalString += getCharacter(letterASC, font);

                } else if (letterASC >= 97 && letterASC <= 122) { //LOWER CASE
                    letterASC -= 71;
                    finalString += getCharacter(letterASC, font);

                } else {
                    finalString += letter;

                }
            }
            return finalString;
        }

        private string getCharacter(int index, string[] font)
        {
            return font[index];
        }
    }
}
