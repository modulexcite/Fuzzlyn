// Generated by Fuzzlyn v1.1 on 2018-08-21 09:35:54
// Seed: 6643545187572198994
// Reduced from 16.4 KiB to 0.3 KiB
// Debug: Outputs -43
// Release: Outputs -1
public class Program
{
    static sbyte[][, ][] s_2 = new sbyte[][, ][]{new sbyte[, ][]{{new sbyte[]{-2}}}};
    public static void Main()
    {
        var vr2 = (long)0;
        vr2 = 1L;
        sbyte vr11 = (sbyte)((ushort)(vr2 | s_2[0][0, 0][0]) % 1537);
        System.Console.WriteLine(vr11);
    }
}