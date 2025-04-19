
public class Veiculos {

    public int VeiculoId { get; set; }
    public string Modelo { get; set;}
    public string Cor { get; set; } 
    public string Marca { get; set;}
    public int Ano { get; set; }

    public Veiculos(string modelo, string cor, string marca, int ano) {
        Modelo = modelo;
        Cor = cor;
        Marca = marca;
        Ano = ano;
    }
}