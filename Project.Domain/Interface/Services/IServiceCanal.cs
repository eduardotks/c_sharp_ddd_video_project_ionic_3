using prmToolkit.NotificationPattern;
using Project.Domain.Arguments.Canal;
using Project.Domain.Arguments.Usuario;
using Project.Domain.Interfaces.Services.Base;

namespace Project.Domain.Interface.Services
{
    public interface IServiceCanal : IServiceBase
    {
        IEnumerable<CanalResponse> Listar(Guid idUsuario);

        CanalResponse AdicionarCanal(AdicionarCanalRequest request, Guid idUsuario);

        Response ExcluirCanal(Guid idCanal);

    }
}
  