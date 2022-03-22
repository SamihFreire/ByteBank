using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF{ get; set; }
        public double Salario { get; set; }

                                                //Criando um método VIRTUAL, o que disponibiliza
                                                //sobrescrever esse método nas classes filhas definindo o OVERRIDE.
                                                //Ex. a Classe Diretor
        public virtual double GetBonificacao()  // Métodos virtuais permitem uma implementação como também a sobrescrita
        {
            return Salario * 0.10;
        }
    }
}
