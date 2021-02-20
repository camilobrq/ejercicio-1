using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1 = 0.0f, nota2 = 0.0f, nota3 = 0.0f, promedio = 0.0f;
            Console.WriteLine("Bienvenido al Programa de calcular promedio");
            Console.WriteLine("Digite su primera nota: ");
            nota1 = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite su segunda nota: ");
            nota2 = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite su tercera nota: ");
            nota3 = (float)Convert.ToDouble(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3)/3;
            Console.WriteLine($"Su Promedio es: {promedio}");
            if (promedio>=3)
            {
                Console.WriteLine("Felicidades has ganado la materia :)");
            }
            else
            {
                Console.WriteLine("Has perdido la materia por bajo rendimiento academico :(");
            }
            Console.WriteLine("By: Camilo Brito :)");
            Console.ReadKey();
        }
    }
}
