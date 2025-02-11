public class VideoGame : Produto, Imposto
{
    private string marca;
    private string modelo;
    private bool isUsado;

    public VideoGame() { }

    public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado)
        : base(nome, preco, qtd) 
    { 
        Marca = marca;
        Modelo = modelo;
        IsUsado = isUsado;
    }

    public string Marca
    {
        get { return marca; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                marca = value;
            else
                throw new ArgumentException("A marca não pode ser vazia ou nula.");
        }
    }

    public string Modelo
    {
        get { return modelo; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                modelo = value;
            else
                throw new ArgumentException("O modelo não pode ser vazio ou nulo.");
        }
    }

    public bool IsUsado
    {
        get { return isUsado; }
        set { isUsado = value; }
    }

    public double calculaImposto()
    {
        if(isUsado)
        {
            Console.WriteLine($"Imposto {Nome} {Modelo} usado, R$ {Preco * 0.25}");
            return Preco * 0.25;
        }
        else
        {
            Console.WriteLine($"Imposto {Nome} {Modelo}, R$ {Preco * 0.45}");
            return Preco * 0.45;
        }
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.Write($", marca: {marca}, modelo: {modelo}, usado: {isUsado}");
    }
}
