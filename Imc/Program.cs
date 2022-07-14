using System;

namespace Imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome?? quem fala dai?"); 
            string Nome=Console.ReadLine();
            Console.WriteLine("Qual sua idade??? Quantos anos voce tem???");
            string idade =Console.ReadLine();
            Console.WriteLine("Qual seu Peso");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quanto voce mede? use virgula");
            float altura = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Querido" + Nome);
            Console.WriteLine(idade + "é a sua idade");
            Console.WriteLine("Voce pesa " + peso);
            Console.WriteLine("Voce mede " + altura);
            double imc = peso / (altura * altura);
            if (imc <= 18.5)
            {
                Console.WriteLine("Voce esta abaixo do peso");
            }
            else if (imc < 18.6 && imc <= 24.9)
            {
                Console.WriteLine("Voce esta com o peso ideal");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Voce esta com Sobre Peso");
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("Esta começando a ficar obeso, atencao");
            }
            else  {
                Console.WriteLine("Por Favor entre em contato com um profissional");
            }  
        }
    }
}
