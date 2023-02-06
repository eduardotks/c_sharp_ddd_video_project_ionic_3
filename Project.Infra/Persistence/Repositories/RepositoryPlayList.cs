using System;
using System.Collections.Generic;
using System.Linq;
using Project.Domain.Entities;
using Project.Domain.Interfaces.Repositories;
using Project.Infra.Persistence.EF;

namespace Project.Infra.Persistence.Repositories
{
    public class RepositoryPlayList : IRepositoryPlayList
    {
        private readonly ProjectContext _context;

        public RepositoryPlayList(ProjectContext context)
        {
            _context = context;
        }

        public PlayList Adicionar(PlayList playList)
        {
            _context.PlayLists.Add(playList);

            return playList;
        }

        public void Excluir(PlayList playList)
        {
            _context.PlayLists.Remove(playList);
        }

        public IEnumerable<PlayList> Listar(Guid idUsuario)
        {
            return _context.PlayLists.Where(x => x.Usuario.Id == idUsuario).ToList();
        }

        public PlayList Obter(Guid idPlayList)
        {
            return _context.PlayLists.FirstOrDefault(x => x.Id == idPlayList);
        }
    }
}
