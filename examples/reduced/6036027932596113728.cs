// Generated by Fuzzlyn on 2018-07-22 06:36:51
// Seed: 6036027932596113728
// Reduced from 5.9 KiB to 0.3 KiB
// Debug: Outputs 2027481460
// Release: Outputs 116
class C3
{
    public byte F0;
}

public class Program
{
    static C3 s_1 = new C3();
    static int[] s_2 = new int[]{0};
    public static void Main()
    {
        s_2[0] = 2027481459;
        s_1.F0 = (byte)s_2[0];
        int vr6 = s_2[0]++;
        System.Console.WriteLine(s_2[0]);
    }
}
