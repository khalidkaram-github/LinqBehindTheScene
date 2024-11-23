namespace LinqBehindTheScene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = numbers.Where(c => c > 5);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
    public static class Collection
    {
        public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach (TSource element in source)
                if (predicate(element))
                    yield return element;
        }
    }
}
