using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario   //Ela se torna uma classe abstrata, modelo para as outras
    {
        public string Nome { get; set; }    
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }


        

        public static int TotalDeFuncionarios { get; private set; }


        public abstract double GetBonificacao();                    //Na classe Funcionario, vamos informar ao código que podemos sobrescrever
                                                                  //e redefinir o método GetBonificacao() nas classes derivadas
                                                                  //(no caso, Diretor). Para isso, usaremos a palavra reservada "virtual"

        public Funcionario(string cpf, double salario)
        {
            this.Salario = salario;
            this.Cpf = cpf;
            TotalDeFuncionarios++;
            //Console.WriteLine("Criando Funcionario");
        }

        public abstract void AumentarSalario();

        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }

    }
}

