// Generated by Fuzzlyn v1.1 on 2018-09-18 19:27:05
// Seed: 5691554378863156868
// Reduced from 148.5 KiB to 1.0 KiB in 00:02:39
// Debug: Outputs 0
// Release: Outputs 140521904610952
struct S0
{
    public long F0;
    public long F4;
    public byte F7;
}

public class Program
{
    static S0 s_2;
    static S0 s_6;
    static int s_9;
    static bool s_15;
    static bool s_17;
    static short s_19;
    static uint[] s_29 = new uint[]{0};
    public static void Main()
    {
        var vr12 = s_6.F7;
        S0 vr19 = default(S0);
        ulong vr20 = default(ulong);
        var vr15 = (long)vr20;
        var vr17 = s_29[0];
        short vr22 = default(short);
        M34(vr19, M28(s_9, vr15, s_17, vr17, vr12, vr22, ref s_19));
    }

    static ref S0 M28(int arg0, long arg1, bool arg2, uint arg3, byte arg4, int arg5, ref short arg6)
    {
        if (s_15)
        {
            s_6.F7 = arg4;
            M29();
            if (arg2)
            {
                arg2 = false;
            }
        }

        return ref s_2;
    }

    static void M29()
    {
    }

    static void M34(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F0);
    }
}