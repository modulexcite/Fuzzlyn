// Generated by Fuzzlyn on 2018-07-15 06:00:56
// Seed: 14097549527690576583
// Reduced from 9.9 KiB to 0.3 KiB
// Debug: Outputs 513
// Release: Outputs 1
public class Program
{
    static uint[][][][] s_1 = new uint[][][][]{new uint[][][]{new uint[][]{new uint[]{0}}}};
    public static void Main()
    {
        short[] vr2 = new short[]{514};
        s_1[0][0][0][0] = (uint)((sbyte)vr2[0] * vr2[0]--);
        System.Console.WriteLine(vr2[0]);
    }
}