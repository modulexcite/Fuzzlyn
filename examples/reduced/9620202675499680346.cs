// Generated by Fuzzlyn on 2018-07-07 17:19:20
// Seed: 9620202675499680346
// Reduced from 67.8 KiB to 0.2 KiB
// Debug: Outputs 38159
// Release: Outputs 4294939919
public class Program
{
    static short s_9 = -27377;
    public static void Main()
    {
        uint vr4 = (ushort)(s_9 | 1L);
        System.Console.WriteLine(vr4);
    }
}
