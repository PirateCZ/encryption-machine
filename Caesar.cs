using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Cipher_App
{
    internal class Caesar : Cipher
    {
        //v2
        private int shift;


        public Caesar(string word, int shift)
        {
            this.word = word;
            this.shift = shift;
        }

        public override void Encrypt()
        {
            char[] charArray = word.ToCharArray();

            for(int i = 0; i < charArray.Length; i++)
            {
                if (char.IsLetter(charArray[i]))
                {
                    for(int j = 0; j < shift; j++)
                    {
                        charArray[i]++;
                        if (charArray[i] == 123)
                        {
                            charArray[i] = 'a';
                        }
                        else if (charArray[i] == 91)
                        {
                            charArray[i] = 'A';
                        }
                    }
                }
            }

            encryptedWord = new string(charArray);
        }

        public override void Decrypt()
        {
            char[] charArray = word.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsLetter(charArray[i]))
                {
                    Console.WriteLine(charArray[i]);
                    for (int j = 0; j < shift; j++)
                    {
                        charArray[i]--;
                        if (charArray[i] == 96)
                        {
                            charArray[i] = 'z';
                        }
                        else if (charArray[i] == 64)
                        {
                            charArray[i] = 'Z';
                        }
                    }
                    Console.WriteLine(charArray[i]);
                }
            }

            encryptedWord = new string(charArray);
        }

        //v1
        //public string Cipher(string word, int shift)
        //{
        //    string cipher = "";
        //    char[] charArray = word.ToCharArray();
        //    foreach (char letter in charArray)
        //    {
        //        if (letter == ' ')
        //        {
        //            cipher += " ";
        //            continue;
        //        }

        //        int charAsNumber = letter + shift;

        //        if (charAsNumber < 65 || charAsNumber > 90 && charAsNumber < 97 || charAsNumber > 122)
        //        {
        //            charAsNumber -= 25;
        //        }
        //        cipher += (char)charAsNumber;
        //    }

        //    return cipher;
        //}

        //public string Decipher(string cipher, int shift)
        //{
        //    string word = "";
        //    char[] charArray = cipher.ToCharArray();

        //    foreach (char letter in charArray)
        //    {
        //        if (letter == ' ')
        //        {
        //            word += " ";
        //            continue;
        //        }
        //        int charAsNumber = letter - shift;
        //        if (charAsNumber < 65 || charAsNumber > 90 && charAsNumber < 97 || charAsNumber > 122)
        //        {
        //            charAsNumber -= 25;
        //        }
        //        word += (char)charAsNumber;
        //    }

        //    return word;
        //}


    }
}
