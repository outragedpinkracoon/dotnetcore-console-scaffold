using MyCats.Domain;

namespace MyCats.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cat = new Cat();
            System.Console.WriteLine(cat.Miaow());
        }
    }
}
