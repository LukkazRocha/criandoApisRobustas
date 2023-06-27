using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using XGame.Domain.Arguments.Jogo;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;

namespace XGame.Domain.Services
{
    public class ServiceJogo : Notifiable, IServiceJogo
    {
        private readonly IRepositoryJogo _repositoryJogo;

        public ServiceJogo() { }

        public AdicionarJogoResponse AdicionarJogo(AdicionarJogoRequest request)
        {
            var jogo = new Jogo(request.Nome, request.Descricao, request.Produtora,
                request.Distribuidora, request.Genero, request.Site);

            AddNotifications(jogo);            

            if (IsInvalid())
            {
                return null;
            }

            jogo = _repositoryJogo.Adicionar(jogo);

            return (AdicionarJogoResponse)jogo;
        }

        public AlterarJogoResponse AlterarJogo(AlterarJogoRequest request)
        {
            throw new NotImplementedException();
        }

        public ExcluirJogoResponse ExcluirJogo(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JogoResponse> ListarJogo()
        {
            throw new NotImplementedException();
        }
    }
}
