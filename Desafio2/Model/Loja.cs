public class Loja
{
    private string nome;
    private string cnpj;
    private List<Livro> livros;
    private List<VideoGame> videoGames;

    public Loja() {}

    public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
    {

    }

    public string Nome
    {
        get { return nome; }
        set 
        {
            if(!string.IsNullOrWhiteSpace(value))
                nome = value;
            else
                throw new ArgumentException("O nome não pode ser vazio ou nulo.");
        }
    }

    public string Cnpj
    {
        get { return cnpj; }
        set
        {
            if(!string.IsNullOrWhiteSpace(value))
            {
                value = new string(value.Where(char.IsDigit).ToArray());
                if(value.Length != 14)
                    throw new ArgumentException("Cnpj inválido.");
                else
                    cnpj = value;
            }
            else
                throw new ArgumentException("O cnpj não pode ser vazio ou nulo.");
        }
    }

    public List<Livro> Livros
    {
        get { return livros; }
        set { livros = value; }
    }

    public List<VideoGame> VideoGames
    {
        get { return videoGames; }
        set { videoGames = value; }
    }
}