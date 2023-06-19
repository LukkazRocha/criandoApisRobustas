using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Services;

namespace XGame.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando ....");

            var service = new ServiceJogador();
            Console.WriteLine("Criei instancia do serviço");

            AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            Console.WriteLine("Criei instancia do meu objeto request");
            request.Email = "Lucas";

            var response = service.AutenticarJogador(request);
            Console.ReadKey();
        }
    }
}
