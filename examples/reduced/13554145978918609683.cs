// Generated by Fuzzlyn v1.1 on 2018-09-10 01:54:04
// Seed: 13554145978918609683
// Reduced from 340.0 KiB to 1.0 KiB in 00:10:18
// Debug: Outputs 0
// Release: Outputs -2
class C0
{
    public int F0;
    public long F3;
}

public class Program
{
    static ushort[] s_15;
    static bool[] s_51;
    static sbyte s_67;
    static byte[] s_69;
    public static void Main()
    {
        s_51 = new bool[]{true};
        M87(-1);
    }

    static void M87(sbyte arg0)
    {
        C0[] var24 = default(C0[]);
        if (s_51[0])
        {
            arg0 = s_67;
            arg0 %= (-128 | 1);
        }
        else
        {
            try
            {
                var vr1 = new ulong[]{0};
            }
            finally
            {
                var vr0 = new ulong[]{0, 0, 0, 0, 0, 0, 1, 0};
                M88() = new ushort[]{0, 0, 1, 0, 0, 1, 0, 0, 1};
                s_69 = new byte[]{1};
                System.Console.WriteLine(var24[0].F0);
                System.Console.WriteLine(var24[0].F3);
            }
        }

        System.Console.WriteLine(arg0);
    }

    static ref ushort[] M88()
    {
        return ref s_15;
    }
}