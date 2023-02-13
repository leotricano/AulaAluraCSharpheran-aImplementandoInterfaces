using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor: Funcionario //Em suma, não precisamos manter essas propriedades na classe Diretor,
                                      //porque já temos acesso a elas pelo mecanismo de herança. Então, vamos removê-las:
    {
        public override double GetBonificacao() // Para indicar ao compilador que o método GetBonificacao() será sobrescrito na classe Diretor, usaremos a palavra reservada override
        {
            return this.Salario;    //100% do dalario
        }
    }
}
