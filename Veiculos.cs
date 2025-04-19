public abstract class Veiculo
{
    private static int _ultimoId = 0;

    public int Id { get; private set; }
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public string Cor { get; set; }
    public int Ano { get; set; }

    public Veiculo(string modelo, string marca, string cor, int ano)
    {
        Id = ++_ultimoId;
        Modelo = modelo;
        Marca = marca;
        Cor = cor;
        Ano = ano;
    }

    // Pilar: Polimorfismo
    public override string ToString()
    {
        return $"ID: {Id} | Tipo: {GetType().Name} | Modelo: {Modelo}, Marca: {Marca}, Cor: {Cor}, Ano: {Ano}";
    }
}