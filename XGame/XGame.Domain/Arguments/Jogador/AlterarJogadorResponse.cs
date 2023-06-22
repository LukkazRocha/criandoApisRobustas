using System;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Arguments;
using XGame.Domain.Resources;

namespace XGame.Domain.Arguments.Jogador
{
    public class AlterarJogadorResponse : IResponse
    {
        public Guid Id { get; set; }

        public string Email { get; set; }

        public string PrimeiroNome { get; set; }

        public string UltimoNome { get; set; }

        public string Message { get; set; }

        public static explicit operator AlterarJogadorResponse(Entities.Jogador entidade)
        {
            return new AlterarJogadorResponse()
            {
                Email = entidade.Email.Endereco,
                Id = entidade.Id,
                PrimeiroNome = entidade.Nome.PrimeiroNome,
                UltimoNome = entidade.Nome.UltimoNome,
                Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
}
