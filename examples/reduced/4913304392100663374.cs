// Generated by Fuzzlyn v1.1 on 2018-08-09 14:11:53
// Seed: 4913304392100663374
// Reduced from 4.0 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    public static void Main()
    {
        var vr13 = new sbyte[][][, ]{new sbyte[][, ]{new sbyte[, ]{{0}}}};
        int vr15 = 0 & vr13[0][0][0, 0];
        vr13[0] = vr13[0];
        System.Console.WriteLine(vr15);
        System.Console.WriteLine(vr13[0][0][0, 0]);
    }
}