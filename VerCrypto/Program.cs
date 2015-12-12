using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerCrypto
{
    class Program
    {
        static void Main(string[] args)
        {
            CryptoList cl = new CryptoList();

            Console.WriteLine(cl.count);

            cl['a'] += 10;
            cl['c'] = 100;
            for (char c = 'a'; c <= 'f'; c++)
                Console.WriteLine(cl[c]);
            Console.ReadKey();
        }
    }
}
