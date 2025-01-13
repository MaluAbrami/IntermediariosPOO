public class Livro : Produto
{
    private string autor;
    private string tema;
    private int qtdPag;

    public Livro() { }

    public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag)
        : base(nome, preco, qtd) { }

    public string Autor
    {
        get { return autor; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                autor = value;
            else
                throw new ArgumentException("O autor não pode ser vazio ou nulo.");
        }
    }

    public string Tema
    {
        get { return tema; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                tema = value;
            else
                throw new ArgumentException("O tema não pode ser vazio ou nulo.");
        }
    }

    public int QtdPag
    {
        get { return qtdPag; }
        set
        {
            if (value > 0)
                qtdPag = value;
            else
                throw new ArithmeticException(
                    "A quantidade de páginas não pode ser menor ou igual a 0."
                );
        }
    }
}
