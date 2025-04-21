public class Motocicleta : DePassageiros
{
    public int Cilindradas { get; set; }

    public Motocicleta(string modelo, string marca, string cor, int ano, int cilindradas)
        : base(modelo, marca, cor, ano)
    {
        Cilindradas = cilindradas;
    }

    public override string ToString()
    {
        return base.ToString() + $" | Cilindradas: {Cilindradas}";
    }
}
