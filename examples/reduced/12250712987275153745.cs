// Generated by Fuzzlyn on 2018-07-22 20:26:43
// Seed: 12250712987275153745
// Reduced from 12.7 KiB to 0.3 KiB
// Debug: Outputs 59430
// Release: Outputs 38
class C0
{
    public ushort F2;
}

public class Program
{
    public static void Main()
    {
        var vr15 = new C0();
        vr15.F2 = 59430;
        var vr18 = (byte)vr15.F2;
        var vr19 = vr15.F2;
        byte vr21 = vr18;
        System.Console.WriteLine(vr19);
    }
}
