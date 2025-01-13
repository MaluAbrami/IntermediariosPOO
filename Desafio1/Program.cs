using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int op;
        Veiculo veiculo = new Veiculo("Honda", "Civic", "1242ASFJA", "Preto", 570, 25, 125000);

        do
        {
            Console.WriteLine("\n1-Editar Veiculo");
            Console.WriteLine("2-Acelerar");
            Console.WriteLine("3-Abastecer");
            Console.WriteLine("4-Frear");
            Console.WriteLine("5-Pintar");
            Console.WriteLine("6-Ligar");
            Console.WriteLine("7-Desligar");
            Console.WriteLine("8-Exibir Informações");
            Console.WriteLine("9-Sair do sistema");

            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                {
                    try
                    {
                        Console.WriteLine("Marca: ");
                        string? marca = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(marca))
                            throw new ArgumentException("A marca não pode ser vazia ou nula.");

                        Console.WriteLine("Modelo: ");
                        string? modelo = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(modelo))
                            throw new ArgumentException("O modelo não pode ser vazio ou nulo.");

                        Console.WriteLine("Placa: ");
                        string? placa = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(placa))
                            throw new ArgumentException("A placa não pode ser vazia ou nula.");

                        Console.WriteLine("Cor: ");
                        string? cor = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(cor))
                            throw new ArgumentException("A cor não pode ser vazia ou nula.");

                        Console.WriteLine("Km: ");
                        float km = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Litros de Combustível: ");
                        int litrosCombustivel = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Preço: ");
                        double preco = Convert.ToDouble(Console.ReadLine());

                        veiculo = new Veiculo(
                            marca,
                            modelo,
                            placa,
                            cor,
                            km,
                            litrosCombustivel,
                            preco
                        );
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: o formato do valor inserido não é válido.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine(
                            "Erro: o valor é muito grande ou muito pequeno para ser representado com um float."
                        );
                    }

                    break;
                }
                case 2:
                {
                    try
                    {
                        veiculo.Acelerar();
                        Console.WriteLine(
                            $"O veiculo está 20km/h mais rápido.\nVelocidade atual: {veiculo.Velocidade}\n"
                        );
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}");
                    }
                    break;
                }
                case 3:
                {
                    try
                    {
                        Console.WriteLine("Informe quantos litros deseja abastecer: ");
                        int litrosCombustivel = Convert.ToInt32(Console.ReadLine());
                        veiculo.Abastecer(litrosCombustivel);
                        Console.WriteLine(
                            $"O veiculo foi abastecido!\nLitros de Combustivel atual: {veiculo.LitrosCombustivel}\n"
                        );
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: o formato do valor inserido não é válido.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine(
                            "Erro: o valor é muito grande ou muito pequeno para ser representado com um int."
                        );
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}");
                    }
                    break;
                }
                case 4:
                {
                    try
                    {
                        veiculo.Frear();
                        Console.WriteLine(
                            $"O veiculo freiou com sucesso.\nVelocidade atual: {veiculo.Velocidade}"
                        );
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}");
                    }
                    break;
                }
                case 5:
                {
                    try
                    {
                        Console.WriteLine("Informe a cor que deseja pintar: ");
                        string? cor = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(cor))
                            throw new ArgumentException("A cor não pode ser vazia ou nula.");

                        veiculo.Pintar(cor);
                        Console.WriteLine("O veiculo foi pintado com sucesso.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}");
                    }
                    break;
                }
                case 6:
                {
                    try
                    {
                        veiculo.Ligar();
                        Console.WriteLine("O veiculo foi ligado com sucesso.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}");
                    }
                    break;
                }
                case 7:
                {
                    try
                    {
                        veiculo.Desligar();
                        Console.WriteLine("O veiculo foi desligado com sucesso.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}");
                    }
                    break;
                }
                case 8:
                {
                    veiculo.ExibirInformacoes();
                    break;
                }
                case 9:
                {
                    Console.WriteLine("Saindo...");
                    break;
                }
                default:
                {
                    break;
                }
            }
        } while (op != 9);
    }
}
