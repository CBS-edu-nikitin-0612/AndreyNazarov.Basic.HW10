using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dict = new MyDictionary<string, string>();
            dict.Add("первый", "first");
            dict.Add("второй", "second");
            dict.Add("третий", "third");

            Console.WriteLine(dict.Length);
            Console.WriteLine(dict[1].Key);
            Console.WriteLine(dict[2].Value);
        }
    }
    internal class KeyValuePair<K, V>
    {
        public K Key { get; }
        public V Value { get; }

        public KeyValuePair(K key, V value)
        {
            Key = key;
            Value = value;
        }
    }
}
