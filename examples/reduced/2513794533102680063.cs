// Generated by Fuzzlyn v1.1 on 2018-08-20 11:09:46
// Seed: 2513794533102680063
// Reduced from 107.7 KiB to 0.3 KiB
// Debug: Outputs False
// Release: Outputs True
public class Program
{
    static byte s_14 = 254;
    static sbyte s_18;
    public static void Main()
    {
        M12(ref s_14);
    }

    static short M12(ref byte arg2)
    {
        int vr14 = 2147483647;
        var vr3 = (byte)((sbyte)vr14 * arg2) <= s_18;
        System.Console.WriteLine(vr3);
        return 0;
    }
}
