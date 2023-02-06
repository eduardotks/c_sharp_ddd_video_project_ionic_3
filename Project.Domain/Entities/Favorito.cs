using Project.Domain.Entities.Base;

namespace Project.Domain.Entities
{
    public class Favorito : EntityBase
    {
        protected Favorito()
        {

        }
        public Video Video { get; set; }

        public Usuario Usuario { get; set; }
    }
}
