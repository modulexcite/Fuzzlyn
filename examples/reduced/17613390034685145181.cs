// Generated by Fuzzlyn on 2018-07-11 08:02:55
// Seed: 17613390034685145181
// Reduced from 70.6 KiB to 0.4 KiB
// Debug: Outputs 65461
// Release: Outputs 4294967221
class C0
{
    public sbyte F2;
}

public class Program
{
    static C0 s_3 = new C0();
    public static void Main()
    {
        ushort vr25 = 65534;
        s_3.F2 = (sbyte)vr25;
        ushort vr20 = M12();
        ulong vr21 = vr20;
        System.Console.WriteLine(vr21);
    }

    static ushort M12()
    {
        char vr11 = (char)('K' ^ s_3.F2);
        return vr11;
    }
}