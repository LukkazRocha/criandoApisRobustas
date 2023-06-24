using System;
using System.Collections.Generic;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Repositories;

namespace XGame.Infra.Persistence.Repositories
{
    public class RepositoryJogador : IRepositoryJogador
    {
        #region Properties
        private readonly XGameContext _context;
        #endregion

        #region Constructor
        public RepositoryJogador(XGameContext context)
        {
            _context = context;
        }
        #endregion       

        public Jogador AdicionarJogador(Jogador jogador)
        {
            throw new NotImplementedException();
        }

        public void AlterarJogador(Jogador jogador)
        {
            throw new NotImplementedException();
        }

        public Jogador AutenticarJogador(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Jogador> ListarJogador()
        {
            throw new NotImplementedException();
        }

        public Jogador ObterJogadorPorId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
