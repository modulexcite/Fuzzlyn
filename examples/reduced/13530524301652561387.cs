// Generated by Fuzzlyn on 2018-07-08 13:19:36
// Seed: 13530524301652561387
// Reduced from 4.2 KiB to 0.6 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public uint F2;
}

struct S0
{
    public C0 F1;
    public C0 F2;
    public bool F3;
    public long F5;
    public ushort F6;
    public S0(C0 f1): this()
    {
        F1 = f1;
    }
}

struct S1
{
    public S0 F0;
    public S0 F5;
    public S1(S0 f0, S0 f5): this()
    {
        F0 = f0;
        F5 = f5;
    }
}

struct S3
{
    public S1 F0;
    public S3(S1 f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    public static void Main()
    {
        S3 vr0 = new S3(new S1(new S0(new C0()), new S0(new C0())));
        vr0.F0.F0.F1.F2 = vr0.F0.F5.F1.F2++;
    }
}
