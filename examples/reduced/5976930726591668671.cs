// Generated by Fuzzlyn v1.1 on 2018-08-28 13:08:34
// Seed: 5976930726591668671
// Reduced from 7.4 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static ushort[, ] s_1 = new ushort[, ]{{0}};
    public static void Main()
    {
        var vr18 = (ulong)((0 & s_1[0, 0]) * 8307335702347640386L);
        var vr19 = s_1[0, 0];
        ulong vr20 = vr18;
    }
}
