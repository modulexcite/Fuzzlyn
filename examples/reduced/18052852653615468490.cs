// Generated by Fuzzlyn on 2018-07-20 03:33:44
// Seed: 18052852653615468490
// Reduced from 2.4 KiB to 0.2 KiB
// Debug: Outputs 65428
// Release: Outputs -108
public class Program
{
    static sbyte[] s_1 = new sbyte[]{-107};
    public static void Main()
    {
        int vr3 = (ushort)(1U ^ s_1[0]);
        System.Console.WriteLine(vr3);
    }
}
