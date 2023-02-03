using Project.Domain.Entities;

namespace Project.Domain.Interface.Repositories
{
    public interface IRepositoryUsuario
    {
        //Captura o usuário no bd
        IEnumerable<Canal> Listar(Guid idUsuario);
        Canal Obter(Guid id);
        Canal Adicionar(Canal canal);
        void Excluir(Canal canal);

    }
}
