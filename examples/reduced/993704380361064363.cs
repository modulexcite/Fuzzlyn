// Generated by Fuzzlyn on 2018-07-30 10:44:14
// Seed: 993704380361064363
// Reduced from 13.4 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.DivideByZeroException'
public class Program
{
    public static void Main()
    {
        short[] vr4 = new short[]{10};
        bool vr5 = 0 == ((vr4[0] % vr4[0]) % (char)((char)(844918560 / vr4[0]) | 1));
    }
}