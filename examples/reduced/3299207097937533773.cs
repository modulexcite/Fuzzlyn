// Generated by Fuzzlyn on 2018-07-10 04:43:35
// Seed: 3299207097937533773
// Reduced from 7.0 KiB to 0.2 KiB
// Debug: Outputs 60927
// Release: Outputs 255
public class Program
{
    public static void Main()
    {
        byte[] vr0 = new byte[]{255};
        char vr1 = (char)(-4780 | vr0[0]);
        System.Console.WriteLine((int)vr1);
    }
}
