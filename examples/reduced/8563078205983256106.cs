// Generated by Fuzzlyn on 2018-06-25 14:58:40
// Seed: 8563078205983256106
// Reduced from 282.9 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static long[, ] s_1 = new long[, ]{{0}};
    static char s_3;
    static byte s_4;
    public static void Main()
    {
        uint vr11 = (uint)(0 & s_1[0, 0]);
        long vr12 = s_1[0, 0];
        s_4 = (byte)M18(vr11);
    }

    static ushort M18(uint arg0)
    {
        arg0 = 828179499U;
        s_3 = s_3;
        return 0;
    }
}