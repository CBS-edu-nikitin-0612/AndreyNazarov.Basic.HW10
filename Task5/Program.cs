using System;
using System.Reflection;
using System.Security;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyClass<int>.FacrotyMethod());
        }
    }

    internal static class MyClass<T> where T : new()
    {
        public static T FacrotyMethod()
        {
            return new T();
        }
    }
}
