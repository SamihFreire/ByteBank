using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel  //Implementando a herança muultipla onde primeiro vem a classe concreta, em seguida a interface
    {
        public string Senha { get; set; }
        public FuncionarioAutenticavel(double salario, string cpf) : base (salario, cpf)
        { 
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
