using Project.Domain.Arguments.Usuario;

namespace Project.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AdicionarUsuarioRequest request = new AdicionarUsuarioRequest()
            {
                Email = "teste@hotmail.com",
                PrimeiroNome = "Eduardo",
                UltimoNome = "C",
                Senha = "123456"
            };

            //unusable project...configure para funcionar novamente.
            //var response = new ServiceUsuario().AdicionarUsuario(request);

        }
    }
}