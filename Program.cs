namespace LinqEg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[] numbers = { 1, 7, 3, 13, 5, 6 };
            // var oddNumbers = numbers.Where(n => (n % 2) == 1);
            // Console.WriteLine(String.Join(",", oddNumbers));
            List<string> stringList = new List<string>() 
            {
                    "C# Tutorials",
                    "VB.NET Tutorials",
                    "Learn C++",
                    "MVC Tutorials" ,
                    "harsha"
            };

            var result = stringList.Where(s => s.Contains("harsha"));
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}
