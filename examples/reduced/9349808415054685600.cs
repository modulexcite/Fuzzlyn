// Generated by Fuzzlyn on 2018-07-21 14:24:07
// Seed: 9349808415054685600
// Reduced from 27.6 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.IndexOutOfRangeException'
public class Program
{
    static char s_4;
    public static void Main()
    {
        var vr4 = new short[][,, ]{new short[,, ]{{{0}}}};
        M11(vr4);
    }

    static char M11(short[][,, ] arg1)
    {
        short var0 = (short)(0 & arg1[0][0, 0, 0]);
        System.Console.WriteLine(arg1[0][0, 0, 0]);
        System.Console.WriteLine(var0);
        return s_4;
    }
}