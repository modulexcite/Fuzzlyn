// Generated by Fuzzlyn on 2018-06-23 13:27:57
// Seed: 15816860453064520354
// Reduced from 3.6 KiB to 0.2 KiB
// Debug: Outputs 41384
// Release: Outputs 4294943144
public class Program
{
    public static void Main()
    {
        short[][, ] vr4 = new short[][, ]{new short[, ]{{-24152}}};
        var vr5 = (ushort)(0L ^ vr4[0][0, 0]);
        ulong vr6 = vr5;
        System.Console.WriteLine(vr6);
    }
}
