using System;
using System.Collections.Generic;
using Project.Domain.Arguments.Base;
using Project.Domain.Arguments.Canal;
using Project.Domain.Interfaces.Services.Base;

namespace Project.Domain.Interfaces.Services
{
    public interface IServiceCanal : IServiceBase
    {
        IEnumerable<CanalResponse> Listar(Guid idUsuario);
        CanalResponse AdicionarCanal(AdicionarCanalRequest request, Guid idUsuario);
        Response ExcluirCanal(Guid idCanal);
    }
}
