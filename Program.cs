
using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro";
pedro.Cpf = "110485596-10";
pedro.Salario = 10000;

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new Diretor();
roberta.Nome = "Roberta Silva";
roberta.Cpf = "54354313";
roberta.Salario = 5000;

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

// ...

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);