using System.Data.Common;
using System.Diagnostics;

public abstract class Produto
{
    private string nome;
    private double preco;
    private int qtd;

    public Produto() { }

    public Produto(string nome, double preco, int qtd)
    {
        Nome = nome;
        Preco = preco;
        Qtd = qtd;
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public double Preco
    {
        get { return preco; }
        set
        {
            if (value < 0)
                throw new ArithmeticException("O preço não pode ser menor que 0.");
            else
                preco = value;
        }
    }

    public int Qtd
    {
        get { return qtd; }
        set
        {
            if (value < 0)
                throw new ArithmeticException("A quantidade não pode ser menor que 0.");
            else
                qtd = value;
        }
    }

    //Método Virtual para permitir que seja substituída na classe derivida(VideoGame e Livro)
    public virtual void ExibirInformacoes()
    {
        Console.Write($"\nNome: {nome}, preço: R$ {preco}, quantidade: {qtd}");
    }
}
