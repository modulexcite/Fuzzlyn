// Generated by Fuzzlyn v1.1 on 2018-08-29 06:47:52
// Seed: 11306942410879306027
// Reduced from 46.5 KiB to 0.4 KiB in 00:01:23
// Debug: Outputs 14
// Release: Outputs -3570
public class Program
{
    static int s_7;
    public static void Main()
    {
        var vr2 = M14(-1);
        System.Console.WriteLine(s_7);
    }

    static uint M14(sbyte arg0)
    {
        try
        {
            arg0 = 1;
            arg0 >>= s_7;
            s_7 = 14 * arg0;
        }
        finally
        {
            sbyte var8 = arg0++;
        }

        return 0;
    }
}