// Generated by Fuzzlyn on 2018-08-02 07:57:00
// Seed: 10108481595362281883
// Reduced from 5.1 KiB to 0.4 KiB
// Debug: Outputs 19
// Release: Outputs 55315
struct S0
{
    public int F0;
    public ulong F1;
    public uint F2;
    public ushort F3;
    public sbyte F4;
    public S0(ushort f3): this()
    {
        F3 = f3;
    }
}

public class Program
{
    public static void Main()
    {
        S0 vr11 = new S0(55315);
        byte vr12 = (byte)vr11.F3;
        ushort vr13 = vr12;
        System.Console.WriteLine(vr13);
    }
}