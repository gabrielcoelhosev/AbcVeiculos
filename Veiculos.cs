public abstract class Veiculo
{
    private static int _ultimoId = 0;

    public int Id { get; private set; }
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public string Cor { get; set; }
    public int Ano { get; set; }

    // 👉 Pilar: Abstração (exige que subclasses definam a categoria)
    public abstract string Categoria { get; }

    public Veiculo(string modelo, string marca, string cor, int ano)
    {
        Id = ++_ultimoId;
        Modelo = modelo;
        Marca = marca;
        Cor = cor;
        Ano = ano;
    }

    public override string ToString()
    {
        return $"ID: {Id} | Tipo: {GetType().Name} | Categoria: {Categoria} | Modelo: {Modelo}, Marca: {Marca}, Cor: {Cor}, Ano: {Ano}";
    }
}
