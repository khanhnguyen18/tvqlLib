using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class14
{
    internal static Module module_0;

    static Class14()
    {
        Class15.smethod_5();
        Class17.smethod_0();
        module_0 = typeof(Class14).Assembly.ManifestModule;
    }

    public Class14()
    {
        Class17.smethod_0();
    }

    internal static void hOGbVGDD5VsHa(int typemdt)
    {
        Type type = module_0.ResolveType(0x2000000 + typemdt);
        foreach (FieldInfo info in type.GetFields())
        {
            MethodInfo method = (MethodInfo) module_0.ResolveMethod(info.MetadataToken + 0x6000000);
            info.SetValue(null, (MulticastDelegate) Delegate.CreateDelegate(type, method));
        }
    }

    internal delegate void Delegate0(object o);
}

