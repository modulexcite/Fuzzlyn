// Generated by Fuzzlyn on 2018-07-28 13:16:14
// Seed: 761520043213270076
// Reduced from 270.0 KiB to 0.3 KiB
// Debug: Outputs 4294938034
// Release: Outputs 36274
public class Program
{
    static short s_19;
    static short s_60 = -29262;
    public static void Main()
    {
        uint vr29 = (uint)(s_19 ^ (uint)M91());
        System.Console.WriteLine(vr29);
    }

    static short M91()
    {
        return s_60;
    }
}