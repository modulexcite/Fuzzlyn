// Generated by Fuzzlyn on 2018-07-20 06:14:20
// Seed: 12211139759208425116
// Reduced from 26.5 KiB to 0.4 KiB
// Debug: Outputs 65409
// Release: Outputs -127
struct S3
{
    public ushort F1;
    public sbyte F2;
    public sbyte F4;
    public long F5;
    public byte F7;
    public S3(sbyte f2): this()
    {
        F2 = f2;
    }
}

public class Program
{
    public static void Main()
    {
        S3 vr12 = new S3(-127);
        char vr13 = (char)(1L | vr12.F2);
        System.Console.WriteLine((int)vr13);
    }
}
