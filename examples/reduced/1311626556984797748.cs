// Generated by Fuzzlyn on 2018-07-02 23:07:16
// Seed: 1311626556984797748
// Reduced from 7.5 KiB to 0.4 KiB
// Debug: Throws 'System.OverflowException'
// Release: Runs successfully
public class Program
{
    public static void Main()
    {
        var vr1 = new int[, ][]{{new int[]{0}}};
        ushort vr2 = (ushort)(0 % ((0 & (-2147483648 % ((sbyte)(14611420340196465878UL | (uint)(50296 ^ ((2U | (8544138610190678284L ^ M1(vr1))) * 43608))) | 1))) | 1));
    }

    static ushort M1(int[, ][] arg1)
    {
        int var0 = default(int);
        arg1[0, 0][0] <<= var0;
        return 0;
    }
}