// Generated by Fuzzlyn on 2018-07-24 00:01:32
// Seed: 2167093224893259520
// Reduced from 45.3 KiB to 0.2 KiB
// Debug: Outputs 4294958063
// Release: Outputs 1538710511
public class Program
{
    public static void Main()
    {
        byte[] vr23 = new byte[]{235};
        var vr24 = (uint)(short)(15939328595746806572UL | vr23[0]);
        System.Console.WriteLine(vr24);
    }
}