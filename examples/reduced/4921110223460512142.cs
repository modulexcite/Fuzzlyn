// Generated by Fuzzlyn v1.1 on 2018-10-02 00:50:13
// Seed: 4921110223460512142
// Reduced from 6.9 KiB to 0.5 KiB in 00:00:13
// Debug: Outputs 254
// Release: Outputs 2
public class Program
{
    static short s_1;
    public static void Main()
    {
        M1(32767);
    }

    static void M1(short arg1)
    {
        arg1 += arg1;
        var vr0 = (byte)(arg1 % -12);
        if (M2(vr0))
        {
            try
            {
                System.Console.WriteLine(arg1);
            }
            finally
            {
                s_1 = arg1;
            }
        }
    }

    static bool M2(byte arg1)
    {
        System.Console.WriteLine(arg1);
        return false;
    }
}