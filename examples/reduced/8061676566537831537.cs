// Generated by Fuzzlyn on 2018-06-18 20:19:41
// Seed: 8061676566537831537
// Reduced from 178.1 KiB to 0.3 KiB
// Debug: Outputs False
// Release: Outputs True
struct S0
{
    public bool F0;
}

struct S1
{
    public S0 F6;
    public bool F7;
}

public class Program
{
    static S1 s_32;
    public static void Main()
    {
        s_32.F6 = M25();
        System.Console.WriteLine(s_32.F7);
    }

    static S0 M25()
    {
        return new S0();
    }
}
