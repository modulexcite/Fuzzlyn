// Generated by Fuzzlyn on 2018-07-20 14:44:16
// Seed: 1799370738234351802
// Reduced from 7.5 KiB to 0.6 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public char F1;
}

struct S0
{
    public byte F0;
    public C0 F1;
    public ushort F2;
    public uint F3;
    public short F4;
    public S0(C0 f1): this()
    {
        F1 = f1;
    }
}

struct S1
{
    public ushort F3;
    public S0 F7;
    public S1(S0 f7): this()
    {
        F7 = f7;
    }
}

struct S2
{
    public S1 F0;
    public S2(S1 f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    public static void Main()
    {
        S2 vr0 = new S2(new S1(new S0(new C0())));
        --vr0.F0.F7.F1.F1;
    }
}