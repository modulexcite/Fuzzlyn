// Generated by Fuzzlyn on 2018-07-19 02:36:04
// Seed: 18377616412090973304
// Reduced from 25.3 KiB to 0.5 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public S0(byte f0, ushort f1, char f2, short f3, sbyte f4, char f5, bool f6, long f9): this()
    {
    }
}

public class Program
{
    static byte[][, ] s_1 = new byte[][, ]{new byte[, ]{{0}}};
    public static void Main()
    {
        ushort vr21 = default(ushort);
        vr21 = (ushort)(vr21 * s_1[0][0, 0]);
        s_1[0] = s_1[0];
        M11(0, vr21);
    }

    static S0 M11(long arg0, ushort arg3)
    {
        return new S0(0, 0, 'M', 0, 0, 'n', true, 0);
    }
}