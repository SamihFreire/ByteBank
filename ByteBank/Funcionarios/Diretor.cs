using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{

    //Modificadores virtual e override: Alguns comportamentos possuem implementações diferentes nas classes derivadas, para resolver este problema basta usarmos métodos virtuais e a sobrescrita.
    //base: A classe filha pode fazer referência aos membros da classe base com uso desta palavra reservada.

    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string _cpf) : base(5000, _cpf) // definindo no contrutor o argumento necessário e mandando para a base esse argumento
        {
            //Console.WriteLine("Criando Direto!");  verificando a ordem de chamadas. A classe base é invocada primeiro, aparecendo a msg "Criando Funcionário!"
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao() //Definindo override no método para sobreescrever o método Virtual da classe pai
        {
            //return Salario + base.GetBonificacao(); //fazendo a soma da bonificação do diretor + a bonificação da BASE que é a classe Funcionario
            return Salario * 0.5;
        }
    }
}
