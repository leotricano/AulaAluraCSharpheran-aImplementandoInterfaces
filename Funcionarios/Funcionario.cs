using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }    
        public string Cpf { get; set; }
        public double Salario { get; set; }
       

        public virtual double GetBonificacao() // Assim, qualquer classe que herdar de Funcionario poderá reescrever o método GetBonificacao(). Colocando "Virtual"
        { 
           return this.Salario * 0.10; //10% do salario
        }
    }
}

