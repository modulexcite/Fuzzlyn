// Generated by Fuzzlyn on 2018-06-24 03:22:16
// Seed: 14912283627401332935
// Reduced from 436.0 KiB to 0.2 KiB
// Debug: Outputs 65504
// Release: Outputs 4294967264
public class Program
{
    static byte s_24;
    static sbyte[, ] s_60 = new sbyte[, ]{{-32}};
    public static void Main()
    {
        long vr26 = (ushort)(s_24 ^ s_60[0, 0]);
        System.Console.WriteLine(vr26);
    }
}
