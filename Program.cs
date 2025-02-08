namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "rameshwar";
            char[] arr = str.ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                arr[i] = str[str.Length - 1 - i];
            }
            //for (int i = 1; i < 100; i++) 
            //{

            //}
            Console.WriteLine(arr);
            Console.ReadLine();
        }
    }
}
