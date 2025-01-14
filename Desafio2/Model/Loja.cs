public class Loja
{
    private string nome;
    private string cnpj;
    private List<Livro> livros;
    private List<VideoGame> videoGames;

    public Loja() {}

    public Loja(string nome, string cnpj)
    {
        Nome = nome;
        Cnpj = cnpj;
        livros = new List<Livro>();
        videoGames = new List<VideoGame>();
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

    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
    }

    public void AdicionarVideoGame(VideoGame videoGame)
    {
        videoGames.Add(videoGame);
    }

    public void ListaLivros()
    {
        if(livros.Count() == 0)
            Console.WriteLine("A loja não tem livros no seu estoque.");
        else
            foreach(Livro l in livros)
                l.ExibirInformacoes();
    }

    public void ListaVideoGames()
    {
        if(videoGames.Count() == 0)
            Console.WriteLine("A loja não tem videogames no seu estoque.");
        else
            foreach(VideoGame v in videoGames)
                v.ExibirInformacoes();
    }

    public double calculaPatrimonio()
    {
        double patrimonioTotal = 0;

        foreach(Livro l in livros)
            patrimonioTotal += (l.Preco * l.Qtd);
        
        foreach(VideoGame v in videoGames)
            patrimonioTotal += (v.Preco * v.Qtd);

        return patrimonioTotal;
    }
}