// Generated by Fuzzlyn on 2018-07-02 10:21:55
// Seed: 8952360015290389864
// Reduced from 76.6 KiB to 0.3 KiB
// Debug: Outputs 40482
// Release: Outputs -25054
struct S0
{
    public short F0;
}

public class Program
{
    static S0 s_1;
    static short[] s_10 = new short[]{-25054};
    public static void Main()
    {
        s_1.F0 = s_10[0];
        ushort vr30 = (ushort)(0L ^ s_1.F0);
        int vr26 = vr30;
        System.Console.WriteLine(vr26);
    }
}
