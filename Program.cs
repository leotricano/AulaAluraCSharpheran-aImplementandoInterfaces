
using bytebank_ADM.Funcionarios;


Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro";
pedro.Cpf = "110485596-10";
pedro.Salario = 1000;

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new Diretor();
roberta.Nome = "Roberta Silva";
roberta.Cpf = "54354313";
roberta.Salario = 5000;

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());