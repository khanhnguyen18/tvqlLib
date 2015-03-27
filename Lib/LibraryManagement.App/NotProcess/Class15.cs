using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

internal class Class15
{
    private static bool bool_0 = false;
    private static bool bool_1 = false;
    private static byte[] byte_0 = new byte[0];
    private static byte[] byte_1 = new byte[0];
    private static byte[] byte_2 = new byte[0];
    private static byte[] byte_3 = new byte[0];
    internal static Delegate1 delegate1_0 = null;
    internal static Delegate1 delegate1_1 = null;
    internal static Dictionary<long, Struct0> dictionary_0 = new Dictionary<long, Struct0>();
    private static int[] int_0 = new int[0];
    private static int int_1 = 1;
    private static int int_2 = 0;
    private static int int_3 = 0;
    private static int int_4 = 0;
    private static IntPtr intptr_0 = IntPtr.Zero;
    private static IntPtr intptr_1 = IntPtr.Zero;
    private static IntPtr intptr_2 = IntPtr.Zero;
    private static long long_0 = 0L;
    private static long long_1 = 0L;
    private static SortedList sortedList_0 = new SortedList();
    private static string[] string_0 = new string[0];

    internal static void ce4DmfsmSrOT856tDgfrkMb()
    {
    }

    [DllImport("kernel32.dll")]
    private static extern int CloseHandle(IntPtr intptr_3);
    [DllImport("kernel32", CharSet = CharSet.Ansi)]
    public static extern IntPtr GetProcAddress(IntPtr intptr_3, string string_1);
    [DllImport("kernel32")]
    public static extern IntPtr LoadLibrary(string string_1);
    private byte[] method_0()
    {
        return null;
    }

    private byte[] method_1()
    {
        return null;
    }

    private byte[] method_2()
    {
        string str = "{11111-22222-20001-00001}";
        if (str.Length > 0)
        {
            return new byte[] { 1, 2 };
        }
        return new byte[] { 1, 2 };
    }

    private byte[] method_3()
    {
        string str = "{11111-22222-20001-00002}";
        if (str.Length > 0)
        {
            return new byte[] { 1, 2 };
        }
        return new byte[] { 1, 2 };
    }

    private byte[] method_4()
    {
        return null;
    }

    private byte[] method_5()
    {
        return null;
    }

    internal byte[] method_6()
    {
        string str = "{11111-22222-40001-00001}";
        if (str.Length > 0)
        {
            return new byte[] { 1, 2 };
        }
        return new byte[] { 1, 2 };
    }

    internal byte[] method_7()
    {
        string str = "{11111-22222-40001-00002}";
        if (str.Length > 0)
        {
            return new byte[] { 1, 2 };
        }
        return new byte[] { 1, 2 };
    }

    internal byte[] method_8()
    {
        return null;
    }

    internal byte[] method_9()
    {
        return null;
    }

    [DllImport("kernel32.dll")]
    private static extern IntPtr OpenProcess(uint uint_0, int int_5, uint uint_1);
    [DllImport("kernel32.dll")]
    private static extern int ReadProcessMemory(IntPtr intptr_3, IntPtr intptr_4, [In, Out] byte[] byte_4, uint uint_0, out IntPtr intptr_5);
    internal static bool smethod_0(int int_5)
    {
        if (byte_1.Length == 0)
        {
            BinaryReader reader = new BinaryReader(typeof(Class15).Assembly.GetManifestResourceStream("{11111-22222-20001-00000}"));
            reader.BaseStream.Position = 0L;

            RSACryptoServiceProvider.UseMachineKeyStore = true;
            byte[] buffer = reader.ReadBytes((int)reader.BaseStream.Length);
            byte[] rgbKey = new Class15().method_3();
            byte[] rgbIV = new Class15().method_2();
            byte[] publicKeyToken = typeof(Class15).Assembly.GetName().GetPublicKeyToken();
            if ((publicKeyToken != null) && (publicKeyToken.Length > 0))
            {
                rgbIV[1] = publicKeyToken[0];
                rgbIV[3] = publicKeyToken[1];
                rgbIV[5] = publicKeyToken[2];
                rgbIV[7] = publicKeyToken[3];
                rgbIV[9] = publicKeyToken[4];
                rgbIV[11] = publicKeyToken[5];
                rgbIV[13] = publicKeyToken[6];
                rgbIV[15] = publicKeyToken[7];
            }
            //ICryptoTransform transform = new RijndaelManaged();

            //transform.CreateDecryptor(rgbKey, rgbIV);
            //MemoryStream stream = new MemoryStream();
            //CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
            //stream2.Write(buffer, 0, buffer.Length);
            //stream2.FlushFinalBlock();
            //byte_1 = stream.ToArray();
            //stream.Close();
            //stream2.Close();
            reader.Close();
        }
        if (byte_0.Length == 0)
        {
            byte_0 = smethod_7(smethod_6(typeof(Class15).Assembly).ToString());
        }
        int index = 0;
        try
        {
            index = BitConverter.ToInt32(new byte[] { byte_1[int_5], byte_1[int_5 + 1], byte_1[int_5 + 2], byte_1[int_5 + 3] }, 0);
        }
        catch
        {
        }
        try
        {
            if (byte_0[index] == 0x80)
            {
                return true;
            }
        }
        catch
        {
        }
        return false;
    }

