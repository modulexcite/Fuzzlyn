// Generated by Fuzzlyn on 2018-07-15 08:11:06
// Seed: 11892823222770234253
// Reduced from 12.8 KiB to 0.2 KiB
// Debug: Outputs 65462
// Release: Outputs 4294967222
public class Program
{
    static sbyte s_2 = -74;
    public static void Main()
    {
        char vr19 = '"';
        char vr20 = (char)(vr19 | s_2);
        ulong vr22 = vr20;
        System.Console.WriteLine(vr22);
    }
}