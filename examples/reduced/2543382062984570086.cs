// Generated by Fuzzlyn v1.1 on 2018-09-13 07:39:52
// Seed: 2543382062984570086
// Reduced from 210.1 KiB to 1.1 KiB in 00:04:40
// Debug: Outputs 0
// Release: Outputs 5
struct S0
{
    public ulong F0;
    public short F1;
    public byte F2;
    public ulong F3;
    public short F4;
}

public class Program
{
    static bool s_8;
    static S0 s_12;
    static short s_15 = -1;
    static ushort s_18;
    static ulong s_21;
    static byte s_22;
    public static void Main()
    {
        var vr7 = new S0();
        var vr10 = vr7.F4;
        M24(vr10, false);
    }

    static void M24(short arg0, bool arg1)
    {
        ushort var0 = default(ushort);
        if (s_8)
        {
            var0 = var0;
        }

        arg0 = s_15;
        arg0 /= 11955;
        try
        {
            if (arg1)
            {
                arg1 = arg1;
            }
        }
        finally
        {
            var0 = s_18;
            S0 var7 = s_12;
            var7.F3 = var7.F3;
            s_21 = 0;
            var7.F4 = 0;
            s_22 = var7.F2;
            System.Console.WriteLine(var7.F0);
            System.Console.WriteLine(var7.F1);
            System.Console.WriteLine(var7.F2);
        }

        System.Console.WriteLine(arg0);
    }
}