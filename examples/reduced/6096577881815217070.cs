// Generated by Fuzzlyn v1.1 on 2018-09-19 10:55:31
// Seed: 6096577881815217070
// Reduced from 225.0 KiB to 0.7 KiB in 00:04:31
// Debug: Outputs 0
// Release: Outputs -25
class C3
{
    public bool F1;
}

public class Program
{
    static int s_4;
    static sbyte s_7;
    static C3 s_13;
    static bool[] s_18 = new bool[]{true};
    static sbyte[] s_22 = new sbyte[]{0};
    public static void Main()
    {
        sbyte vr9 = s_7--;
        var vr12 = s_22[0];
        M30(vr12);
    }

    static void M30(sbyte arg0)
    {
        arg0 = s_7;
        arg0 /= -10;
        if (!s_18[0])
        {
            try
            {
                bool vr1 = s_13.F1;
            }
            finally
            {
                arg0 <<= s_4;
            }
        }

        System.Console.WriteLine(arg0);
    }
}
