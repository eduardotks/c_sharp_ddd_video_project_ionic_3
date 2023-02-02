using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using Project.Domain.Resources;

namespace Project.Domain.ValueObjects
{
    public class Nome : Notifiable
    {
        public Nome(string primeiroNome, string ultimoNome)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;

            new AddNotifications<Nome>(this)
                .IfNullOrEmptyOrInvalidLength(x => x.PrimeiroNome, 1, 50, MSG.X0_E_OBRIGATORIA_E_DEVE_CONTER_X1_CARACTERES.ToFormat("Primeiro Nome", 1, 50))
                .IfNullOrEmptyOrInvalidLength(x => x.UltimoNome, 1, 50, MSG.X0_E_OBRIGATORIA_E_DEVE_CONTER_X1_CARACTERES.ToFormat("Último Nome", 1, 50)
            );
            /*if (PrimeiroNome.Length < 3 || PrimeiroNome.Length > 50)
            {
                //AddNotification("AdicionarUsuarioRequest", "Primeiro nome precisa conter entre 3 a 50 caracteres");
                throw new Exception("Primeiro nome precisa conter entre 3 a 50 caracteres");
            }
            if (UltimoNome.Length < 3 || UltimoNome.Length > 50)
            {
                throw new Exception("Último nome precisa conter entre 3 a 50 caracteres");
            }*/
        }

        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }

    }
}
