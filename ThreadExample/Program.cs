namespace ThreadExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void MyFunction()
            {
                // Some work here
                Console.WriteLine("Hello, World!");
            }
            Thread myThread = new Thread(new ThreadStart(MyFunction));
            myThread.Start();
            
        }
    }
}