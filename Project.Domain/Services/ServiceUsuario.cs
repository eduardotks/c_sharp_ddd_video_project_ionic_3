using Project.Domain.Arguments.Usuario;
using Project.Domain.Entities;
using Project.Domain.Interface.Repositories;
using Project.Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Services
{
    public class ServiceUsuario : IServiceUsuario
    {
        public AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request)
        {
            if(request == null)
            {
                throw new Exception("Objeto AdicionarUsuarioRequest é obrigatório");
            }

            Usuario usuario = new Usuario();
            usuario.Nome.PrimeiroNome = "Eduardo";
            usuario.Nome.UltimoNome = "Costa";
            usuario.Email.Endereco = "ed3mais2008@hotmail.com";
            usuario.Senha = "123456";

            if (usuario.Nome.PrimeiroNome.Length < 3 || usuario.Nome.PrimeiroNome.Length > 50)
            {
                throw new Exception("Primeiro nome precisa conter entre 3 a 50 caracteres");
            }
            if (usuario.Nome.UltimoNome.Length < 3 || usuario.Nome.UltimoNome.Length > 50)
            {
                throw new Exception("Último nome precisa conter entre 3 a 50 caracteres");
            }
            if (usuario.Email.Endereco.IndexOf('@') < 1)
            {
                throw new Exception("E-mail Inválido");
            }
            if (usuario.Senha.Length > 3)
            {
                throw new Exception("Senha deve ter acima de 3 caracteres");
            }

            //persiste no BD
            //new IRepositoryUsuario().Salvar(usuario);

            AdicionarUsuarioResponse response = new RepositoryUsuario().Salvar(usuario);
            return response;
        }

        public AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
