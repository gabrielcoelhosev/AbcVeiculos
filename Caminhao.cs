public class Caminhao : Veiculo
{
    public int Eixos { get; set; }

    public Caminhao(string modelo, string marca, string cor, int ano, int eixos)
        : base(modelo, marca, cor, ano)
    {
        Eixos = eixos;
    }

    public override string ToString()
    {
        return base.ToString() + $" | Eixos: {Eixos}";
    }
}