//crtl R + G limpa import desnecessário

using Project.Domain.Entities.Base;
using Project.Domain.ValueObjects;

namespace Project.Domain.Entities
{
    //canal herda de entity base
    public class Canal : EntityBase
    {
        public Nome Nome { get; set; }
        public string UrlLogo { get; set; }
        public Usuario Usuario { get; set; }
    }
}
