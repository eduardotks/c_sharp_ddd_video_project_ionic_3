using System;
using System.Collections.Generic;
using Project.Domain.Entities;

namespace Project.Domain.Interfaces.Repositories
{
    public interface IRepositoryCanal
    {
        IEnumerable<Canal> Listar(Guid idUsuario);
        Canal Obter(Guid idCanal);
        Canal Adicionar(Canal canal);
        void Excluir(Canal canal);
    }
}
