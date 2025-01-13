public class VideoGame : Produto, Imposto
{
    private string marca;
    private string modelo;
    private bool isUsado;

    public VideoGame() { }

    public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado)
        : base(nome, preco, qtd) { }

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
            return Preco * 0.25;
        else
            return Preco * 0.45;
    }
}
