// Pilar: Herança (Carro herda de Veiculo)
public class Carro : Veiculo
{
    // Pilar: Encapsulamento (propriedade com get/set)
    public int Portas { get; set; }

    // Pilar: Herança (chamada do construtor da classe base)
    public Carro(string modelo, string marca, string cor, int ano, int portas)
        : base(modelo, marca, cor, ano)
    {
        Portas = portas;
    }

    // Pilar: Polimorfismo (sobrescrita do método ToString da classe base)
    public override string ToString()
    {
        return base.ToString() + $" | Portas: {Portas}";
    }
}
