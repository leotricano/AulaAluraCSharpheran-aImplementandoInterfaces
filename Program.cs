
using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;


#region
//Funcionario pedro = new Funcionario("110485596-10", 1000);
//pedro.Nome = "Pedro";


//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("54354313", 5000);
//roberta.Nome = "Roberta Silva";


//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());



//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
//Console.WriteLine("Total de funcionarios: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("Novo salario pedro "+ pedro.Salario);
//Console.WriteLine("Novo salario roberta "+ roberta.Salario);
#endregion

CalcularBonificacao();
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador =  new GerenciadorDeBonificacao();

    Designer joao = new Designer("123456");
    joao.Nome = "Joao Dias";

    Diretor Camila = new Diretor("852741963");
    Camila.Nome = "Camila Souza";

    Auxiliar Ichigo = new Auxiliar("66666666");
    Ichigo.Nome = "Kurosaki Ichigo";

    GerenteDeContas Rukia = new GerenteDeContas("423121");
    Rukia.Nome = "Rukia";

    gerenciador.Registrar(joao);
    gerenciador.Registrar(Camila);
    gerenciador.Registrar(Ichigo);
    gerenciador.Registrar(Rukia);

    Console.WriteLine("Total de Bonificação: "+ gerenciador.TotalDeBonificacao);
}