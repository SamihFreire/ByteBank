using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();


            carlos.Nome = "Carlos";
            carlos.CPF = "255.656.123-54";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos); 

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "236.587.656-55";
            roberta.Salario = 5000;

            gerenciador.Registrar(roberta);

            Console.WriteLine("Funcionario: " + carlos.Nome);
            Console.WriteLine("Bonificação: " + carlos.GetBonificacao());

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Funcionario: " + roberta.Nome);
            Console.WriteLine("Bonificação: " + roberta.GetBonificacao());

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Total Bonificação: " + gerenciador.GetTotalBonificacao());


            Console.ReadLine();
        }
    }
}
