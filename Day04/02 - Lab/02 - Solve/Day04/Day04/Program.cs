using Day04._01___Find___List_Extension_Method;

namespace Day04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> strings = new List<string>() { "eslam", "ahmed", "khalid", "omar", "rana", "ali" };

            //01 - Call Find() As Class Member Method

            //Find stringsMoreThan3 =>
            var stringsMoreThan3 = ListExtension.Find(strings, (x) => x.Length > 3);

            Console.WriteLine("\n======= stringsMoreThan3 =======\n");
            foreach (var item in stringsMoreThan3)
            {
                Console.Write($"{item} ");
            }

            //Find stringsStartWith_a =>
            var stringsStartWith_a = ListExtension.Find(strings, (x) => x[0] > 'a');

            Console.WriteLine("\n======= stringsStartWith_a =======\n");
            foreach (var item in stringsStartWith_a)
            {
                Console.Write($"{item} ");
            }

            //02 - Call Find() As object Member Method






        }
    }
}
