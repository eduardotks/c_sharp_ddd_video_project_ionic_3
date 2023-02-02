using Project.Domain.Entities;
using Project.Domain.Interface.Repositories;
using Project.Infra.Persistence.EF;

namespace Project.Infra.Persistence.Repositories
{
    public class RepositoryUsuario : IRepositoryUsuario
    {
        private readonly ProjectContext _context;
        public RepositoryUsuario(ProjectContext context)
        {
            _context = context;
        }

        public bool Existe(string email)
        {
            return _context.Usuarios.Any(x => x.Email.Endereco == email);
        }

        public Usuario Obter(Guid id)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        public Usuario Obter(string email, string senha)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Email.Endereco == email && x.Senha == senha);
        }

        public void Salvar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
        }
    }
}
