// Generated by Fuzzlyn on 2018-07-24 06:54:23
// Seed: 7097239756350153113
// Reduced from 13.4 KiB to 0.5 KiB
// Debug: Runs successfully
// Release: Throws 'System.IndexOutOfRangeException'
public class Program
{
    static int[] s_3 = new int[]{0};
    public static void Main()
    {
        var vr8 = s_3[0];
        var vr11 = new int[][, ]{new int[, ]{{0}}};
        M6(0, true, vr8, 0, vr11);
    }

    static uint M6(ulong arg0, bool arg1, int arg2, long arg3, int[][, ] arg4)
    {
        arg0 = (ulong)('P' % ((arg4[0][0, 0] & 0) | 1));
        System.Console.WriteLine(arg2);
        System.Console.WriteLine(arg4[0][0, 0]);
        return 0;
    }
}
