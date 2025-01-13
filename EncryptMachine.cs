using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cipher_App
{
    internal class EncryptMachine
    {
        private Cipher encryptor;
        private string encryptionType;
        private string textToEncrypt;

        private int caesarShift;


        public void SetVariables(string encryptionType, string textToEncrypt, int shift)
        {
            this.encryptionType = encryptionType;
            this.textToEncrypt = textToEncrypt;


            caesarShift = shift;
        }
        public void Encrypt()
        {
            switch (encryptionType)
            {
                case "Caesar Cipher":
                    Console.WriteLine("Caesar Encrypt");
                    encryptor = new Caesar(textToEncrypt, caesarShift);
                    encryptor.Encrypt();
                    break;

                default:
                    Console.WriteLine("How do you keep doing it.");
                    break;
            }
        }

        public void Decrypt()
        {
            switch (encryptionType)
            {
                case "Caesar Cipher":
                    Console.WriteLine("Caesar Decrypt");
                    encryptor = new Caesar(textToEncrypt, caesarShift);
                    encryptor.Decrypt();
                    break;

                default:
                    Console.WriteLine("How do you keep doing it.");
                    break;
            }
        }

        public void ShowWord(ref Label output)
        {
            output.Text = encryptor.GetEncryptedWord;
        }
    }
}
