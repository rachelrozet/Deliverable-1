namespace deliverable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deliverable 1 - Created by Rachel Rozet");
            Console.WriteLine("Hello, World!");

            string stg = "Please input the following information:";
            Console.WriteLine(stg);

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your major?");
            string major = Console.ReadLine();

            Console.WriteLine("What year are you graduating?");
            string gradYear = Console.ReadLine();

            Console.WriteLine("Hello " + name + "! We are so excited that you will be graduating with a degree in " + major + " in " + gradYear + " from USF!");
        }
    }
}