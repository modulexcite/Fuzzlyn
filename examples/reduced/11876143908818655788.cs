// Generated by Fuzzlyn on 2018-07-08 23:14:26
// Seed: 11876143908818655788
// Reduced from 147.9 KiB to 0.2 KiB
// Debug: Outputs 255
// Release: Outputs 65535
public class Program
{
    static byte[] s_1 = new byte[]{0};
    public static void Main()
    {
        s_1[0] = 0;
        --s_1[0];
        ushort vr21 = s_1[0];
        System.Console.WriteLine(vr21);
    }
}