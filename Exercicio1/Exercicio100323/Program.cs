using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int convidadosNoivo;
            int convidadosNoiva;
            int convidadosPresentesNoivo;
            int convidadosPresentesNoiva;

            Console.WriteLine("Entre com Numero de convidados do noivo");
            convidadosNoivo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entre com Numero de convidados da noiva");
            convidadosNoiva = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com o Numero de convidados presentes do noivo");
            convidadosPresentesNoivo= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com o Numero de convidados presentes da noiva");
            convidadosPresentesNoiva= Convert.ToInt32(Console.ReadLine());

            if(convidadosNoivo>convidadosNoiva)
            {
                Console.WriteLine("O Noiuvo tem mais convidados");
            }

            if( (convidadosNoiva>convidadosNoivo) 
                && (convidadosPresentesNoiva>convidadosPresentesNoivo))
            {
                Console.WriteLine("Noiva teve mais convites e tambem mais ocnvidados presentes");
            }
        }
    }
}