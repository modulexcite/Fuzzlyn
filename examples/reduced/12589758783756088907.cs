// Generated by Fuzzlyn on 2018-07-17 06:09:01
// Seed: 12589758783756088907
// Reduced from 40.3 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static ulong[][, ] s_3 = new ulong[][, ]{new ulong[, ]{{0}}};
    static int[] s_4 = new int[]{0};
    public static void Main()
    {
        bool vr4 = (0 % ((0 & s_3[0][0, 0]) | 1)) > 0;
        int vr5 = s_4[0];
    }
}
