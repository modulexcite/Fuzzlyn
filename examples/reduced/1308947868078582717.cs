// Generated by Fuzzlyn v1.1 on 2018-09-09 23:39:58
// Seed: 1308947868078582717
// Reduced from 272.0 KiB to 0.6 KiB in 00:04:41
// Debug: Outputs 0
// Release: Outputs 32512
public class Program
{
    static byte s_51;
    static bool s_62;
    static sbyte s_94;
    public static void Main()
    {
        M16(s_94);
    }

    static void M16(sbyte arg0)
    {
        try
        {
            bool vr0 = M21();
        }
        finally
        {
            arg0 -= arg0;
        }

        arg0 = -1;
        if (s_62)
        {
            arg0 -= (sbyte)s_51;
        }

        arg0++;
        uint var11 = (uint)(-127 * arg0);
        System.Console.WriteLine(var11);
    }

    static bool M21()
    {
        return default(bool);
    }
}
