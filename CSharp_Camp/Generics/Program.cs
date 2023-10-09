using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Çetin");

            foreach (var item in names[0])
            {
                Console.WriteLine()
            }


        }
    }
}
