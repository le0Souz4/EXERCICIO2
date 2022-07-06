using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mes = new string[] { " ", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            string[] cidade = new string[] { " ", "Atibaia", "Bragança Paulista", "Mairiporã", "Nazaré", "Terra Preta", "Extrema", "Vargem" };

            Console.WriteLine("Escolha uma cidade:");
            for (int contador = 0; contador < cidade.Length; contador++)
            {
                Console.WriteLine(contador + " - " + cidade[contador]);
            }
            int escolha = Int32.Parse(Console.ReadLine());

            Console.Write("Digite o dia: ");
            int dd = Int32.Parse(Console.ReadLine());

            Console.Write("Digite o mês: ");
            for (int i = 0; i < mes.Length; i++) ;
            int mm = Int32.Parse(Console.ReadLine());

            Console.Write("Digite o ano: ");
            int yyyy = Int32.Parse(Console.ReadLine());

            Console.Write(cidade[escolha] + "," + " " + dd + " " + "de" + " " + mes[mm] + " " + yyyy);
            Console.ReadKey();
        }
       
    }
}
