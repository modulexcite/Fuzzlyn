// Generated by Fuzzlyn v1.1 on 2018-08-04 19:39:08
// Seed: 9105882920514220645
// Reduced from 163.2 KiB to 0.7 KiB
// Debug: Outputs 0
// Release: Outputs 10
struct S0
{
}

struct S1
{
    public byte F0;
    public S0 F1;
    public S1(byte f0): this()
    {
        F0 = f0;
    }
}

class C0
{
    public S1 F1;
}

struct S3
{
    public C0 F2;
    public C0 F8;
    public int F9;
    public S3(C0 f8): this()
    {
        F8 = f8;
    }
}

public class Program
{
    static S3 s_1 = new S3(new C0());
    public static void Main()
    {
        S3 vr29 = new S3(new C0());
        var vr30 = new S1(10);
        var vr31 = s_1.F8.F1;
        M10(vr31, M10(vr30, vr29)) = s_1;
    }

    static ref S3 M10(S1 arg0, S3 arg1)
    {
        S3[][] vr28 = new S3[][]{new S3[]{new S3(new C0())}};
        System.Console.WriteLine(arg0.F0);
        return ref vr28[0][0];
    }
}
