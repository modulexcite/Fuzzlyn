// Generated by Fuzzlyn v1.1 on 2018-09-04 09:33:47
// Seed: 15624757806567365201
// Reduced from 185.3 KiB to 0.4 KiB in 00:02:40
// Debug: Runs successfully
// Release: Throws 'System.IndexOutOfRangeException'
public class Program
{
    static short s_1;
    static ushort s_3;
    public static void Main()
    {
        ulong[] vr10 = new ulong[]{0};
        bool vr8 = 0 < M4(ref s_1, vr10, s_3);
    }

    static ushort M4(ref short arg1, ulong[] arg2, ushort arg3)
    {
        ushort vr13 = default(ushort);
        arg1 = (short)((int)((ulong)(byte)arg2[0] ^ (byte)(0 & arg2[0])) ^ (0 / (vr13 | 1)));
        return arg3;
    }
}
