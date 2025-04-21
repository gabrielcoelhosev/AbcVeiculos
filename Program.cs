// Participantes: Gabriel Coelho Severino, Leandro Jader Ramos Nunes, André Nicolas Granemann Coelho

using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        // Pilar: Abstração (a revendedora é criada automaticamente, ocultando os detalhes da inicialização)
        Revenda revenda = new Revenda("ABC Bolinhas", "Endereço padrão");

        bool executando = true;

        while (executando)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1 - Adicionar veículo");
            Console.WriteLine("2 - Listar todos os veículos");
            Console.WriteLine("3 - Listar apenas carros");
            Console.WriteLine("4 - Listar apenas motos");
            Console.WriteLine("5 - Listar apenas caminhões");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("\nTipos de veículos:");
                    Console.WriteLine("1 - Automóvel");
                    Console.WriteLine("2 - Motocicleta");
                    Console.WriteLine("3 - Caminhão");
                    Console.Write("Escolha o tipo: ");
                    string tipo = Console.ReadLine();

                    Console.Write("Modelo: ");
                    string modelo = Console.ReadLine();
                    Console.Write("Marca: ");
                    string marca = Console.ReadLine();
                    Console.Write("Cor: ");
                    string cor = Console.ReadLine();
                    Console.Write("Ano: ");
                    int ano = int.Parse(Console.ReadLine());

                    if (tipo == "1")
                    {
                        Console.Write("Número de portas: ");
                        int portas = int.Parse(Console.ReadLine());
                        // Pilar: Polimorfismo (instância Automovel tratada como Veiculo)
                        revenda.AdicionarVeiculo(new Automovel(modelo, marca, cor, ano, portas));
                    }
                    else if (tipo == "2")
                    {
                        Console.Write("Cilindradas: ");
                        int cilindradas = int.Parse(Console.ReadLine());
                        // Pilar: Polimorfismo
                        revenda.AdicionarVeiculo(new Motocicleta(modelo, marca, cor, ano, cilindradas));
                    }
                    else if (tipo == "3")
                    {
                        Console.Write("Número de eixos: ");
                        int eixos = int.Parse(Console.ReadLine());
                        // Pilar: Polimorfismo
                        revenda.AdicionarVeiculo(new Caminhao(modelo, marca, cor, ano, eixos));
                    }
                    else
                    {
                        Console.WriteLine("Tipo inválido!");
                    }
                    break;

                case "2":
                    revenda.ListarTodos();
                    break;
                case "3":
                    revenda.ListarPorTipo<Automovel>();
                    break;
                case "4":
                    revenda.ListarPorTipo<Motocicleta>();
                    break;
                case "5":
                    revenda.ListarPorTipo<Caminhao>();
                    break;
                case "0":
                    executando = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        Console.WriteLine("Programa encerrado.");
    }
}