    /* private scope */
    static string smethod_1(int int_5)
    {
        if (byte_2.Length == 0)
        {
            BinaryReader reader = null;
            reader.BaseStream.Position = 0L;
            RSACryptoServiceProvider.UseMachineKeyStore = true;
            byte[] buffer = reader.ReadBytes((int)reader.BaseStream.Length);
            byte[] buffer2 = new byte[0x20];
            buffer2[0] = 0x7c;
            buffer2[0] = 0x5f;
            buffer2[0] = 0x29;
            buffer2[1] = 0x57;
            buffer2[1] = 0x95;
            buffer2[1] = 0xda;
            buffer2[2] = 0x89;
            buffer2[2] = 0x83;
            buffer2[2] = 0xbd;
            buffer2[2] = 0x77;
            buffer2[3] = 0x9e;
            buffer2[3] = 0x93;
            buffer2[3] = 0xc1;
            buffer2[4] = 0x80;
            buffer2[4] = 0x85;
            buffer2[4] = 0x7f;
            buffer2[4] = 0x99;
            buffer2[4] = 0x67;
            buffer2[4] = 0x9f;
            buffer2[5] = 0x5c;
            buffer2[5] = 0xa6;
            buffer2[5] = 0x80;
            buffer2[5] = 0x8f;
            buffer2[5] = 0x5d;
            buffer2[6] = 0xa3;
            buffer2[6] = 0xac;
            buffer2[6] = 0x23;
            buffer2[7] = 0x7d;
            buffer2[7] = 0x5d;
            buffer2[7] = 0xde;
            buffer2[8] = 0x70;
            buffer2[8] = 0x71;
            buffer2[8] = 0xb1;
            buffer2[8] = 160;
            buffer2[8] = 0xa8;
            buffer2[8] = 0xb1;
            buffer2[9] = 0x98;
            buffer2[9] = 0x7b;
            buffer2[9] = 0x90;
            buffer2[9] = 0x5b;
            buffer2[9] = 150;
            buffer2[10] = 0x5b;
            buffer2[10] = 0x52;
            buffer2[10] = 0xa9;
            buffer2[10] = 0x72;
            buffer2[10] = 0x54;
            buffer2[10] = 0xf8;
            buffer2[11] = 0x4f;
            buffer2[11] = 0x6f;
            buffer2[11] = 0x44;
            buffer2[12] = 0x61;
            buffer2[12] = 170;
            buffer2[12] = 0xc4;
            buffer2[12] = 0x88;
            buffer2[12] = 0x5d;
            buffer2[13] = 0x39;
            buffer2[13] = 0x7a;
            buffer2[13] = 0x90;
            buffer2[13] = 0x6b;
            buffer2[13] = 0xa9;
            buffer2[14] = 0x9a;
            buffer2[14] = 0x88;
            buffer2[14] = 0x71;
            buffer2[14] = 0x93;
            buffer2[14] = 0x90;
            buffer2[14] = 0xd7;
            buffer2[15] = 0x92;
            buffer2[15] = 0xe2;
            buffer2[15] = 0x52;
            buffer2[15] = 0x9c;
            buffer2[0x10] = 0x67;
            buffer2[0x10] = 0x2f;
            buffer2[0x10] = 0x5f;
            buffer2[0x10] = 0x66;
            buffer2[0x10] = 3;
            buffer2[0x11] = 0x6a;
            buffer2[0x11] = 0xa7;
            buffer2[0x11] = 0x6c;
            buffer2[0x11] = 0x19;
            buffer2[0x12] = 0x9a;
            buffer2[0x12] = 0x18;
            buffer2[0x12] = 0x7f;
            buffer2[0x13] = 0x9a;
            buffer2[0x13] = 0x74;
            buffer2[0x13] = 0x5d;
            buffer2[0x13] = 0x56;
            buffer2[0x13] = 0x63;
            buffer2[0x13] = 0xe2;
            buffer2[20] = 0x7d;
            buffer2[20] = 0x8f;
            buffer2[20] = 0x93;
            buffer2[20] = 0x65;
            buffer2[20] = 0x74;
            buffer2[20] = 0x31;
            buffer2[0x15] = 0x84;
            buffer2[0x15] = 0xbd;
            buffer2[0x15] = 0x89;
            buffer2[0x16] = 0x67;
            buffer2[0x16] = 0x1d;
            buffer2[0x16] = 110;
            buffer2[0x16] = 0x52;
            buffer2[0x16] = 0x30;
            buffer2[0x16] = 0x2e;
            buffer2[0x17] = 200;
            buffer2[0x17] = 0xbf;
            buffer2[0x17] = 0x6c;
            buffer2[0x17] = 0xf4;
            buffer2[0x18] = 0x58;
            buffer2[0x18] = 110;
            buffer2[0x18] = 150;
            buffer2[0x18] = 0x81;
            buffer2[0x18] = 0x7a;
            buffer2[0x18] = 0xab;
            buffer2[0x19] = 0x72;
            buffer2[0x19] = 0x66;
            buffer2[0x19] = 120;
            buffer2[0x19] = 0xa2;
            buffer2[0x19] = 0x5e;
            buffer2[0x19] = 30;
            buffer2[0x1a] = 150;
            buffer2[0x1a] = 0x9f;
            buffer2[0x1a] = 90;
            buffer2[0x1a] = 0xc9;
            buffer2[0x1a] = 0x83;
            buffer2[0x1b] = 0x56;
            buffer2[0x1b] = 100;
            buffer2[0x1b] = 0x94;
            buffer2[0x1b] = 0x81;
            buffer2[0x1b] = 0x37;
            buffer2[0x1b] = 0xcf;
            buffer2[0x1c] = 0xa2;
            buffer2[0x1c] = 0x8f;
            buffer2[0x1c] = 0x97;
            buffer2[0x1c] = 0x4e;
            buffer2[0x1c] = 110;
            buffer2[0x1c] = 0xa2;
            buffer2[0x1d] = 0x9d;
            buffer2[0x1d] = 0x6c;
            buffer2[0x1d] = 0x95;
            buffer2[0x1d] = 0x6d;
            buffer2[0x1d] = 90;
            buffer2[30] = 0x18;
            buffer2[30] = 0x92;
            buffer2[30] = 0x3b;
            buffer2[0x1f] = 150;
            buffer2[0x1f] = 0x6a;
            buffer2[0x1f] = 0x8e;
            buffer2[0x1f] = 0xa2;
            buffer2[0x1f] = 0xf2;
            byte[] rgbKey = buffer2;
            byte[] buffer4 = new byte[0x10];
            buffer4[0] = 0x7c;
            buffer4[0] = 0x69;
            buffer4[0] = 0xd4;
            buffer4[1] = 0x4c;
            buffer4[1] = 0xb0;
            buffer4[1] = 0x72;
            buffer4[1] = 160;
            buffer4[2] = 0xc1;
            buffer4[2] = 0x98;
            buffer4[2] = 0x56;
            buffer4[2] = 0xc1;
            buffer4[3] = 0x86;
            buffer4[3] = 0x7d;
            buffer4[3] = 0x9d;
            buffer4[3] = 0x81;
            buffer4[3] = 0x57;
            buffer4[4] = 0xb6;
            buffer4[4] = 0x74;
            buffer4[4] = 0x5d;
            buffer4[4] = 0x71;
            buffer4[4] = 0x49;
            buffer4[5] = 0x54;
            buffer4[5] = 0x7c;
            buffer4[5] = 40;
            buffer4[5] = 0x9b;
            buffer4[6] = 0x8a;
            buffer4[6] = 0x98;
            buffer4[6] = 0x56;
            buffer4[7] = 0x6a;
            buffer4[7] = 0x80;
            buffer4[7] = 130;
            buffer4[7] = 0x67;
            buffer4[7] = 12;
            buffer4[8] = 0x84;
            buffer4[8] = 0xac;
            buffer4[8] = 120;
            buffer4[8] = 0x5b;
            buffer4[9] = 100;
            buffer4[9] = 0x33;
            buffer4[9] = 0xa6;
            buffer4[9] = 150;
            buffer4[9] = 0x90;
            buffer4[9] = 0x42;
            buffer4[10] = 0x55;
            buffer4[10] = 0x8b;
            buffer4[10] = 0x73;
            buffer4[10] = 0xa6;
            buffer4[10] = 0x6c;
            buffer4[10] = 0x24;
            buffer4[11] = 0xa2;
            buffer4[11] = 0x59;
            buffer4[11] = 0xe7;
            buffer4[12] = 0x98;
            buffer4[12] = 0x60;
            buffer4[12] = 1;
            buffer4[13] = 0x8f;
            buffer4[13] = 0x6a;
            buffer4[13] = 0x6f;
            buffer4[14] = 0x74;
            buffer4[14] = 0x7c;
            buffer4[14] = 110;
            buffer4[14] = 0x77;
            buffer4[14] = 0x5e;
            buffer4[14] = 0x6d;
            buffer4[15] = 160;
            buffer4[15] = 0x7a;
            buffer4[15] = 0xa7;
            buffer4[15] = 0xeb;
            byte[] rgbIV = buffer4;
            byte[] publicKeyToken = typeof(Class15).Assembly.GetName().GetPublicKeyToken();
            if ((publicKeyToken != null) && (publicKeyToken.Length > 0))
            {
                rgbIV[1] = publicKeyToken[0];
                rgbIV[3] = publicKeyToken[1];
                rgbIV[5] = publicKeyToken[2];
                rgbIV[7] = publicKeyToken[3];
                rgbIV[9] = publicKeyToken[4];
                rgbIV[11] = publicKeyToken[5];
                rgbIV[13] = publicKeyToken[6];
                rgbIV[15] = publicKeyToken[7];
            }
            ICryptoTransform transform = null;
            MemoryStream stream = new MemoryStream();
            CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
            stream2.Write(buffer, 0, buffer.Length);
            stream2.FlushFinalBlock();
            byte_2 = stream.ToArray();
            stream.Close();
            stream2.Close();
            reader.Close();
        }
        int count = BitConverter.ToInt32(byte_2, int_5);
        try
        {
            return Encoding.Unicode.GetString(byte_2, int_5 + 4, count);
        }
        catch
        {
        }
        return "";
    }

