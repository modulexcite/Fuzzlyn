// Generated by Fuzzlyn on 2018-08-02 07:07:50
// Seed: 13285460630933943064
// Reduced from 101.5 KiB to 0.2 KiB
// Debug: Outputs 4294961595
// Release: Outputs 59835
public class Program
{
    static ushort s_1 = 5701;
    public static void Main()
    {
        var vr10 = 4294967295U * s_1;
        ulong vr12 = vr10;
        System.Console.WriteLine(vr12);
    }
}