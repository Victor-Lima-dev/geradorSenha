using System;
namespace GeradorSenha;

class Senhas
{
    public int Senha { get; set; }

    public Senhas()
    {

    }

    public Senhas(int senha)
    {
        Senha = senha;
    }


    public string Gerador(int tamanho)
    {

        string senha = string.Empty;
        int Tamanho = tamanho;
        for (int i = 0; i < Tamanho; i++)
        {
            var aleatorio = new Random();
            int numero = aleatorio.Next(0, 10);
            senha += numero.ToString();
        }
        return senha;
    }
}