using System;
using System.Text;

internal class Class1
{
    static Class1()
    {
        Class15.smethod_5();
    }

    public Class1()
    {
        Class17.smethod_0();
    }

    internal static string smethod_0(byte[] byte_0)
    {
        if ((byte_0 == null) || (byte_0.Length == 0))
        {
            return "";
        }
        StringBuilder builder = new StringBuilder();
        foreach (byte num2 in byte_0)
        {
            builder.Append(string.Format("{0:X2}", num2));
        }
        return builder.ToString();
    }

    internal static byte[] smethod_1(string string_0)
    {
        byte[] buffer;
        if ((string_0 == null) || (string_0.Length == 0))
        {
            return null;
        }
        try
        {
            int num = Convert.ToInt32((int) (string_0.Length / 2));
            byte[] buffer2 = new byte[num];
            for (int i = 0; i <= (num - 1); i++)
            {
                buffer2[i] = Convert.ToByte(string_0.Substring(i * 2, 2), 0x10);
            }
            buffer = buffer2;
        }
        catch (Exception exception)
        {
            throw new FormatException("The provided string does not appear to be Hex encoded:" + Environment.NewLine + string_0 + Environment.NewLine, exception);
        }
        return buffer;
    }
}

