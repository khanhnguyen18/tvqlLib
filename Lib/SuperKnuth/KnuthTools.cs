using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace SuperKnuth
{
    public class KnuthTools
    {
        private static string key = "Khanh";

        public static string CreateKey()
        {
            StringBuilder builder = new StringBuilder();
            int length = key.Length;
            for (int i = 1; i <= length; i++)
            {
                int startIndex = key.Length - i;
                builder.Append(key.Substring(startIndex, 1));
            }
            string str = builder.ToString();
            return builder.ToString();
        }

        public static string Dehash(string pOut)
        {
            try
            {
                if (pOut == "") return pOut;

                MD5CryptoServiceProvider provider2 = new MD5CryptoServiceProvider();
                string s = CreateKey();

                TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider();
                provider.Key = provider2.ComputeHash(Encoding.Unicode.GetBytes(s));
                provider.Mode = CipherMode.ECB;
                ICryptoTransform transform = provider.CreateDecryptor();

                byte[] inputBuffer = Convert.FromBase64String(pOut);
                byte[] output = transform.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);

                return Encoding.Unicode.GetString(output);
            }
            catch
            {
                return "";
            }
        }

        public static string Hash(string pIn)
        {
            try
            {
                if (pIn == "") return pIn;

                string s = CreateKey();
                TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider();
                provider.Key = new MD5CryptoServiceProvider().ComputeHash(Encoding.Unicode.GetBytes(s));
                provider.Mode = CipherMode.ECB;
                ICryptoTransform transform = provider.CreateEncryptor();
                byte[] bytes = Encoding.Unicode.GetBytes(pIn);
                return Convert.ToBase64String(transform.TransformFinalBlock(bytes, 0, bytes.Length));
            }
            catch
            {
                return "";
            }
        }

        public static byte[] Hash(byte[] input)
        {
            try
            {
                if (input.Length == 0) return null;

                string s = CreateKey();
                TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider();
                provider.Key = new MD5CryptoServiceProvider().ComputeHash(Encoding.Unicode.GetBytes(s));
                provider.Mode = CipherMode.ECB;
                ICryptoTransform transform = provider.CreateEncryptor();
                return transform.TransformFinalBlock(input, 0, input.Length);
            }
            catch
            {
                return null;
            }
        }

        public static byte[] DeHash(byte[] input)
        {
            try
            {
                if (input.Length == 0) return null;

                TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider();
                MD5CryptoServiceProvider provider2 = new MD5CryptoServiceProvider();
                string s = CreateKey();
                provider.Key = provider2.ComputeHash(Encoding.Unicode.GetBytes(s));
                provider.Mode = CipherMode.ECB;
                ICryptoTransform transform = provider.CreateDecryptor();
                return transform.TransformFinalBlock(input, 0, input.Length);
            }
            catch
            {
                return null;
            }
        }
    }
}
