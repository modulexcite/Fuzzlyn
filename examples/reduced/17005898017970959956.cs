// Generated by Fuzzlyn on 2018-07-31 18:08:21
// Seed: 17005898017970959956
// Reduced from 297.1 KiB to 0.4 KiB
// Debug: Outputs 65535
// Release: Outputs 4294967295
class C0
{
    public sbyte F0;
}

public class Program
{
    static uint s_4;
    public static void Main()
    {
        C0[] vr45 = new C0[]{new C0()};
        var vr49 = vr45[0].F0--;
        var vr50 = (ushort)((0 & M14(s_4)) ^ vr45[0].F0);
        uint vr52 = vr50;
        System.Console.WriteLine(vr52);
    }

    static short M14(uint arg0)
    {
        return (short)arg0;
    }
}