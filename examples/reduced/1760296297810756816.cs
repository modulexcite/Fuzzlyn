// Generated by Fuzzlyn v1.1 on 2018-08-06 02:42:24
// Seed: 1760296297810756816
// Reduced from 47.7 KiB to 0.4 KiB
// Debug: Outputs 4294967151
// Release: Outputs 111
public class Program
{
    public static void Main()
    {
        var vr33 = new uint[][,, ]{new uint[,, ]{{{3849459089U}}}};
        var vr34 = new uint[][,, ]{new uint[,, ]{{{0}}}};
        M1(vr34, (4294967295U * (byte)M1(vr33, 0)));
    }

    static ref uint M1(uint[][,, ] arg0, ulong arg4)
    {
        System.Console.WriteLine(arg4);
        return ref arg0[0][0, 0, 0];
    }
}
