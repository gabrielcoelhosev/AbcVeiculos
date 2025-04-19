// Pilar: Herança (Moto herda de Veiculo)
public class Moto : Veiculo
{
    // Pilar: Encapsulamento (propriedade com get/set)
    public int Cilindradas { get; set; }

    // Pilar: Herança (chamada do construtor da classe base)
    public Moto(string modelo, string marca, string cor, int ano, int cilindradas)
        : base(modelo, marca, cor, ano)
    {
        Cilindradas = cilindradas;
    }

    // Pilar: Polimorfismo (sobrescrita do método ToString da classe base)
    public override string ToString()
    {
        return base.ToString() + $" | Cilindradas: {Cilindradas}";
    }
}
