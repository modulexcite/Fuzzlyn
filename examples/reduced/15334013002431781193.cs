// Generated by Fuzzlyn v1.1 on 2018-09-30 05:24:25
// Seed: 15334013002431781193
// Reduced from 163.3 KiB to 0.6 KiB in 00:01:38
// Debug: Outputs 2137604228
// Release: Outputs 371768452
struct S0
{
    public byte F0;
}

public class Program
{
    static sbyte s_1 = -1;
    static byte s_2;
    public static void Main()
    {
        var vr3 = new S0();
        M7(vr3, 1);
    }

    static void M7(S0 arg0, sbyte arg1)
    {
        try
        {
            s_2 = arg0.F0;
        }
        finally
        {
            if (0 == arg1)
            {
                uint[] var1 = new uint[]{0};
            }
        }

        arg1 = s_1;
        var vr1 = -2137604228 * arg1;
        System.Console.WriteLine(vr1);
    }
}