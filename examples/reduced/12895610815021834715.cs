// Generated by Fuzzlyn on 2018-07-31 09:09:17
// Seed: 12895610815021834715
// Reduced from 12.1 KiB to 0.5 KiB
// Debug: Outputs 11253
// Release: Outputs 0
struct S0
{
    public bool F2;
    public long F6;
    public byte F7;
    public char F8;
}

struct S1
{
    public ushort F2;
    public S0 F9;
    public S1(ushort f2, S0 f9): this()
    {
        F2 = f2;
        F9 = f9;
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
        S2 vr1 = new S2(new S1(11253, new S0()));
        ushort vr2 = vr1.F0.F2;
        System.Console.WriteLine(vr2);
    }
}