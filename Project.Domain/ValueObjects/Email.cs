using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using Project.Domain.Entities;
using Project.Domain.Resources;

namespace Project.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string endereco)
        {
            Endereco = endereco;

            new AddNotifications<Email>(this).IfNotEmail(x => x.Endereco, MSG.X0_INVALIDO.ToFormat("E-mail"));
            /*
            if (Endereco.IndexOf('@') < 1)
            {
                throw new Exception("E-mail Inválido");
            }*/
        }

        public string Endereco { get; set; }
    }
}
