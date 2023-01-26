//crtl R + G limpa import desnecessário

using YouLearn.Domain.Entities.Base;
using YouLearn.Domain.ValueObjects;

namespace YouLearn.Domain.Entities
{ 
    //canal herda de entity base
    public class Canal : EntityBase
    {
        public Nome Nome { get; set; }
        public string UrlLogo { get; set; }
        public Usuario Usuario { get; set; }
    }
}
