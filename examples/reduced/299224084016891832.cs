// Generated by Fuzzlyn on 2018-07-07 18:16:53
// Seed: 299224084016891832
// Reduced from 20.5 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static short[, ] s_2 = new short[, ]{{0}};
    public static void Main()
    {
        var vr19 = (uint)(0 & s_2[0, 0]);
        var vr20 = s_2[0, 0];
        M4(vr19);
    }

    static ushort M4(uint arg0)
    {
        uint[, ] var0 = new uint[, ]{{3506264703U}};
        return 0;
    }
}