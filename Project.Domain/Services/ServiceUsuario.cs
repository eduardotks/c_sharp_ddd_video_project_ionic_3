using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using Project.Domain.Arguments.Usuario;
using Project.Domain.Entities;
using Project.Domain.Interface.Services;
using Project.Domain.Resources;
using Project.Domain.ValueObjects;

namespace Project.Domain.Services
{
    public class ServiceUsuario : Notifiable, IServiceUsuario
    {
        public AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request)
        {
            if(request == null)
            {
                AddNotification("AdicionarUsuarioRequest", string.Format(MSG.OBJETO_X0_E_OBRIGATORIO.ToFormat("AdicionarUsuarioRequest")));
                return null;
            }
            Nome nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            Email email = new Email(request.Email);

            Usuario usuario = new Usuario();
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = request.Senha;

            AddNotifications(nome, email, usuario);

            if (usuario.Senha.Length <= 3)
            {
                throw new Exception("Senha deve ter acima de 3 caracteres");
            }

            //persiste no BD
            //new IRepositoryUsuario().Salvar(usuario);

            //AdicionarUsuarioResponse response = new RepositoryUsuario().Salvar(usuario);
            //return response;
            if(IsInvalid() == true)
            {
                return null;
            }
            return new AdicionarUsuarioResponse(Guid.NewGuid());
            
        }

        public AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
