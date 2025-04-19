// Pilar: Herança (Caminhao herda de Veiculo)
public class Caminhao : Veiculo
{
    // Pilar: Encapsulamento (propriedade com get/set)
    public int Eixos { get; set; }

    // Pilar: Herança (chamada do construtor da classe base)
    public Caminhao(string modelo, string marca, string cor, int ano, int eixos)
        : base(modelo, marca, cor, ano)
    {
        Eixos = eixos;
    }

    // Pilar: Polimorfismo (sobrescrita do método ToString da classe base)
    public override string ToString()
    {
        return base.ToString() + $" | Eixos: {Eixos}";
    }
}
