using System;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario, abono, novoSalario;

            Console.WriteLine("Digite o salário");
            salario = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o abono");
            abono = Convert.ToSingle(Console.ReadLine());

            novoSalario = salario + abono;
            Console.WriteLine(novoSalario);

            
            //Exercicio 2

            float nota1, nota2, nota3, nota4, media;

            Console.WriteLine("\n nota1");
            nota1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("nota2");
            nota2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("nota3");
            nota3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("nota4");
            nota4 = Convert.ToSingle(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine(Math.Round(media,1));

            //Exercicio 3

            float salarioBruto, adicionalNoturno, horasExtras, descontos, salarioLiquido
                
                ;
            Console.WriteLine("salarioBruto");
            salarioBruto = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("adicionalNoturno");
            adicionalNoturno = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("horasExtras");
            horasExtras = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("descontos");
            descontos = Convert.ToSingle(Console.ReadLine());
            
            salarioLiquido = (salarioBruto + adicionalNoturno + (horasExtras * 5) - descontos);
            Console.WriteLine(Math.Round(salarioLiquido, 2));


            //Exercicio 4

            float numero1, numero2, numero3, numero4, diferença;

            Console.WriteLine("numero1");
            numero1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("numero2");
            numero2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("numero3");
            numero3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("numero4");
            numero4 = Convert.ToSingle(Console.ReadLine());

            diferença = (numero1 * numero2) - (numero3 * numero4);
            Console.WriteLine(Math.Round(diferença, 1));

            ;
        }
    }
}