// Generated by Fuzzlyn on 2018-07-17 10:40:15
// Seed: 17387909473091110375
// Reduced from 15.5 KiB to 0.2 KiB
// Debug: Outputs 65534
// Release: Outputs -2
public class Program
{
    static sbyte s_1 = -1;
    public static void Main()
    {
        int vr24 = (ushort)(s_1 ^ 1L);
        System.Console.WriteLine(vr24);
    }
}