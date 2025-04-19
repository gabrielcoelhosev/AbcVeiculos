public class Carro : Veiculo
{
    public int Portas { get; set; }

    public Carro(string modelo, string marca, string cor, int ano, int portas)
        : base(modelo, marca, cor, ano)
    {
        Portas = portas;
    }

    public override string ToString()
    {
        return base.ToString() + $" | Portas: {Portas}";
    }
}