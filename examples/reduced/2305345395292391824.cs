// Generated by Fuzzlyn v1.1 on 2018-08-30 17:47:36
// Seed: 2305345395292391824
// Reduced from 34.8 KiB to 0.6 KiB
// Debug: Outputs -1608667427
// Release: Outputs 0
struct S0
{
    public int F0;
    public S0(int f0): this()
    {
        F0 = f0;
    }
}

struct S1
{
    public S0 F0;
    public int F1;
    public S1(S0 f0): this()
    {
        F0 = f0;
    }
}

class C0
{
    public S1 F3;
    public C0(S1 f3)
    {
        F3 = f3;
    }
}

public class Program
{
    static C0 s_1 = new C0(new S1(new S0(0)));
    public static void Main()
    {
        M4() = s_1.F3;
        System.Console.WriteLine(s_1.F3.F0.F0);
    }

    static ref S1 M4()
    {
        s_1 = new C0(new S1(new S0(-1608667427)));
        return ref s_1.F3;
    }
}