using Project.Domain.Entities;

namespace Project.Domain.Interface.Repositories
{
    public interface IRepositoryUsuario
    {
        //Captura o usuário no bd
        Usuario Obter(Guid id);
        Usuario Obter(string email, string senha);

        void Salvar(Usuario usuario);
        bool Existe(string email);

    }
}
