// Generated by Fuzzlyn v1.1 on 2018-10-01 04:27:32
// Seed: 2067368356096525545
// Reduced from 176.3 KiB to 0.3 KiB in 00:02:05
// Debug: Outputs 1
// Release: Outputs 0
public class Program
{
    public static void Main()
    {
        int[] vr2 = new int[]{-1};
        if (((vr2[0] * 62) / (1 & vr2[0])) != 0)
        {
            vr2[0] = 1;
            var vr3 = vr2[0];
            System.Console.WriteLine(vr3);
        }
    }
}