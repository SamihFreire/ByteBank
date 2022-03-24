using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public interface IAutenticavel //Comport-se como uma assinatura, um contrato, onde as classes que utilizam essa interface sao obrigadas a implementar os metodos;
    {                             //Não permite metodos implementados
        bool Autenticar(string senha);
    }
}
