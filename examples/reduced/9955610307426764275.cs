// Generated by Fuzzlyn on 2018-07-21 06:56:15
// Seed: 9955610307426764275
// Reduced from 140.7 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static ulong[][, ] s_3 = new ulong[][, ]{new ulong[, ]{{0}}};
    public static void Main()
    {
        char vr18 = (char)(0 / (65534 + (0 & s_3[0][0, 0])));
        s_3[0][0, 0] = 0;
    }
}