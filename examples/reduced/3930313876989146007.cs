// Generated by Fuzzlyn on 2018-07-05 19:10:20
// Seed: 3930313876989146007
// Reduced from 23.9 KiB to 0.4 KiB
// Debug: Outputs 127
// Release: Outputs -25985
struct S0
{
    public ulong F2;
    public int F3;
    public short F4;
    public char F5;
    public uint F6;
    public S0(int f3): this()
    {
        F3 = f3;
    }
}

public class Program
{
    public static void Main()
    {
        S0 vr2 = new S0(-671311233);
        vr2.F4 = (byte)(vr2.F3 ^ 0);
        System.Console.WriteLine(vr2.F4);
    }
}