    internal static string smethod_2(string string_1)
    {
        "{11111-22222-50001-00000}".Trim();
        byte[] bytes = Convert.FromBase64String(string_1);
        return Encoding.Unicode.GetString(bytes, 0, bytes.Length);
    }

    internal static uint smethod_3([MarshalAs(UnmanagedType.U8)] ref ulong ulong_0, IntPtr intptr_3, IntPtr intptr_4, [MarshalAs(UnmanagedType.U4)] uint uint_0, ref IntPtr intptr_5, ref uint uint_1)
    {
        if (!bool_1)
        {
            bool_1 = true;
            intptr_2 = Marshal.ReadIntPtr(intptr_4, IntPtr.Size);
            return delegate1_0(ref ulong_0, intptr_3, intptr_4, uint_0, ref intptr_5, ref uint_1);
        }
        if (intptr_2 == Marshal.ReadIntPtr(intptr_4, IntPtr.Size))
        {
            if (IntPtr.Size == 4)
            {
                try
                {
                    Struct0 struct2;
                    int num = Marshal.ReadInt32(intptr_4, 8);
                    if (!dictionary_0.TryGetValue((long)num, out struct2))
                    {
                        goto Label_0192;
                    }
                    IntPtr destination = Marshal.AllocCoTaskMem(struct2.byte_0.Length);
                    Marshal.Copy(struct2.byte_0, 0, destination, struct2.byte_0.Length);
                    if (struct2.bool_0)
                    {
                        intptr_5 = destination;
                        uint_1 = (uint)struct2.byte_0.Length;
                        VirtualProtect_1(intptr_5, struct2.byte_0.Length, 0x40, ref num);
                        return 0;
                    }
                    Marshal.WriteIntPtr(intptr_4, 8, destination);
                    Marshal.WriteInt32(intptr_4, 12, struct2.byte_0.Length);
                    return delegate1_0(ref ulong_0, intptr_3, intptr_4, uint_0, ref intptr_5, ref uint_1);
                }
                catch
                {
                    goto Label_0192;
                }
            }
            try
            {
                Struct0 struct3;
                long key = Marshal.ReadInt64(intptr_4, 0x10);
                if (dictionary_0.TryGetValue(key, out struct3))
                {
                    IntPtr ptr2 = Marshal.AllocCoTaskMem(struct3.byte_0.Length);
                    Marshal.Copy(struct3.byte_0, 0, ptr2, struct3.byte_0.Length);
                    if (struct3.bool_0)
                    {
                        intptr_5 = ptr2;
                        uint_1 = (uint)struct3.byte_0.Length;
                        VirtualProtect_1(intptr_5, struct3.byte_0.Length, 0x40, ref int_4);
                        return 0;
                    }
                    Marshal.WriteIntPtr(intptr_4, 0x10, ptr2);
                    Marshal.WriteInt32(intptr_4, 0x18, struct3.byte_0.Length);
                }
            }
            catch
            {
            }
        }
    Label_0192:
        return delegate1_0(ref ulong_0, intptr_3, intptr_4, uint_0, ref intptr_5, ref uint_1);
    }

