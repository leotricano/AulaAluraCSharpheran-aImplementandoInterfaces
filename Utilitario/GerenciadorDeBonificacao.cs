using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.Utilitario
{
    public class GerenciadorDeBoificacao
    {
        public double TotalDeBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonificacao += funcionario.GetBonificacao();
        }

        public void Registrar(Diretor diretor)
        {
            this.TotalDeBonificacao += diretor.GetBonificacao();
        }
    }
}
