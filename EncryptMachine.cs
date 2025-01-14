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

        private string ascKey;

        public void SetVariables(string encryptionType, string textToEncrypt, int shift, string key)
        {
            this.encryptionType = encryptionType;
            this.textToEncrypt = textToEncrypt;


            caesarShift = shift;

            ascKey = key;
        }
        public void Encrypt()
        {
            ChooseEncryption();
            encryptor.Encrypt();
        }

        public void Decrypt()
        {
            ChooseEncryption();
            encryptor.Decrypt();
        
        }
        private void ChooseEncryption()
        {
            switch (encryptionType)
            {
                case "Caesar Cipher":
                    Console.WriteLine("Caesar Encrypt");
                    encryptor = new Caesar(textToEncrypt, caesarShift);
                    break;
                case "Monoalphabetic Substitution Cipher":
                    Console.WriteLine("Monoalphabetic Substitution Cipher");
                    encryptor = new AlphabetSubstion(textToEncrypt, ascKey);
                    break;
                case "Atbash Cipher":
                    Console.WriteLine("Atbash Cipher");
                    encryptor = new Atbash(textToEncrypt);
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