    private static void smethod_4()
    {
    }

    /* private scope */
    public static void smethod_5()
    {
        if (bool_0)
        {
            return;
        }
        bool_0 = true;
        try
        {
            RSACryptoServiceProvider.UseMachineKeyStore = true;
        }
        catch
        {
        }
        BinaryReader reader = new BinaryReader(typeof(Class15).Assembly.GetManifestResourceStream("d97b1e3b-c718-46f3-9683-d091e14e61fd")) ;
        reader.BaseStream.Position = 0L;
        byte[] buffer4 = reader.ReadBytes((int) reader.BaseStream.Length);
        byte[] buffer5 = new byte[0x20];
        buffer5[0] = 0xb0;
        buffer5[0] = 0x88;
        buffer5[0] = 150;
        buffer5[1] = 0x33;
        buffer5[1] = 0x97;
        buffer5[1] = 6;
        buffer5[2] = 0x83;
        buffer5[2] = 0x63;
        buffer5[2] = 0x55;
        buffer5[2] = 0xc5;
        buffer5[2] = 0xa9;
        buffer5[3] = 0x88;
        buffer5[3] = 0x6b;
        buffer5[3] = 0x5e;
        buffer5[3] = 0x5b;
        buffer5[4] = 0x7e;
        buffer5[4] = 0x86;
        buffer5[4] = 0xb5;
        buffer5[4] = 0xa9;
        buffer5[5] = 0xa9;
        buffer5[5] = 0x87;
        buffer5[5] = 0x68;
        buffer5[5] = 0x68;
        buffer5[5] = 0xe9;
        buffer5[6] = 0xb2;
        buffer5[6] = 0x88;
        buffer5[6] = 0x52;
        buffer5[6] = 0x25;
        buffer5[6] = 0xc0;
        buffer5[7] = 90;
        buffer5[7] = 0x49;
        buffer5[7] = 0x9b;
        buffer5[8] = 0x63;
        buffer5[8] = 150;
        buffer5[8] = 0x6a;
        buffer5[8] = 0x4c;
        buffer5[8] = 0x42;
        buffer5[8] = 170;
        buffer5[9] = 0x74;
        buffer5[9] = 0x94;
        buffer5[9] = 0x7f;
        buffer5[9] = 0x31;
        buffer5[10] = 0x7d;
        buffer5[10] = 0x58;
        buffer5[10] = 0x75;
        buffer5[10] = 0x53;
        buffer5[11] = 0xb3;
        buffer5[11] = 0x1d;
        buffer5[11] = 0x54;
        buffer5[11] = 0x67;
        buffer5[11] = 140;
        buffer5[11] = 0xa9;
        buffer5[12] = 0x7a;
        buffer5[12] = 140;
        buffer5[12] = 160;
        buffer5[12] = 0x9f;
        buffer5[12] = 0x70;
        buffer5[13] = 0x5d;
        buffer5[13] = 0x8e;
        buffer5[13] = 0x61;
        buffer5[14] = 0xa4;
        buffer5[14] = 0x57;
        buffer5[14] = 0x73;
        buffer5[14] = 120;
        buffer5[14] = 0x58;
        buffer5[14] = 90;
        buffer5[15] = 0x65;
        buffer5[15] = 0x65;
        buffer5[15] = 0x4d;
        buffer5[15] = 0x8a;
        buffer5[15] = 190;
        buffer5[0x10] = 170;
        buffer5[0x10] = 0xa3;
        buffer5[0x10] = 0x7e;
        buffer5[0x10] = 0x91;
        buffer5[0x10] = 0x57;
        buffer5[0x11] = 0x9b;
        buffer5[0x11] = 120;
        buffer5[0x11] = 0xf5;
        buffer5[0x12] = 0x67;
        buffer5[0x12] = 0x65;
        buffer5[0x12] = 0x4a;
        buffer5[0x13] = 0x92;
        buffer5[0x13] = 0x95;
        buffer5[0x13] = 0x76;
        buffer5[0x13] = 0xaf;
        buffer5[0x13] = 0x56;
        buffer5[20] = 0xba;
        buffer5[20] = 0x3f;
        buffer5[20] = 0x92;
        buffer5[20] = 0x91;
        buffer5[20] = 100;
        buffer5[0x15] = 0x87;
        buffer5[0x15] = 0x60;
        buffer5[0x15] = 0x85;
        buffer5[0x15] = 0x81;
        buffer5[0x15] = 0xb7;
        buffer5[0x16] = 0x87;
        buffer5[0x16] = 0x9f;
        buffer5[0x16] = 0x5d;
        buffer5[0x17] = 0xec;
        buffer5[0x17] = 0x98;
        buffer5[0x17] = 0xb3;
        buffer5[0x18] = 0xa8;
        buffer5[0x18] = 0x9a;
        buffer5[0x18] = 0x7a;
        buffer5[0x18] = 0x13;
        buffer5[0x19] = 190;
        buffer5[0x19] = 0xa4;
        buffer5[0x19] = 0xa8;
        buffer5[0x19] = 0x74;
        buffer5[0x1a] = 0x94;
        buffer5[0x1a] = 120;
        buffer5[0x1a] = 0x43;
        buffer5[0x1a] = 0x86;
        buffer5[0x1a] = 0xef;
        buffer5[0x1b] = 0xb1;
        buffer5[0x1b] = 0x15;
        buffer5[0x1b] = 0xe7;
        buffer5[0x1b] = 0xc9;
        buffer5[0x1b] = 0x33;
        buffer5[0x1c] = 0x8f;
        buffer5[0x1c] = 0x59;
        buffer5[0x1c] = 0xa4;
        buffer5[0x1c] = 120;
        buffer5[0x1c] = 0x11;
        buffer5[0x1c] = 0xb2;
        buffer5[0x1d] = 0x4d;
        buffer5[0x1d] = 0x63;
        buffer5[0x1d] = 140;
        buffer5[0x1d] = 0xa4;
        buffer5[0x1d] = 0x34;
        buffer5[30] = 0x6c;
        buffer5[30] = 0x7f;
        buffer5[30] = 90;
        buffer5[30] = 0xb7;
        buffer5[0x1f] = 0x57;
        buffer5[0x1f] = 0x70;
        buffer5[0x1f] = 0x70;
        buffer5[0x1f] = 0x7a;
        buffer5[0x1f] = 0x3a;
        byte[] rgbKey = buffer5;
        byte[] buffer7 = new byte[0x10];
        buffer7[0] = 0x7a;
        buffer7[0] = 0x8b;
        buffer7[0] = 0x26;
        buffer7[1] = 0x39;
        buffer7[1] = 0x68;
        buffer7[1] = 0xa6;
        buffer7[1] = 0x5b;
        buffer7[1] = 0x27;
        buffer7[1] = 0xe4;
        buffer7[2] = 0x84;
        buffer7[2] = 0x9c;
        buffer7[2] = 0x62;
        buffer7[2] = 120;
        buffer7[2] = 0x8d;
        buffer7[2] = 0xa8;
        buffer7[3] = 0x58;
        buffer7[3] = 0x9e;
        buffer7[3] = 0x73;
        buffer7[3] = 0xa8;
        buffer7[3] = 0x19;
        buffer7[3] = 0xa4;
        buffer7[4] = 0x6a;
        buffer7[4] = 0x7e;
        buffer7[4] = 0xba;
        buffer7[4] = 0x48;
        buffer7[4] = 0x3b;
        buffer7[4] = 0xf7;
        buffer7[5] = 0x56;
        buffer7[5] = 0x8f;
        buffer7[5] = 0x57;
        buffer7[5] = 0x7a;
        buffer7[5] = 0x80;
        buffer7[6] = 0x6c;
        buffer7[6] = 0x4a;
        buffer7[6] = 0x72;
        buffer7[6] = 0x5f;
        buffer7[6] = 0xc7;
        buffer7[6] = 6;
        buffer7[7] = 0x8e;
        buffer7[7] = 0x52;
        buffer7[7] = 0x83;
        buffer7[7] = 0x54;
        buffer7[7] = 0x80;
        buffer7[8] = 0x7d;
        buffer7[8] = 0x24;
        buffer7[8] = 0xa6;
        buffer7[8] = 0x6d;
        buffer7[8] = 0x69;
        buffer7[8] = 0x86;
        buffer7[9] = 0x83;
        buffer7[9] = 100;
        buffer7[9] = 0xac;
        buffer7[10] = 0x62;
        buffer7[10] = 0x7a;
        buffer7[10] = 0x36;
        buffer7[10] = 0x7e;
        buffer7[10] = 0x79;
        buffer7[10] = 0xb9;
        buffer7[11] = 0x9b;
        buffer7[11] = 0x5b;
        buffer7[11] = 0x83;
        buffer7[11] = 0xd3;
        buffer7[11] = 0xe4;
        buffer7[12] = 0xa1;
        buffer7[12] = 0x57;
        buffer7[12] = 0x88;
        buffer7[12] = 0xa2;
        buffer7[12] = 14;
        buffer7[13] = 0x71;
        buffer7[13] = 0x66;
        buffer7[13] = 0x43;
        buffer7[13] = 0x86;
        buffer7[13] = 15;
        buffer7[14] = 0x58;
        buffer7[14] = 0x6c;
        buffer7[14] = 0xa2;
        buffer7[14] = 0x41;
        buffer7[15] = 0x86;
        buffer7[15] = 0x84;
        buffer7[15] = 0xd1;
        byte[] rgbIV = buffer7;
        byte[] publicKeyToken = typeof(Class15).Assembly.GetName().GetPublicKeyToken();
        if ((publicKeyToken != null) && (publicKeyToken.Length > 0))
        {
            rgbIV[1] = publicKeyToken[0];
            rgbIV[3] = publicKeyToken[1];
            rgbIV[5] = publicKeyToken[2];
            rgbIV[7] = publicKeyToken[3];
            rgbIV[9] = publicKeyToken[4];
            rgbIV[11] = publicKeyToken[5];
            rgbIV[13] = publicKeyToken[6];
            rgbIV[15] = publicKeyToken[7];
        }
        ICryptoTransform transform = null;
        MemoryStream stream = new MemoryStream();
        CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
        stream2.Write(buffer4, 0, buffer4.Length);
        stream2.FlushFinalBlock();
        byte[] buffer8 = stream.ToArray();
        stream.Close();
        stream2.Close();
        reader.Close();
        reader = null;

        long num8 = Marshal.GetHINSTANCE(typeof(Class15).Assembly.GetModules()[0]).ToInt64();
        int num9 = 0;
        int num = 0;
        if ((typeof(Class15).Assembly.Location == null) || (typeof(Class15).Assembly.Location.Length == 0))
        {
            num = 0x1c00;
        }
        if (Environment.GetEnvironmentVariable("Cor_Enable_Profiling") == "1")
        {
            return;
        }
        int num4 = reader.ReadInt32();
        if (reader.ReadInt32() == 1)
        {
            IntPtr ptr = IntPtr.Zero;
            Assembly assembly = typeof(Class15).Assembly;
            ptr = OpenProcess(0x38, 1, (uint) Process.GetCurrentProcess().Id);
            int_2 = Marshal.GetHINSTANCE(assembly.GetModules()[0]).ToInt32();
            long_0 = Marshal.GetHINSTANCE(assembly.GetModules()[0]).ToInt64();
            IntPtr ptr2 = IntPtr.Zero;
            for (int j = 0; j < num4; j++)
            {
                if (IntPtr.Size == 4)
                {
                    WriteProcessMemory(ptr, new IntPtr((int_2 + reader.ReadInt32()) - num), BitConverter.GetBytes(reader.ReadInt32()), 4, out ptr2);
                }
                else
                {
                    WriteProcessMemory(ptr, new IntPtr((long_0 + reader.ReadInt32()) - num), BitConverter.GetBytes(reader.ReadInt32()), 4, out ptr2);
                }
            }
            while (reader.BaseStream.Position < (reader.BaseStream.Length - 1L))
            {
                int num14 = reader.ReadInt32();
                reader.ReadInt32();
                int count = reader.ReadInt32();
                byte[] buffer10 = reader.ReadBytes(count);
                if (IntPtr.Size == 4)
                {
                    WriteProcessMemory(ptr, new IntPtr(int_2 + num14), buffer10, Convert.ToUInt32(count), out ptr2);
                }
                else
                {
                    WriteProcessMemory(ptr, new IntPtr(long_0 + num14), buffer10, Convert.ToUInt32(count), out ptr2);
                }
            }
            CloseHandle(ptr);
            return;
        }
        for (int i = 0; i < num4; i++)
        {
            IntPtr ptr12 = new IntPtr((num8 + reader.ReadInt32()) - num);
            VirtualProtect_1(ptr12, 4, 4, ref num9);
            Marshal.WriteInt32(ptr12, reader.ReadInt32());
            VirtualProtect_1(ptr12, 4, num9, ref num9);
        }
        dictionary_0 = new Dictionary<long, Struct0>(reader.ReadInt32());
        bool flag = false;
        while (reader.BaseStream.Position < (reader.BaseStream.Length - 1L))
        {
            int num5 = reader.ReadInt32() - num;
            int num6 = reader.ReadInt32();
            flag = false;
            if (num6 >= 0x70000000)
            {
                flag = true;
            }
            int num17 = reader.ReadInt32();
            byte[] buffer11 = reader.ReadBytes(num17);
            Struct0 struct2 = new Struct0();
            struct2.byte_0 = buffer11;
            struct2.bool_0 = flag;
            dictionary_0.Add(num8 + num5, struct2);
        }
        long_1 = Marshal.GetHINSTANCE(typeof(Class15).Assembly.GetModules()[0]).ToInt64();
        if (IntPtr.Size == 4)
        {
            int_3 = Convert.ToInt32(long_1);
        }
        byte[] bytes = new byte[] { 0x6d, 0x73, 0x63, 0x6f, 0x72, 0x6a, 0x69, 0x74, 0x2e, 100, 0x6c, 0x6c };
        string str = Encoding.UTF8.GetString(bytes);
        IntPtr ptr3 = LoadLibrary(str);
        if (ptr3 == IntPtr.Zero)
        {
            bytes = new byte[] { 0x63, 0x6c, 0x72, 0x6a, 0x69, 0x74, 0x2e, 100, 0x6c, 0x6c };
            str = Encoding.UTF8.GetString(bytes);
            ptr3 = LoadLibrary(str);
        }
        byte[] buffer9 = new byte[] { 0x67, 0x65, 0x74, 0x4a, 0x69, 0x74 };
        string str3 = Encoding.UTF8.GetString(buffer9);
        Delegate2 delegateForFunctionPointer = (Delegate2) Marshal.GetDelegateForFunctionPointer(GetProcAddress(ptr3, str3), typeof(Delegate2));
        IntPtr ptr4 = delegateForFunctionPointer();
        long num2 = 0L;
        if (IntPtr.Size == 4)
        {
            num2 = Marshal.ReadInt32(ptr4);
        }
        else
        {
            num2 = Marshal.ReadInt64(ptr4);
        }
        delegate1_1 = new Delegate1(Class15.smethod_3);
        IntPtr zero = IntPtr.Zero;
        zero = Marshal.GetFunctionPointerForDelegate(delegate1_1);
        long num7 = 0L;
        if (IntPtr.Size == 4)
        {
            num7 = Marshal.ReadInt32(new IntPtr(num2));
        }
        else
        {
            num7 = Marshal.ReadInt64(new IntPtr(num2));
        }
        Process currentProcess = Process.GetCurrentProcess();
        try
        {
            foreach (ProcessModule module in currentProcess.Modules)
            {
                if (((module.ModuleName == str) && ((num7 < module.BaseAddress.ToInt64()) || (num7 > (module.BaseAddress.ToInt64() + module.ModuleMemorySize)))) && (typeof(Class15).Assembly.EntryPoint != null))
                {
                    return;
                }
            }
        }
        catch
        {
        }
        try
        {
            IEnumerator enumerator = currentProcess.Modules.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    ProcessModule current = (ProcessModule) enumerator.Current;
                    if (current.BaseAddress.ToInt64() == long_1)
                    {
                        goto Label_1116;
                    }
                }
                goto Label_1134;
            Label_1116:
                num = 0;
            
        }
        catch
        {
        }
    Label_1134:
        delegate1_0 = null;
        try
        {
            delegate1_0 = (Delegate1) Marshal.GetDelegateForFunctionPointer(new IntPtr(num7), typeof(Delegate1));
        }
        catch
        {
            try
            {
                Delegate delegate3 = Marshal.GetDelegateForFunctionPointer(new IntPtr(num7), typeof(Delegate1));
                delegate1_0 = (Delegate1) Delegate.CreateDelegate(typeof(Delegate1), delegate3.Method);
            }
            catch
            {
            }
        }
        ulong num10 = 0L;
        uint num11 = 0;
        IntPtr ptr11 = IntPtr.Zero;
        int num12 = 0;
        if (((typeof(Class15).Assembly.EntryPoint == null) || (typeof(Class15).Assembly.EntryPoint.GetParameters().Length != 2)) || ((typeof(Class15).Assembly.Location == null) || (typeof(Class15).Assembly.Location.Length <= 0)))
        {
            try
            {
                delegate1_1(ref num10, IntPtr.Zero, IntPtr.Zero, 0xcea448d, ref ptr11, ref num11);
            }
            catch
            {
            }
            bool_1 = false;
            VirtualProtect_1(new IntPtr(num2), IntPtr.Size, 4, ref num12);
            Marshal.WriteIntPtr(new IntPtr(num2), zero);
            VirtualProtect_1(new IntPtr(num2), IntPtr.Size, num12, ref num12);
            smethod_4();
        }
    }

    internal static object smethod_6(object object_0)
    {
        try
        {
            return object_0.GetType().GetProperty("Location").GetValue(object_0, new object[0]).ToString();
        }
        catch
        {
            return "";
        }
    }

    private static byte[] smethod_7(string string_1)
    {
        byte[] buffer;
        using (FileStream stream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read))
        {
            int offset = 0;
            int length = (int)stream.Length;
            buffer = new byte[length];
            while (length > 0)
            {
                int num4 = stream.Read(buffer, offset, length);
                offset += num4;
                length -= num4;
            }
        }
        return buffer;
    }

    private static byte[] smethod_8(byte[] byte_4)
    {
        MemoryStream stream = new MemoryStream();
        Rijndael rijndael = Rijndael.Create();
        rijndael.Key = new byte[] { 
            0x49, 0x6f, 0x2e, 0xba, 0xe3, 0x76, 0x13, 0x42, 0xa2, 0x99, 0x25, 0xe0, 0xeb, 0x89, 0xfc, 220, 
            0x42, 0xb3, 0x5f, 0x6a, 0xdb, 0x6b, 0xaf, 0xcd, 150, 0x10, 0xf9, 0x81, 0x4d, 0x84, 15, 11
         };
        rijndael.IV = new byte[] { 50, 0x2f, 0x7c, 0xf6, 0xd5, 0x94, 0x59, 0x37, 0xf4, 0x36, 0x4c, 0xc7, 0xfc, 0x30, 0xfb, 0x6d };
        CryptoStream stream2 = new CryptoStream(stream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
        stream2.Write(byte_4, 0, byte_4.Length);
        stream2.Close();
        return stream.ToArray();
    }

    internal static string smethod_9(string string_1, string string_2)
    {
        byte[] bytes = Encoding.Unicode.GetBytes(string_1);
        byte[] buffer3 = new byte[] { 
            0x52, 0x66, 0x68, 110, 0x20, 0x4d, 0x18, 0x22, 0x76, 0xb5, 0x33, 0x11, 0x12, 0x33, 12, 0x6d, 
            10, 0x20, 0x4d, 0x18, 0x22, 0x9e, 0xa1, 0x29, 0x61, 0x1c, 0x76, 0xb5, 5, 0x19, 1, 0x58
         };
        byte[] buffer4 = new MD5CryptoServiceProvider().ComputeHash(Encoding.Unicode.GetBytes(string_2));
        MemoryStream stream = new MemoryStream();
        Rijndael rijndael = Rijndael.Create();
        rijndael.Key = buffer3;
        rijndael.IV = buffer4;
        CryptoStream stream2 = new CryptoStream(stream, rijndael.CreateEncryptor(), CryptoStreamMode.Write);
        stream2.Write(bytes, 0, bytes.Length);
        stream2.Close();
        return Convert.ToBase64String(stream.ToArray());
    }

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern int VirtualProtect(ref IntPtr intptr_3, int int_5, int int_6, ref int int_7);
    [DllImport("kernel32.dll", EntryPoint = "VirtualProtect")]
    private static extern int VirtualProtect_1(IntPtr intptr_3, int int_5, int int_6, ref int int_7);
    [DllImport("kernel32.dll")]
    private static extern int WriteProcessMemory(IntPtr intptr_3, IntPtr intptr_4, [In, Out] byte[] byte_4, uint uint_0, out IntPtr intptr_5);
    private void ZwrbVGDEZwcrB()
    {
    }

    internal class Attribute0 : Attribute
    {
        static Attribute0()
        {
            Class15.smethod_5();
        }

        public Attribute0(object object_0)
        {
            Class17.smethod_0();
        }

        internal class Class16<T>
        {
            static Class16()
            {
                Class15.smethod_5();
            }

            public Class16()
            {
                Class17.smethod_0();
            }
        }
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate uint Delegate1([MarshalAs(UnmanagedType.U8)] ref ulong ulong_0, IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.U4)] uint uint_0, ref IntPtr intptr_2, ref uint uint_1);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    private delegate IntPtr Delegate2();

    [Flags]
    private enum Enum1
    {
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct Struct0
    {
        internal bool bool_0;
        internal byte[] byte_0;
        static Struct0()
        {
            Class15.smethod_5();
        }
    }
}

