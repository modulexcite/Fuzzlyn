// Generated by Fuzzlyn v1.1 on 2018-08-09 04:14:56
// Seed: 16883614036736164931
// Reduced from 98.0 KiB to 0.2 KiB
// Debug: Outputs 65521
// Release: Outputs 4294967281
public class Program
{
    static sbyte[, ] s_14;
    public static void Main()
    {
        s_14 = new sbyte[, ]{{-16}};
        ulong vr15 = (ushort)(1U | s_14[0, 0]);
        System.Console.WriteLine(vr15);
    }
}