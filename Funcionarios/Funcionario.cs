﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }    
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }


        public virtual double GetBonificacao()                    //Na classe Funcionario, vamos informar ao código que podemos sobrescrever
                                                                  //e redefinir o método GetBonificacao() nas classes derivadas
                                                                  //(no caso, Diretor). Para isso, usaremos a palavra reservada "virtual"
        { 
           return this.Salario * 0.10; //10% do salario
        }
        public Funcionario(string cpf, double salario)
        {
            this.Salario = salario;
            this.Cpf = cpf;
            TotalDeFuncionarios++;
            //Console.WriteLine("Criando Funcionario");
        }

        public virtual void AumentarSalario()
        {
            this.Salario *= 1.10;
        }
    }
}

