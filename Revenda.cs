public class Revenda
{
    // Pilar: Encapsulamento (propriedades públicas com acesso controlado)
    public string Nome { get; set; }
    public string Endereco { get; set; }

    // Pilar: Encapsulamento (a lista só pode ser modificada pela própria classe)
    public List<Veiculo> Patio { get; private set; }

    // Pilar: Abstração (construtor define um objeto representando uma revenda real)
    public Revenda(string nome, string endereco)
    {
        Nome = nome;
        Endereco = endereco;
        Patio = new List<Veiculo>();
    }

    // Pilar: Encapsulamento (manipulação da lista somente através de métodos da classe)
    public void AdicionarVeiculo(Veiculo veiculo)
    {
        Patio.Add(veiculo);
    }

    // Pilar: Polimorfismo (chamada do método ToString() que pode ser sobrescrito pelas subclasses)
    public void ListarTodos()
    {
        Console.WriteLine($"\nRevenda: {Nome}, Endereço: {Endereco}");
        Console.WriteLine("Veículos no pátio:");
        foreach (var v in Patio)
        {
            Console.WriteLine(v); // ToString polimórfico
        }
    }

    // Pilar: Polimorfismo (uso de generics para filtrar veículos com base em seu tipo real)
    public void ListarPorTipo<T>() where T : Veiculo
    {
        Console.WriteLine($"\nVeículos do tipo {typeof(T).Name}:");
        foreach (var v in Patio)
        {
            if (v is T)
                Console.WriteLine(v); // ToString polimórfico
        }
    }
}
