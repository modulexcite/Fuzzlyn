// Generated by Fuzzlyn on 2018-07-01 23:02:18
// Seed: 4448006180021935996
// Reduced from 24.7 KiB to 0.2 KiB
// Debug: Outputs 65535
// Release: Outputs -1
public class Program
{
    static short s_1 = -1;
    public static void Main()
    {
        char vr9 = (char)(s_1 ^ 0U);
        System.Console.WriteLine((int)vr9);
    }
}
