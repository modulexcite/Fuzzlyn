// Generated by Fuzzlyn v1.1 on 2018-08-24 14:15:45
// Seed: 10572577223971431963
// Reduced from 18.9 KiB to 0.3 KiB
// Debug: Outputs 65535
// Release: Outputs 4294967295
public class Program
{
    static long s_1;
    public static void Main()
    {
        sbyte vr21 = (sbyte)s_1--;
        var vr22 = M5();
        ulong vr26 = vr22;
        System.Console.WriteLine(vr26);
    }

    static ushort M5()
    {
        return (ushort)(0 ^ (sbyte)s_1);
    }
}
