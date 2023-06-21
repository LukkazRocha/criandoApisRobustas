using System;
using System.Linq;
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

            //AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            //Console.WriteLine("Criei instancia do meu objeto request");
            //request.Email = "lucas@lucas.com";            
            //request.Senha = "123456789";

            var request = new AdicionarJogadorRequest()
            {
                Email = "lucas@lucas.com",
                PrimeiroNome = "Lucas",
                UltimoNome = "Rocha",
                Senha = "1234678"
            };


            var response = service.AdicionarJogador(request);

            //var response = service.AutenticarJogador(request);

            Console.WriteLine("Serviço é válido? " + service.IsValid());

            service.Notifications.ToList().ForEach(x =>
            {
                Console.WriteLine(x.Message);
            });

            Console.ReadKey();
        }
    }
}
