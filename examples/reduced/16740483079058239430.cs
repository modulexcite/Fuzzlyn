// Generated by Fuzzlyn v1.1 on 2018-09-01 16:55:11
// Seed: 16740483079058239430
// Reduced from 325.8 KiB to 0.4 KiB
// Debug: Outputs 4
// Release: Outputs 291719684
struct S0
{
    public bool F1;
    public int F2;
    public bool F4;
    public uint F5;
    public short F6;
    public S0(int f2): this()
    {
        F2 = f2;
    }
}

public class Program
{
    public static void Main()
    {
        S0 vr4 = new S0(291719684);
        vr4.F2 = (byte)(vr4.F2 | vr4.F6);
        System.Console.WriteLine(vr4.F2);
    }
}
