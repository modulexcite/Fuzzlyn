// Generated by Fuzzlyn on 2018-08-01 00:56:01
// Seed: 8298060273926936284
// Reduced from 218.1 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static long s_43;
    static sbyte[, ] s_46 = new sbyte[, ]{{0}};
    static sbyte[, ] s_64;
    public static void Main()
    {
        s_43 = (s_46[0, 0] & 0);
        s_64 = s_46;
        System.Console.WriteLine(s_64[0, 0]);
    }
}