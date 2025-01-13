using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher_App
{
    abstract internal class Cipher
    {
        protected string word;
        protected string encryptedWord;

        public string GetEncryptedWord { get { return encryptedWord; } }

        public abstract void Encrypt();
        public abstract void Decrypt();
    }
}
