﻿using Project.Domain.Entities.Base;
using Project.Domain.Enums;

namespace Project.Domain.Entities
{
    public class Video : EntityBase
    {
        public Canal Canal { get; set; }
        public PlayList Playlist { get; set; }
        public Usuario UsuarioSugeriu { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Tags { get; set; }
        public int OrdemNaPlaylist { get; set; }
        public string IdVideoYoutube { get; set; }
        public EnumStatus Status { get; set; }

    }
}
