using Task2;

namespace Task4
{
    class Program2
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            int[] arr = list.GetArray();
        }
    }
}
