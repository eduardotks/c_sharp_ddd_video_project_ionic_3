using System;
using System.Collections.Generic;
using Project.Domain.Arguments.Video;
using Project.Domain.Interfaces.Services.Base;

namespace Project.Domain.Interfaces.Services
{
    public interface IServiceVideo : IServiceBase
    {
        AdicionarVideoResponse AdicionarVideo(AdicionarVideoRequest request, Guid idUsuario);
        IEnumerable<VideoResponse> Listar(string tags);
        IEnumerable<VideoResponse> Listar(Guid idPlayList);
    }
}
