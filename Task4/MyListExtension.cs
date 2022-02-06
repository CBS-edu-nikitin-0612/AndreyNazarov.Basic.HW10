using Task2;

namespace Task4
{
    internal static class MyListExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] arr = new T[list.Lenght];
            for (int i = 0; i < list.Lenght; i++)
            {
                arr[i] = list[i];
            }
            return arr;
        }
    }
}
