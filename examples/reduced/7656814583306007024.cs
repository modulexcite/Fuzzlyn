// Generated by Fuzzlyn v1.1 on 2018-09-23 20:32:54
// Seed: 7656814583306007024
// Reduced from 146.7 KiB to 1.0 KiB in 00:02:49
// Debug: Outputs 0
// Release: Outputs 1410727936
public class Program
{
    static int s_19;
    static sbyte[] s_45 = new sbyte[]{0};
    static ushort s_51;
    public static void Main()
    {
        sbyte vr5 = s_45[0]--;
        sbyte vr6 = s_45[0];
        M52(vr6);
        System.Console.WriteLine(s_19);
    }

    static void M52(short arg2)
    {
        bool var41 = default(bool);
        arg2 = (short)s_51;
        s_19 = arg2 * 44010;
        try
        {
            M53();
        }
        finally
        {
            var vr0 = new sbyte[]{1};
            long vr8 = default(long);
            short var21 = (short)vr8;
            short[] var42 = new short[]{0, 0, 0, 0, 0, 0, 1, 0, 0};
            short var43 = var21;
            System.Console.WriteLine(var41);
            System.Console.WriteLine(var43);
            System.Console.WriteLine(-44);
        }

        System.Console.WriteLine(arg2);
    }

    static ushort M53()
    {
        return s_51;
    }
}