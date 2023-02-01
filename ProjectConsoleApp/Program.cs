using Project.Domain.Arguments.Usuario;
using Project.Domain.Services;
using Project.Domain.ValueObjects;
using System;

namespace Project.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AdicionarUsuarioRequest request = new AdicionarUsuarioRequest()
            {
                Email = "ed3mais2008@hotmail.com",
                PrimeiroNome = "Eduardo",
                UltimoNome = "Costa",
                Senha = "123456"
            };
            var response = new ServiceUsuario().AdicionarUsuario(request);

        }
    }
}