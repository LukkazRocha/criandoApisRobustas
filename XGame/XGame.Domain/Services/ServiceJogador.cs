﻿using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;
using XGame.Domain.Resources;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Services
{
    public class ServiceJogador : Notifiable, IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador() { }

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            var nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            var email = new Email(request.Email);

            Jogador jogador = new Jogador(nome, email, request.Senha);

            AddNotifications(jogador);

            if (IsInvalid())
            {
                return null;
            }

            jogador = _repositoryJogador.AdicionarJogador(jogador);

            return (AdicionarJogadorResponse)jogador;
        }

        public AlterarJogadorResponse AlterarJogador(AlterarJogadorRequest request)
        {
            throw new NotImplementedException();
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                AddNotification("AutenticarJogadorRequest", Message.X0_E_OBRIGATORIO.ToFormat("AutenticarJogadorRequest"));
            }

            var email = new Email(request.Email);
            var jogador = new Jogador(email, request.Senha);

            AddNotifications(jogador, email);

            if (jogador.IsInvalid())
            {
                return null;
            }

            jogador = _repositoryJogador.AutenticarJogador(jogador.Email.Endereco, jogador.Senha);

            return (AutenticarJogadorResponse)jogador;
        }

        public IEnumerable<JogadorResponse> ListarJogador()
        {
            return _repositoryJogador.ListarJogador().ToList().Select(jogador => (JogadorResponse)jogador).ToList();
        }
    }
}
