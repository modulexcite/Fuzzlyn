// Generated by Fuzzlyn on 2018-07-11 22:28:48
// Seed: 4543197500332090205
// Reduced from 145.6 KiB to 0.2 KiB
// Debug: Outputs 65535
// Release: Outputs -1
public class Program
{
    static sbyte[, ] s_3 = new sbyte[, ]{{0}};
    public static void Main()
    {
        long vr37 = s_3[0, 0]--;
        int vr38 = (ushort)(0 ^ s_3[0, 0]);
        System.Console.WriteLine(vr38);
    }
}
