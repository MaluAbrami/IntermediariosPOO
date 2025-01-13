using System.Data.Common;
using System.Diagnostics;

public class Veiculo
{
    private string marca;
    private string modelo;
    private string placa;
    private string cor;
    private float km;
    private bool isLigado;
    private int litrosCombustivel;
    private int velocidade;
    private double preco;

    public Veiculo(
        string marca,
        string modelo,
        string placa,
        string cor,
        float km,
        int litrosCombustivel,
        double preco
    )
    {
        Marca = marca;
        Modelo = modelo;
        Placa = placa;
        Cor = cor;
        Km = km;
        IsLigado = false;
        LitrosCombustivel = litrosCombustivel;
        Velocidade = 0;
        Preco = preco;
    }

    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public string Placa
    {
        get { return placa; }
        set { placa = value; }
    }

    public string Cor
    {
        get { return cor; }
        set { cor = value; }
    }

    public float Km
    {
        get { return km; }
        set
        {
            if (value >= 0)
                km = value;
            else
                throw new ArgumentOutOfRangeException("O km não pode ser menor que 0.");
        }
    }

    public bool IsLigado
    {
        get { return isLigado; }
        set { isLigado = value; }
    }

    public int LitrosCombustivel
    {
        get { return litrosCombustivel; }
        set
        {
            if (value >= 0 && value <= 60)
                litrosCombustivel = value;
            else
                throw new ArgumentOutOfRangeException(
                    "Os litros do combustivel não pode ser menor que 0 e não pode exceder o limite de 60 litros do tanque."
                );
        }
    }

    public int Velocidade
    {
        get { return velocidade; }
        set
        {
            if (value >= 0)
                velocidade = value;
            else
                throw new ArgumentOutOfRangeException("A velocidade não pode ser menor que 0.");
        }
    }

    public double Preco
    {
        get { return preco; }
        set
        {
            if (value >= 0)
                preco = value;
            else
                throw new ArgumentOutOfRangeException("O preço não pode ser menor que 0.");
        }
    }

    public void Acelerar()
    {
        if (isLigado)
            Velocidade += 20;
        else
            throw new InvalidOperationException(
                "Não é possível acelerar um veiculo que está desligado."
            );
    }

    public void Abastecer(int combustivel)
    {
        if (LitrosCombustivel + combustivel > 60)
            throw new ArgumentOutOfRangeException(
                "Erro: A quantidade de combustivel inserida excede o limite do tanque."
            );
        else
            LitrosCombustivel += combustivel;
    }

    public void Frear()
    {
        if(!isLigado)
            throw new InvalidOperationException(
                "Não é possível frear um veiculo que está desligado."
            );

        if (Velocidade - 20 == 0)
            throw new ArgumentOutOfRangeException("O veiculo já se encontra parado.");
        else if (Velocidade - 20 < 0)
            Velocidade = 0;
        else
            Velocidade -= 20;
    }

    public void Pintar(string cor)
    {
        if (!string.IsNullOrWhiteSpace(cor))
            Cor = cor;
        else
            throw new ArgumentException("A cor não pode ser vazia ou nula.");
    }

    public void Ligar()
    {
        if (IsLigado)
            throw new InvalidOperationException("O veiculo já se encontra ligado.");
        else
            IsLigado = true;
    }

    public void Desligar()
    {
        if (!IsLigado)
            throw new InvalidOperationException("O carro já se encontra desligado.");
        else
        {
            if (Velocidade > 0)
                throw new OverflowException(
                    "O veiculo não pode ser desligado com uma velocidade superior a 0."
                );
            else
                IsLigado = false;
        }
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine(
            $"\nMarca: {marca}\nModelo: {modelo}\nPlaca: {placa}\nCor: {cor}\nKm: {km}\nLigado: {isLigado}\nLitros de Combustivel: {litrosCombustivel}\nVelocidade: {velocidade}\nPreço: {preco}"
        );
    }
}
