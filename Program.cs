namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = {2,4,6,5,7,9,10};

            foreach (int item in number.Where(n => n % 2 == 0))
            {
                Console.WriteLine(item + " Is Even Number");
            }
            //Console.WriteLine(arr);
            Console.ReadLine();
        }
    }
}
