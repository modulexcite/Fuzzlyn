// Generated by Fuzzlyn on 2018-07-04 22:28:07
// Seed: 7140478161100551952
// Reduced from 2.6 KiB to 0.3 KiB
// Debug: Outputs -314608150
// Release: Outputs 30186
class C0
{
    public int F2;
    public C0(int f2)
    {
        F2 = f2;
    }
}

public class Program
{
    public static void Main()
    {
        C0 vr0 = new C0(-314608150);
        ulong vr1 = (ushort)vr0.F2;
        vr0.F2 = vr0.F2;
        System.Console.WriteLine(vr0.F2);
        System.Console.WriteLine(vr1);
    }
}
