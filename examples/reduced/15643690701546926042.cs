// Generated by Fuzzlyn v1.1 on 2018-09-09 01:31:33
// Seed: 15643690701546926042
// Reduced from 54.8 KiB to 0.7 KiB in 00:00:57
// Debug: Outputs 0
// Release: Outputs 32
public class Program
{
    static sbyte[] s_3 = new sbyte[]{0};
    static sbyte s_17 = -1;
    static byte[] s_22 = new byte[]{1};
    public static void Main()
    {
        M19(s_17);
    }

    static void M19(sbyte arg0)
    {
        arg0 = s_3[0];
        arg0 /= -8;
        try
        {
            byte var27 = s_22[0];
        }
        finally
        {
            try
            {
                byte var28 = (byte)M25();
            }
            finally
            {
                M22();
            }
        }

        System.Console.WriteLine(arg0);
    }

    static bool M22()
    {
        return default(bool);
    }

    static int M25()
    {
        return default(int);
    }
}