namespace DesafioPOO.Models
using System;
using System.Collections.Generic;

public class Contato
{
    public string Nome { get; set; }
    public string Numero { get; set; }
}

public class Aplicativo
{
    public string Nome { get; set; }
    public int Tamanho { get; set; }
}

public abstract class Smartphone
{
    public string Numero { get; set; }
    private string Modelo { get; set; }
    private string IMEI { get; set; }
    private int Memoria { get; set; }
    private List<Contato> Contatos { get; set; }
    private List<Aplicativo> Aplicativos { get; set; }

    public Smartphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        IMEI = imei;
        Memoria = memoria;
        Contatos = new List<Contato>();
        Aplicativos = new List<Aplicativo>();
    }

    public void Ligar()
    {
        Console.WriteLine("Ligando...");

        if (Contatos.Count > 0)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Escolher contato");

            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.WriteLine("Escolha um contato:");
                for (int i = 0; i < Contatos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Contatos[i].Nome}");
                }

                int indiceContato = int.Parse(Console.ReadLine()) - 1;

                if (indiceContato >= 0 && indiceContato < Contatos.Count)
                {
                    FazerLigacao(Contatos[indiceContato].Numero);
                }
                else
                {
                    Console.WriteLine("Índice de contato inválido. Digite um número manualmente.");
                    DigitarNumeroManualmente();
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Digite um número manualmente.");
                DigitarNumeroManualmente();
            }
        }
        else
        {
            Console.WriteLine("Não há contatos salvos. Digite um número manualmente.");
            DigitarNumeroManualmente();
        }
    }

    private void DigitarNumeroManualmente()
    {
        Console.Write("Digite o número (9 dígitos): ");
        string numeroChamada = Console.ReadLine();
        FazerLigacao(numeroChamada);
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação...");

        if (Contatos.Count > 0)
        {
            Random random = new Random();
            int indiceContato = random.Next(Contatos.Count);
            Console.WriteLine($"Chamada de {Contatos[indiceContato].Nome}");
        }
        else
        {
            Console.WriteLine("Chamada de número desconhecido.");
        }
    }

    public void BaixarAplicativo(string nomeApp, int tamanho)
    {
        if (tamanho <= Memoria)
        {
            Aplicativos.Add(new Aplicativo { Nome = nomeApp, Tamanho = tamanho });
            Memoria -= tamanho;
            Console.WriteLine($"Aplicativo {nomeApp} baixado. Memória restante: {Memoria} MB");
        }
        else
        {
            Console.WriteLine("Memória insuficiente para baixar o aplicativo.");
        }
    }

    public void EnviarSMS()
    {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1. Digitar número");
        Console.WriteLine("2. Escolher contato");

        string opcao = Console.ReadLine();

        string numeroDestino = "";

        if (opcao == "1")
        {
            Console.Write("Digite o número (9 dígitos): ");
            numeroDestino = Console.ReadLine();
        }
        else if (opcao == "2")
        {
            if (Contatos.Count > 0)
            {
                Console.WriteLine("Escolha um contato:");
                for (int i = 0; i < Contatos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Contatos[i].Nome}");
                }

                int indiceContato = int.Parse(Console.ReadLine()) - 1;

                if (indiceContato >= 0 && indiceContato < Contatos.Count)
                {
                    numeroDestino = Contatos[indiceContato].Numero;
                }
                else
                {
                    Console.WriteLine("Índice de contato inválido. Enviando para número padrão.");
                    numeroDestino = "123456789";
                }
            }
            else
            {
                Console.WriteLine("Não há contatos salvos. Enviando para número padrão.");
                numeroDestino = "123456789";
            }
        }
        else
        {
            Console.WriteLine("Opção inválida.");
            return;
        }

        Console.Write("Digite a mensagem (máximo 500 caracteres): ");
        string mensagem = Console.ReadLine();

        try
        {
            EnviarSMS(numeroDestino, mensagem);
            Console.WriteLine("SMS enviado com sucesso.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Número inválido. Certifique-se de digitar apenas números.");
        }
    }

    public abstract void InstalarAplicativo(string nomeApp);

    public abstract void EnviarSMS(string numeroDestino, string mensagem);

    public void ChecarMemoria()
    {
        Console.WriteLine($"Memória disponível: {Memoria} MB");
    }

    private void FazerLigacao(string numero)
    {
        try
        {
            Console.WriteLine($"Ligando para {numero}...");
        }
        catch (FormatException)
        {
            Console.WriteLine("Número inválido. Certifique-se de digitar apenas números.");
        }
    }
}