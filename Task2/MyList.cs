namespace Task2
{
    internal class MyList<T>
    {
        private T[] array;
        private int lastIndex = 0;
        public int Lenght { get => lastIndex; }
        public void Add(T item)
        {
            array[lastIndex] = item;
            lastIndex++;
        }

        public T this[int i]
        {
            get
            {
                return array[i];
            }
        }
        public MyList()
        {
            array = new T[10];
        }
    }
}
