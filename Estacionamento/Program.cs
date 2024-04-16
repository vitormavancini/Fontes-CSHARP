using Estacionamento.Common.Models;

Console.WriteLine(" ");
Console.WriteLine("Bem-Vindo ao programa de estacionamento - EstacionaMix");

Console.WriteLine(" ");
Console.WriteLine("Primeiramente cadastre o preço inicial e preço por hora para configuração");

Console.WriteLine(" ");
Console.WriteLine("Digite o preço inicial:");
int precoInicial = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" ");
Console.WriteLine("Digite o preço por hora:");
int precoHora = Convert.ToInt32(Console.ReadLine());

Console.Clear();

EstacionamentoProgram estacionamento = new EstacionamentoProgram();
estacionamento.Menu(precoInicial,precoHora);

Console.WriteLine("O programa se encerrou");