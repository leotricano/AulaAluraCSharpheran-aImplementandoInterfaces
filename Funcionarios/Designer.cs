using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf, 2000)
        {
        }
        public override double GetBonificacao()
        {
            return base.Salario * 0.17;
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }
    }
}