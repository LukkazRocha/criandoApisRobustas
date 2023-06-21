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

            //var autenticarRequest = new AutenticarJogadorRequest();
            //Console.WriteLine("Criei instancia do meu objeto request");
            //autenticarRequest.Email = "lucas@lucas.com";
            //autenticarRequest.Senha = "123456789";

            //var adicionarRequest = new AdicionarJogadorRequest()
            //{
            //    Email = "lucas@lucas.com",
            //    PrimeiroNome = "Lucas",
            //    UltimoNome = "Rocha",
            //    Senha = "1234678"
            //};

            //var response = service.AutenticarJogador(autenticarRequest);

            //var response2 = service.AdicionarJogador(adicionarRequest);

            var result = service.ListarJogador();

            Console.WriteLine("Serviço é válido? " + service.IsValid());

            service.Notifications.ToList().ForEach(x =>
            {
                Console.WriteLine(x.Message);
            });

            Console.ReadKey();
        }
    }
}
