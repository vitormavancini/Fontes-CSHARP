using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes {get; set; }
        public Suite Suite {get; set; }
        public int DiasReservados { get; set; }
        
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
 
        public void CadastrarHospedes(List<Pessoa> hospedes )
        {
            bool possuiCapacidade = hospedes.Count <= Suite.Capacidade;
            
            if (possuiCapacidade)
            {
                Hospedes = hospedes;
            }
            else 
            {
                throw new ArgumentException("Quantidade de hospedes é superior a capacidade disponivel da suite.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidade = Hospedes.Count;
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorPagar = Suite.ValorDiaria * DiasReservados;
            bool temDesconto = DiasReservados >= 10;

            if (temDesconto)
            {
                valorPagar -= valorPagar * 0.1M; //Desconto de 10%.
            }
            
            return valorPagar;
        }
    }
}