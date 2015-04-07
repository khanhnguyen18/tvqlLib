using System;
using System.Collections.Generic;
using System.Text;

namespace ArtDe
{
    public class Decode
    {
        private static string key = "Khanh";

        public static string EncodeCode(string original)
        {
            if (string.IsNullOrEmpty(original)) return string.Empty;

            int keyIdx = 0;
            int maxKeyIdx = key.Length - 1;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < original.Length; i++)
            {
                result.Append(ConvertCharToHex(original[i] + key[keyIdx]));
                keyIdx++;
                if (keyIdx > maxKeyIdx)
                    keyIdx = 0;
            }

            return result.ToString();
        }

        public static string DecodeCode(string original)
        {
            if (string.IsNullOrEmpty(original)) return string.Empty;
            if (original.Length % 2 == 1) return string.Empty;

            int keyIdx = 0;
            int maxKeyIdx = key.Length - 1;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < original.Length; i = i + 2)
            {
                char c = (char)(ConvertHexToChar(original[i].ToString() + original[i + 1].ToString()) - key[keyIdx]);
                result.Append(c);

                keyIdx++;
                if (keyIdx > maxKeyIdx)
                    keyIdx = 0;
            }

            return result.ToString();
        }

        public static string ConvertCharToHex(int c)
        {
            return c.ToString("X");
        }

        public static char ConvertHexToChar(string hex)
        {
            return (char)int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
        }
    }
}
