namespace Task3
{
    internal class MyDictionary<K, V>
    {
        private KeyValuePair<K, V>[] array;
        private int lastIndex = 0;
        public int Length { get => lastIndex; }

        public void Add(K key, V value)
        {
            array[lastIndex] = new KeyValuePair<K, V>(key, value);
            lastIndex++;
        }

        public KeyValuePair<K, V> this[int i]
        {
            get => array[i];
        }

        public MyDictionary()
        {
            array = new KeyValuePair<K, V>[10];
        }
    }
}
