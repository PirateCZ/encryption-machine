using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher_App
{
    internal class Vigenere : Cipher
    {
        private char[] key;
        public Vigenere(string word, string key)
        {
            this.word = word;
            this.key = key.ToLower().ToCharArray();
        }
        public override void Encrypt()
        {
            char[] charArray = new char[word.Length];
            int counter = 0;
            int shift;
            for(int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]))
                {
                    shift = key[(i + counter) % key.Length] - 97;
                    if (char.IsUpper(word[i]))
                    {
                        charArray[i] = (char)(65 + (word[i] + shift - 65) % 26);
                    }
                    else
                    {
                        charArray[i] = (char)(97 + (word[i] + shift - 97) % 26);
                    }
                }
                else
                {
                    charArray[i] = word[i];
                    counter--;
                }
            }
            encryptedWord = new string(charArray);
        }
        public override void Decrypt()
        {
            char[] charArray = new char[word.Length];
            int counter = 0;
            int shift;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]))
                {
                    shift = key[(i + counter) % key.Length] - 97;
                    if (char.IsUpper(word[i]))
                    {
                        charArray[i] = (char)(65 + (word[i] - shift - 65) % 26);
                    }
                    else
                    {
                        charArray[i] = (char)(97 + (word[i] - shift - 97) % 26);
                    }
                }
                else
                {
                    charArray[i] = word[i];
                    counter--;
                }
            }
            encryptedWord = new string(charArray);
        }
    }
}
