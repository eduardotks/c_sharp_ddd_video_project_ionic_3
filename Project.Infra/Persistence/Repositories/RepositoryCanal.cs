using System;
using System.Collections.Generic;
using System.Linq;
using Project.Domain.Entities;
using Project.Domain.Interfaces.Repositories;
using Project.Infra.Persistence.EF;

namespace Project.Infra.Persistence.Repositories
{
    public class RepositoryCanal : IRepositoryCanal
    {
        private readonly ProjectContext _context;

        public RepositoryCanal(ProjectContext context)
        {
            _context = context;
        }

        public Canal Adicionar(Canal canal)
        {
            _context.Canais.Add(canal);

            return canal;
        }

        public void Excluir(Canal canal)
        {
            _context.Canais.Remove(canal);
        }

        public IEnumerable<Canal> Listar(Guid idUsuario)
        {
            return _context.Canais.Where(x => x.Usuario.Id == idUsuario).ToList();
        }

        public Canal Obter(Guid idCanal)
        {
            return _context.Canais.FirstOrDefault(x => x.Id == idCanal);
        }
    }
}
