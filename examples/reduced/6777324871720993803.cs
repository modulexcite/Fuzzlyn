// Generated by Fuzzlyn on 2018-06-25 14:38:38
// Seed: 6777324871720993803
// Reduced from 32.9 KiB to 0.3 KiB
// Debug: Throws 'System.OverflowException'
// Release: Runs successfully
public class Program
{
    public static void Main()
    {
        int vr4 = (int)(0 / ((0 & (-9223372036854775808L % ((long)(18446744073709551614UL ^ M1(0)) | 1))) | 1));
    }

    static byte M1(long arg0)
    {
        System.Console.WriteLine(arg0);
        return 0;
    }
}