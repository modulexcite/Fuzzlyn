// Generated by Fuzzlyn on 2018-07-13 23:50:11
// Seed: 14438620760053746232
// Reduced from 49.3 KiB to 0.5 KiB
// Debug: Prints 1 line(s)
// Release: Prints 0 line(s)
struct S0
{
    public short F0;
    public uint F1;
    public ulong F2;
    public byte F3;
    public int F4;
    public S0(int f4): this()
    {
        F4 = f4;
    }
}

public class Program
{
    public static void Main()
    {
        int vr5 = default(int);
        S0 vr9 = new S0(1327133632);
        sbyte vr10 = (sbyte)vr9.F4;
        bool vr6 = vr10 <= 0;
        if (vr6)
        {
            System.Console.WriteLine(vr5);
        }
    }
}
