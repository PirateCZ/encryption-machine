using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cipher_App
{
    internal class AlphabetSubstion : Cipher
    {
        private string key;
        private Dictionary<char, char> substitutionalTable = new Dictionary<char, char>();

        public AlphabetSubstion(string word, string key)
        {
            this.word = word;
            this.key = key;
            GenerateSubstitionalTable();
        }

        private void GenerateSubstitionalTable()
        {
            for (int i = 0; i < 26; i++)
            {
                substitutionalTable.Add((char)(97 + i), key[i]);
                substitutionalTable.Add((char)(65 + i), key.ToUpper()[i]);
;            }
        }

        public override void Encrypt()
        {
            char[] charArray = new char[word.Length];
            for(int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]))
                {
                    charArray[i] = substitutionalTable[word[i]];
                }
                else charArray[i] = word[i];
            }
            encryptedWord = new string(charArray);
        }

        public override void Decrypt()
        {
            char[] charArray = new char[word.Length];
            for(int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]))
                {
                    charArray[i] = substitutionalTable.First(x => x.Value == word[i]).Key;
                }
                else charArray[i] = word[i];
            }
            encryptedWord = new string(charArray);
        }

    }
}
