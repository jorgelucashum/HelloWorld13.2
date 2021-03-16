using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld13._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p1 = new Produto("TV", 500.00, 10);

            p1.Nome = "TV 4K";

            Console.WriteLine(p1.Nome);
            Console.WriteLine(p1.Preco);
            Console.WriteLine(p1.Quantidade);


            Console.ReadLine();

        }
    }
}
