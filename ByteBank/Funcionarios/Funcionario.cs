using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF{ get; private set; }
        public double Salario { get; protected set; } // definindo modificador de acesso para esse campo ser acessivel pela classe como pelos tipos derivados (classes filhas)
                                                      // para fora da classe base e filhas ele se comporta como private
        public Funcionario(double salario, string cpf)
        {
            //Console.WriteLine("Criando Funcionário!");
            Salario = salario;
            CPF = cpf;
            TotalDeFuncionarios++;
        }

        public virtual void AumentarSalario()
        {
            Salario *= 1.1;
        }

                                                //Criando um método VIRTUAL, o que disponibiliza
                                                //sobrescrever esse método nas classes filhas definindo o OVERRIDE.
                                                //Ex. a Classe Diretor
        public virtual double GetBonificacao()  // Métodos virtuais permitem uma implementação como também a sobrescrita
        {
            return Salario * 0.10;
        }
    }
}
