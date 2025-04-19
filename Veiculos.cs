// Pilar: Abstração (classe representa um conceito genérico de veículo)
public abstract class Veiculo
{
    // Pilar: Encapsulamento (campo privado com controle interno de ID)
    private static int _ultimoId = 0;

    // Pilar: Encapsulamento (acesso controlado à propriedade Id)
    public int Id { get; private set; }
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public string Cor { get; set; }
    public int Ano { get; set; }

    // Pilar: Abstração (construtor define os atributos essenciais de um veículo)
    public Veiculo(string modelo, string marca, string cor, int ano)
    {
        Id = ++_ultimoId; // Geração automática de ID
        Modelo = modelo;
        Marca = marca;
        Cor = cor;
        Ano = ano;
    }

    // Pilar: Polimorfismo (método que pode ser sobrescrito ou chamado pelas subclasses)
    public override string ToString()
    {
        return $"ID: {Id} | Tipo: {GetType().Name} | Modelo: {Modelo}, Marca: {Marca}, Cor: {Cor}, Ano: {Ano}";
    }
}
