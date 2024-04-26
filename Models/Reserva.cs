using System.Linq.Expressions;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido - IMPLEMENTAR AQUI

            int capacidade = Suite.Capacidade;    
                //Declara capacidade do tipo inteiro
            if (capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;

                Console.WriteLine("\nLista de hóspedes:");
                foreach(var hospede in hospedes)
                {
                    Console.WriteLine($"{hospede.NomeCompleto}");
                }
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido - IMPLEMENTAR AQUI

                throw new Exception("A quantidade máxima de hóspedes foi atingida! Verifique a capacidade da suite e tente novamente.\n");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes) - IMPLEMENTAR AQUI*

            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária e realiza o cálculo: DiasReservados X Suite.ValorDiaria - IMPLEMENTAR AQUI

            decimal valorDiaria = Suite.ValorDiaria;
            decimal valorTotal = DiasReservados * valorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10% - IMPLEMENTAR AQUI
            if (DiasReservados >= 10)
            {
                Console.WriteLine("\nVocê recebeu 10% de desconto no valor total!");
                decimal desconto = valorTotal * 0.10M;
                    //variável desconto recebe o valor total e multiplica por 10%
                valorTotal = valorTotal - desconto;
                    //Valor total recebe valor total menos o resultado armazenado em DESCONTO
            }

            return valorTotal;
        }
    }
}