using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLogicos_E_Condicinais
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 3;
            if (a == 1)
            {
                Console.WriteLine("entrou na condição do if");
            }
            else if(a== 2)
            {
                Console.WriteLine("caiu no bloco do senão se a = 2");
            }
            else 
            {
                Console.WriteLine("caiu no bloco do else");
            }

            var b = 1;
            switch (b) 
            {
                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    break;
                default:
                    Console.WriteLine("default case");
                    break;
            }
            //Ternário
            var c = 2;
            string teste = (c == 1 ? "O valor de a" : "mais um");
            Console.WriteLine(teste);

            // operadores lógicos
            // == comparação
            // ! not
            // != diferente
            // && E
            // || OU
            // < > + - / *





        }
    }
}
