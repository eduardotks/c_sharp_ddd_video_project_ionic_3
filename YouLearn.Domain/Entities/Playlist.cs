using Project.Domain.Entities.Base;
using Project.Domain.Enums;

namespace Project.Domain.Entities
{
    public class Playlist : EntityBase
    {
        public Playlist()
        {
            Video video = new Video();
            video.status = EnumStatus.Aprovado;
        }
        public Usuario Usuario { get; set; }

        //em análise, aprovado ou recusando
        public EnumStatus Status { get; set; }
    }
}
