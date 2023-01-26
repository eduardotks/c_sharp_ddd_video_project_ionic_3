using Project.Domain.Entities.Base;
using Project.Domain.ValueObjects;

namespace Project.Domain.Entities
{
    public class Usuario : EntityBase
    {
        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public string Senha { get; set; }
    }
}
