using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria as suítes
List<Suite> suites = new List<Suite>
{
    new Suite(tipoSuite: "Upper - Premium", capacidade: 2, valorDiaria: 60),
    new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30),
    new Suite(tipoSuite: "Tradicional", capacidade: 4, valorDiaria: 15),
    new Suite(tipoSuite: "Básica", capacidade: 1, valorDiaria: 10)
};

// Seleciona uma das suítes para a reserva (ex: Upper - Premium)
Suite suiteSelecionada = suites[0]; // Alterar o índice conforme necessário

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suiteSelecionada);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da diária: {reserva.CalcularValorDiaria()}");
