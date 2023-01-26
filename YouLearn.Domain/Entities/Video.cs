﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouLearn.Domain.Entities.Base;
using YouLearn.Domain.Enums;

namespace YouLearn.Domain.Entities
{
    public class Video : EntityBase
    {
        public Canal Canal { get; set; }
        public Playlist Playlist { get; set; }
        public Usuario UsuarioSugeriu { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Tags { get; set; }
        public int OrdemNaPlaylist { get; set; }
        public string IdVideoYoutube {get; set; }
        public EnumStatus status {get; set; }

    }
}
