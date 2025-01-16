using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher_App
{
    internal class Atbash : Cipher
    {


        public Atbash(string word)
        {
            this.word = word;
        }

        public override void Encrypt()
        {
            Crypt();
        }

        public override void Decrypt()
        {
            Crypt();
        }

        private void Crypt()
        {
            char[] charArray = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]))
                {
                    if (char.IsUpper(word[i]))
                    {
                        charArray[i] = (char)('Z' - (word[i] - 'A'));
                    }
                    else
                    {
                        charArray[i] = (char)('z' - (word[i] - 'a'));

                    }
                }
                else
                {
                    charArray[i] = word[i];
                }
            }
            encryptedWord = new string(charArray);
        }
    }
}
