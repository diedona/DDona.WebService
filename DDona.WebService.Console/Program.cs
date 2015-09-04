using DDona.WebService.Console.TesteWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.WebService.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            wsTeste ws = new wsTeste();

            System.Console.WriteLine(ws.HelloWorld());

            System.Console.WriteLine("Digite a chave: ");
            string Chave = System.Console.ReadLine();

            System.Console.WriteLine("Digite a frase: ");
            string Frase = System.Console.ReadLine();
            string FraseEncriptada = ws.HelloWorldEncriptado(Frase, Chave);

            System.Console.WriteLine("Frase encriptada: " + FraseEncriptada);

            System.Console.WriteLine("Digite a chave novamente: ");
            Chave = System.Console.ReadLine();

            System.Console.WriteLine("Frase desencriptada com a chave '" + Chave + "': " + ws.HelloWorldDesencriptado(FraseEncriptada, Chave));
            System.Console.ReadLine();
        }
    }
}
