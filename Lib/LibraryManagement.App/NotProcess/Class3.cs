using System;
using System.IO;

internal class Class3
{
    static Class3()
    {
        Class15.smethod_5();
    }

    public Class3()
    {
        Class17.smethod_0();
    }

    public static byte[] smethod_0(string string_0)
    {
        FileStream stream = new FileStream(string_0, FileMode.Open, FileAccess.Read);
        byte[] buffer = new byte[stream.Length];
        stream.Read(buffer, 0, Convert.ToInt32(stream.Length));
        stream.Close();
        return buffer;
    }
}

