using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Ana", "Silva");
Pessoa p2 = new Pessoa("Pedro", "Melo");
//Pessoa p3 = new Pessoa("Julia", "Flores");
//Pessoa p4 = new Pessoa("Lucas", "Santos");
//Pessoa p5 = new Pessoa("José", "Folgado");

hospedes.Add(p1);
hospedes.Add(p2);
//hospedes.Add(p3);
//hospedes.Add(p4);
//hospedes.Add(p5);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 100);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"--------------------------");
Console.WriteLine($"\nCapacidade máxima: {suite.Capacidade} pessoas");
Console.WriteLine($"Valor da diária: R${suite.ValorDiaria}");
Console.WriteLine($"\nQuantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Quantidade de dias: {reserva.DiasReservados}");
Console.WriteLine($"Valor total: R${reserva.CalcularValorDiaria()}\n");
Console.WriteLine($"------- Reserva realizada com sucesso! -------\n");