// Generated by Fuzzlyn on 2018-07-04 23:55:59
// Seed: 17910158468966871729
// Reduced from 22.0 KiB to 0.2 KiB
// Debug: Outputs 65527
// Release: Outputs -9
public class Program
{
    static sbyte[] s_1 = new sbyte[]{-10};
    public static void Main()
    {
        var vr11 = (char)(s_1[0] ^ 1U);
        System.Console.WriteLine((int)vr11);
    }
}
