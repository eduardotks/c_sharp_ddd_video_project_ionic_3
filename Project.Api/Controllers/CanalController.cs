using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using Project.Domain.Arguments.Canal;
using Project.Domain.Arguments.Usuario;
using Project.Domain.Interfaces.Services;
using Project.Infra.Transactions;

namespace Project.Api.Controllers
{
    public class CanalController : Base.ControllerBase
    {
        private readonly IServiceCanal _serviceCanal;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CanalController(IHttpContextAccessor httpContextAccessor, IUnitOfWork unityOfWork, IServiceCanal serviceCanal) : base(unityOfWork)
        {
            _serviceCanal = serviceCanal;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        [Route("api/v1/Canal/Listar")]
        public async Task<IActionResult> Listar()
        {
            try
            {
                string usuarioClaims = _httpContextAccessor.HttpContext.User.FindFirst("Usuario").Value;
                AutenticarUsuarioResponse usuarioResponse = JsonConvert.DeserializeObject<AutenticarUsuarioResponse>(usuarioClaims);

                var response = _serviceCanal.Listar(usuarioResponse.Id);

                return await ResponseAsync(response, _serviceCanal);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
                
            }
        }

        [HttpPost]
        [Route("api/v1/Canal/Adicionar")]
        public async Task<IActionResult> Adicionar([FromBody]AdicionarCanalRequest request)
        {
            try
            {
                string usuarioClaims = _httpContextAccessor.HttpContext.User.FindFirst("Usuario").Value;
                AutenticarUsuarioResponse usuarioResponse = JsonConvert.DeserializeObject<AutenticarUsuarioResponse>(usuarioClaims);

                var response = _serviceCanal.AdicionarCanal(request, usuarioResponse.Id);

                return await ResponseAsync(response, _serviceCanal);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [HttpDelete]
        [Route("api/v1/Canal/Excluir/{id:Guid}")]
        public async Task<IActionResult> Excluir(Guid id)
        {
            try
            {
                var response = _serviceCanal.ExcluirCanal(id);

                return await ResponseAsync(response, _serviceCanal);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
    }
}
