namespace StaticClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Helper.IsOdd(51));
            Console.WriteLine(Helper.IsEven(76));
            Console.WriteLine(Helper.HasDigit("T539G"));
            Console.WriteLine(Helper.CheckPassword("fgergA12"));
            Console.WriteLine(Helper.Captalize("aYxan"));
        }
    }
}
