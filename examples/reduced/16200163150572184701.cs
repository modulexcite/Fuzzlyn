// Generated by Fuzzlyn on 2018-07-10 14:27:57
// Seed: 16200163150572184701
// Reduced from 28.1 KiB to 0.3 KiB
// Debug: Outputs 4294967295
// Release: Outputs 65535
class C0
{
    public short F0;
    public uint F2;
}

public class Program
{
    public static void Main()
    {
        C0 vr9 = new C0();
        vr9.F2 = 4294967295U;
        vr9.F0 = (short)('S' + (ushort)vr9.F2);
        vr9.F2 = vr9.F2;
        System.Console.WriteLine(vr9.F2);
    }
}