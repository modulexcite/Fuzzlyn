// Generated by Fuzzlyn v1.1 on 2018-08-26 14:10:35
// Seed: 393632086033357945
// Reduced from 1.1 KiB to 0.4 KiB
// Debug: Outputs 0
// Release: Outputs -2147483648
struct S0
{
    public bool F0;
    public ulong F1;
    public int F2;
    public uint F3;
    public ulong F4;
    public S0(int f2): this()
    {
        F2 = f2;
    }
}

public class Program
{
    public static void Main()
    {
        S0 vr0 = new S0(-2147483648);
        long vr1 = (short)vr0.F2;
        System.Console.WriteLine(vr1);
    }
}
