// Generated by Fuzzlyn on 2018-07-13 14:01:58
// Seed: 9924024908606123482
// Reduced from 23.9 KiB to 0.2 KiB
// Debug: Throws 'System.OverflowException'
// Release: Runs successfully
public class Program
{
    static ushort s_6;
    public static void Main()
    {
        ushort vr2 = (ushort)(0 & (-9223372036854775808L % (sbyte)(4294967295U | s_6)));
        System.Console.WriteLine(vr2);
    }
}