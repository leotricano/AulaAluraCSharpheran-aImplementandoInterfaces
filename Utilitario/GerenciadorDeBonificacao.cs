using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using bytebank_ADM.Funcionarios;



namespace bytebank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario) // SOBREGARCA DO METODO REGISTRAR (FUNCIONARIO E DIRETOR)
        {
            this.TotalDeBonificacao += funcionario.GetBonificacao();


        }

     
    }


}
 



