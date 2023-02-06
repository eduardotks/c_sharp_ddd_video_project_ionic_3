using System;
using System.Collections.Generic;
using Project.Domain.Entities;

namespace Project.Domain.Interfaces.Repositories
{
    public interface IRepositoryVideo
    {
        void Adicionar(Video video);
        IEnumerable<Video> Listar(string tags);
        IEnumerable<Video> Listar(Guid idPlayList);
        bool ExisteCanalAssociado(Guid idCanal);
        bool ExistePlayListAssociada(Guid idPlayList);
    }
}
