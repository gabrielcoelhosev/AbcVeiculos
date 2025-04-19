public class Moto : Veiculo
{
    public int Cilindradas { get; set; }

    public Moto(string modelo, string marca, string cor, int ano, int cilindradas)
        : base(modelo, marca, cor, ano)
    {
        Cilindradas = cilindradas;
    }

    public override string ToString()
    {
        return base.ToString() + $" | Cilindradas: {Cilindradas}";
    }
}