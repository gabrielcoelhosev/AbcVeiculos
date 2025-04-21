public abstract class DePassageiros : Veiculo
{
    public DePassageiros(string modelo, string marca, string cor, int ano)
        : base(modelo, marca, cor, ano) { }

    public override string Categoria => "De Passageiros";
}

public abstract class DeCarga : Veiculo
{
    public DeCarga(string modelo, string marca, string cor, int ano)
        : base(modelo, marca, cor, ano) { }

    public override string Categoria => "De Carga";
}

public abstract class DeMisto : Veiculo
{
    public DeMisto(string modelo, string marca, string cor, int ano)
        : base(modelo, marca, cor, ano) { }

    public override string Categoria => "De Misto";
}
