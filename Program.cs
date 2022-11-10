using System;

namespace GeradorSenha;

class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            

            Console.WriteLine("Quantos digitos na Senha?");
            int digitos = int.Parse(Console.ReadLine());
            Senhas senha = new Senhas();

            string senhaGerada;
            string senhaGerada2;

            senhaGerada = senha.Gerador(digitos);
            senhaGerada2 = senha.Gerador(digitos);

            var ListaSenhas = new List<string>();

            ListaSenhas.Add(senhaGerada);
            ListaSenhas.Add(senhaGerada2);

            foreach (var item in ListaSenhas)
            {
                Console.WriteLine(item);
            }
            
            
        }
    }
