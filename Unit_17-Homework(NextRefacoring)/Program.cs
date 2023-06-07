namespace Unit_17_Homework_NextRefacoring_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAccount n = new SimpleAccount();
            n.Balance = 500;
            Console.WriteLine(n.GetInterest());
            Console.ReadLine();
        }
    }
}