using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Cypher cypher = new Cypher();
            Console.WriteLine(cypher.StringCypher("1:aC3"));
            Console.WriteLine(cypher.StringCypher("2:Zy9"));
            Console.WriteLine(cypher.StringCypher("-2:Ba0"));
            Console.WriteLine(cypher.StringCypher("1:b#"));
            Console.WriteLine(cypher.StringCypher("27:a0"));
           
            Console.WriteLine(cypher.StringCypher("0:ab27"));


        }
    }
}
