// Generated by Fuzzlyn on 2018-08-02 11:41:16
// Seed: 11325685258770563656
// Reduced from 109.9 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static sbyte[, ] s_3 = new sbyte[, ]{{0}};
    public static void Main()
    {
        char vr8 = (char)(0 & s_3[0, 0]);
        s_3[0, 0]++;
        System.Console.WriteLine((int)vr8);
    }
}