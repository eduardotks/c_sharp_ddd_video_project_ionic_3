using Project.Domain.Arguments.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Interface.Services
{
    public interface IServiceUsuario
    {
        AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request);

        AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request);
    }

}