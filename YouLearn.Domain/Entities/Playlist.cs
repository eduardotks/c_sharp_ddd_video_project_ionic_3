using YouLearn.Domain.Entities.Base;
using YouLearn.Domain.Enums;

namespace YouLearn.Domain.Entities
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
