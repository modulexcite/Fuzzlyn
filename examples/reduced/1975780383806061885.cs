// Generated by Fuzzlyn on 2018-08-01 17:18:19
// Seed: 1975780383806061885
// Reduced from 12.4 KiB to 0.2 KiB
// Debug: Outputs 65532
// Release: Outputs 4294967292
public class Program
{
    static long s_1;
    static sbyte s_2 = -128;
    public static void Main()
    {
        char vr8 = '|';
        s_1 = (ushort)(vr8 | s_2);
        System.Console.WriteLine(s_1);
    }
}
