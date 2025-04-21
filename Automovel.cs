// Pilar: Herança (Automovel herda de DePassageiros)
public class Automovel : DePassageiros
{
    // Pilar: Encapsulamento
    public int Portas { get; set; }

    public Automovel(string modelo, string marca, string cor, int ano, int portas)
        : base(modelo, marca, cor, ano)
    {
        Portas = portas;
    }

    // Pilar: Polimorfismo
    public override string ToString()
    {
        return base.ToString() + $" | Portas: {Portas}";
    }
}
