// Generated by Fuzzlyn on 2018-07-08 11:18:52
// Seed: 15033054399755582170
// Reduced from 0.5 KiB to 0.2 KiB
// Debug: Outputs 9
// Release: Outputs 33534
public class Program
{
    public static void Main()
    {
        byte[] vr0 = new byte[]{246};
        char vr1 = (char)(195580079U % (short)(char)(-2147483647 - vr0[0]));
        System.Console.WriteLine((int)vr1);
    }
}