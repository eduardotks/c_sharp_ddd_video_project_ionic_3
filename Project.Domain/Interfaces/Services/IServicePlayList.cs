using System;
using System.Collections.Generic;
using Project.Domain.Arguments.Base;
using Project.Domain.Arguments.PlayList;
using Project.Domain.Interfaces.Services.Base;

namespace Project.Domain.Interfaces.Services
{
    public interface IServicePlayList : IServiceBase
    {
        IEnumerable<PlayListResponse> Listar(Guid idUsuario);
        PlayListResponse AdicionarPlayList(AdicionarPlayListRequest request, Guid idUsuario);
        Response ExcluirPlayList(Guid idPlayList);
    }
}
