// Generated by Fuzzlyn on 2018-06-23 17:30:42
// Seed: 12797892511608023187
// Reduced from 55.8 KiB to 0.5 KiB
// Debug: Outputs True
// Release: Outputs False
struct S1
{
}

struct S3
{
    public bool F1;
    public ulong F2;
    public S1 F6;
    public S3(bool f1, S1 f6): this()
    {
        F1 = f1;
        F6 = f6;
    }
}

struct S5
{
    public S3 F0;
    public S5(S3 f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    public static void Main()
    {
        S5 vr13 = new S5(new S3(true, new S1()));
        var vr14 = vr13.F0.F1;
        System.Console.WriteLine(vr14);
    }
}