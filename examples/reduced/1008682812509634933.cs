// Generated by Fuzzlyn on 2018-06-23 11:39:27
// Seed: 1008682812509634933
// Reduced from 71.3 KiB to 0.3 KiB
// Debug: Outputs 54363
// Release: Outputs -11173
struct S0
{
    public short F1;
    public S0(short f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    static S0 s_2 = new S0(-11173);
    public static void Main()
    {
        char vr15 = (char)(s_2.F1 ^ 0L);
        System.Console.WriteLine((int)vr15);
    }
}
