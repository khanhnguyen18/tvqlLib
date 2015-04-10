using System;
using System.Security.Cryptography;
using System.Text;
using System.Management;
using ArtDe;

internal class Class13
{
    public static string string_0;

    static Class13()
    {
        Class15.smethod_5();
        Class17.smethod_0();
        string_0 = "";
    }

    public Class13()
    {
        Class17.smethod_0();
    }

    public static string smethod_0(string string_1, string string_2)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(string_1);
        MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
        byte[] buffer2 = provider.ComputeHash(Encoding.UTF8.GetBytes(string_2));
        provider.Clear();
        TripleDESCryptoServiceProvider provider2 = new TripleDESCryptoServiceProvider();
        provider2.Key = buffer2;
        provider2.Mode = CipherMode.ECB;

        byte[] inArray = provider2.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length);
        provider2.Clear();
        return Convert.ToBase64String(inArray, 0, inArray.Length);
    }

    public static string smethod_1(string string_1, string string_2)
    {
        return Decode.DecodeCode(string_1);
    }

    public static string smethod_2(string string_1)
    {
        if (string.IsNullOrEmpty(string_1))
        {
            return string.Empty;
        }
        char ch2 = 'p';
        string str = "";
        int num = 0;
        int length = string_1.Length;
        for (num = 0; num <= (length - 1); num++)
        {
            char ch = string_1[num];
            int num2 = ch;
            if (num2 < 0x80)
            {
                ch2 = (char)(num2 + 0x80);
            }
            else if (num2 > 0x80)
            {
                ch2 = (char)(num2 - 0x80);
            }
            str = str + ch2;
        }
        return str;
    }

    public static string smethod_3()
    {
        ManagementObjectCollection objects = null;
        objects = new ManagementObjectSearcher("Select * From Win32_BaseBoard").Get();
        string str = null;
        foreach (ManagementObject obj2 in objects)
        {
            str = obj2["SerialNumber"].ToString();
        }
        return str;
    }

    public static string smethod_4()
    {
        ManagementObjectCollection objects = null;
        objects = new ManagementObjectSearcher("Select * From Win32_processor").Get();
        string str = null;
        foreach (ManagementObject obj2 in objects)
        {
            str = obj2["ProcessorID"].ToString();
        }
        return str;
    }

    public static string smethod_5(string string_1)
    {
        if ((string_1 == "") || (string_1 == null))
        {
            string_1 = "C";
        }
        ManagementObject obj2 = new ManagementObject("win32_logicaldisk.deviceid=\"" + string_1 + ":\"");
        obj2.Get();
        return obj2["VolumeSerialNumber"].ToString();
    }
}

