public class Revenda
{
    // Pilar: Encapsulamento
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public List<Veiculo> Patio { get; private set; }

    public Revenda(string nome, string endereco)
    {
        Nome = nome;
        Endereco = endereco;
        Patio = new List<Veiculo>();
    }

    public void AdicionarVeiculo(Veiculo veiculo)
    {
        Patio.Add(veiculo);
    }

    public void ListarTodos()
    {
        Console.WriteLine($"\nRevenda: {Nome}, Endereço: {Endereco}");
        Console.WriteLine("Veículos no pátio:");
        foreach (var v in Patio)
        {
            Console.WriteLine(v);
        }
    }

    public void ListarPorTipo<T>() where T : Veiculo
    {
        Console.WriteLine($"\nVeículos do tipo {typeof(T).Name}:");
        foreach (var v in Patio)
        {
            if (v is T)
                Console.WriteLine(v);
        }
    }
}
