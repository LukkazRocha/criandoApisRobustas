using System;
using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Jogo
{
    public class AlterarJogoRequest : IRequest
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Produtora { get; set; }

        public string Distribuidora { get; set; }

        public string Genero { get; set; }

        public string Site { get; set; }
    }
}
