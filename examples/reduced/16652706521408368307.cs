// Generated by Fuzzlyn on 2018-06-27 00:38:55
// Seed: 16652706521408368307
// Reduced from 44.2 KiB to 0.2 KiB
// Debug: Outputs 18446744073709532189
// Release: Outputs 46109
public class Program
{
    public static void Main()
    {
        ushort[] vr13 = new ushort[]{46109};
        ulong vr14 = (ulong)(short)((ulong)(vr13[0] | 0) / 1);
        System.Console.WriteLine(vr14);
    }
}
