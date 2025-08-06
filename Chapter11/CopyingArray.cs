/*
namespace Chapter11
{
    internal class CopyingArray
    {
        static void CopyArray<T>(T[] array, T[] target)
        {
            for (int i = 0; i < array.Length; i++) { target[i]=array[i]; }
        }
        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5 };
            int[] target = new int[source.Length];
            CopyArray<int>(source, target);
            foreach (int i in target) {Console.WriteLine(i); }

            string[] source2 = { "하나", "둘", "셋", "넷", "다섯" };
            string[] target2 = new string[source2.Length];
            CopyArray<string>(source2, target2);
            foreach (string i in target2) { Console.WriteLine(i); }
        }
    }
}
*/