// Generated by Fuzzlyn on 2018-07-01 07:52:04
// Seed: 15826652666402017380
// Reduced from 78.6 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public uint F4;
    public short F6;
}

public class Program
{
    static S0[][, ] s_1 = new S0[][, ]{new S0[, ]{{new S0()}}};
    public static void Main()
    {
        bool vr7 = 0 == (s_1[0][0, 0].F6 & 0);
        if (vr7)
        {
            s_1[0][0, 0].F4 = s_1[0][0, 0].F4;
        }
        else
        {
        }
    }
}