// Generated by Fuzzlyn v1.1 on 2018-09-04 18:42:01
// Seed: 14678652509375494566
// Reduced from 263.2 KiB to 0.5 KiB in 00:04:30
// Debug: Outputs 47
// Release: Outputs -3080145
public class Program
{
    static short s_71 = -1;
    static bool[] s_96;
    public static void Main()
    {
        M84(s_96, 0);
    }

    static void M84(bool[] arg0, short arg1)
    {
        try
        {
            arg0 = new bool[]{true};
        }
        finally
        {
            System.Console.WriteLine(arg1);
        }

        arg1 = s_71;
        var vr0 = -47 * arg1;
        System.Console.WriteLine(vr0);
    }
}
