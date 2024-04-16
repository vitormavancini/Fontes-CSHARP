using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.Common.Models
{
    public class EstacionamentoProgram
    {
    
        public string opcao;
        public string veiculoRemovido;
        public int horasEstacionado;
        public int precoPagar;
        public List<string> veiculos = new List<string>();

        public void Menu(int precoInicial, int precoHora){
            do {
                Console.WriteLine("Digite a sua opção: ");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículo");
                Console.WriteLine("4 - Encerrar");
    
                opcao = Console.ReadLine();

                switch(opcao){
                    case "1":
                        Console.WriteLine(" ");
                        Console.WriteLine("Digite a placa do veículo para estacionar:");
                        veiculos.Add(Console.ReadLine());
                        
                        Console.WriteLine(" ");
                        Console.WriteLine("Precione uma tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        Console.WriteLine(" ");
                        Console.WriteLine("Digite a placa do veículo para remover:");
                        veiculoRemovido = Console.ReadLine();
                        veiculos.Remove(veiculoRemovido);
                        
                        Console.WriteLine(" ");
                        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                        horasEstacionado = Convert.ToInt32(Console.ReadLine());
                        precoPagar = precoInicial + (horasEstacionado * precoHora);
                        
                        Console.WriteLine(" ");
                        Console.WriteLine($"O veículo {veiculoRemovido} foi removido e o preço total foi de: R$ {precoPagar}");
                        
                        Console.WriteLine(" ");
                        Console.WriteLine("Precione uma tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.WriteLine(" ");
                        Console.WriteLine("Os veículos estacionados são:");
                        
                        for(int contador = 0; contador < veiculos.Count; contador++){
                            Console.WriteLine(veiculos[contador]);
                        }
                        
                        Console.WriteLine(" ");
                        Console.WriteLine("Precione uma tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    
                    case "4":
                        Console.WriteLine(" ");
                        Console.WriteLine("Precione uma tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine(" ");
                        Console.WriteLine("Opção invalida");
                        Console.WriteLine("Precione uma tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while(opcao != "4");
        }
    }
}