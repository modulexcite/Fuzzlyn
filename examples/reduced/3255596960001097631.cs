// Generated by Fuzzlyn v1.1 on 2018-09-02 07:08:42
// Seed: 3255596960001097631
// Reduced from 38.2 KiB to 0.6 KiB in 00:00:41
// Debug: Outputs True
// Release: Outputs False
struct S0
{
    public long F0;
    public ushort F1;
}

struct S1
{
    public S0 F0;
    public S0 F1;
}

struct S3
{
    public bool F0;
    public ulong F7;
    public ulong F9;
    public S3(bool f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S1 s_2;
    static S3 s_4;
    public static void Main()
    {
        var vr2 = new S3(true);
        var vr3 = new S1();
        M1(vr2, M1(s_4, vr3));
    }

    static ref S1 M1(S3 arg0, S1 arg1)
    {
        System.Console.WriteLine(arg0.F0);
        return ref s_2;
    }
}
