using System.Text;
using Hospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hópedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hópede 1 ", sobrenome: "");
Pessoa p2 = new Pessoa(nome: "Hópede 2 ", sobrenome: "");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a Suite
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

// Cria uma nova reserva
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hospedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");