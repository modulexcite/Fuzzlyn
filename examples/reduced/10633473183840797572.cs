// Generated by Fuzzlyn v1.1 on 2018-08-19 18:35:05
// Seed: 10633473183840797572
// Reduced from 60.2 KiB to 0.3 KiB
// Debug: Outputs 65479
// Release: Outputs 4294967239
class C1
{
    public sbyte F5;
    public C1(sbyte f5)
    {
        F5 = f5;
    }
}

public class Program
{
    static C1 s_3 = new C1(-58);
    public static void Main()
    {
        var vr17 = (ushort)(s_3.F5 ^ 1U);
        uint vr20 = vr17;
        System.Console.WriteLine(vr20);
    }
}