﻿using System;
using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Jogador
{
    public class AlterarJogadorRequest : IRequest
    {
        public Guid Id { get; set; }

        public string Email { get; set; }

        public string PrimeiroNome { get; set; }

        public string UltimoNome { get; set; }        
    }
}
