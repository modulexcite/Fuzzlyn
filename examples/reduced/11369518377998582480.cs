// Generated by Fuzzlyn on 2018-07-17 20:47:54
// Seed: 11369518377998582480
// Reduced from 16.2 KiB to 0.2 KiB
// Debug: Outputs 65456
// Release: Outputs 4294967216
public class Program
{
    public static void Main()
    {
        var vr8 = new sbyte[]{-2};
        char vr14 = 'N';
        var vr10 = (char)(vr14 ^ vr8[0]);
        uint vr12 = vr10;
        System.Console.WriteLine(vr12);
    }
}
