// Generated by Fuzzlyn v1.1 on 2018-09-03 09:39:11
// Seed: 2726768101932171337
// Reduced from 59.0 KiB to 0.7 KiB in 00:01:05
// Debug: Outputs 0
// Release: Outputs -736
public class Program
{
    static ulong[][] s_1 = new ulong[][]{new ulong[]{0}};
    static long s_3;
    static ushort s_7;
    public static void Main()
    {
        M10(ref s_7, 1);
    }

    static void M10(ref ushort arg0, short arg1)
    {
        ulong vr16 = s_1[0][0];
        arg1 = (short)vr16;
        try
        {
            arg0 = 0;
        }
        finally
        {
            var vr4 = s_1[0][0];
            long var28 = M12(arg1, vr4);
        }

        var vr2 = arg1--;
        var vr3 = arg1 / -89;
        System.Console.WriteLine(vr3);
    }

    static ref long M12(short arg2, ulong arg4)
    {
        System.Console.WriteLine(arg4);
        return ref s_3;
    }
}
