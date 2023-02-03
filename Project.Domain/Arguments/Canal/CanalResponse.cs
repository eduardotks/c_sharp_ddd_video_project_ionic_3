using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Arguments.Canal
{
    public class CanalResponse
    {
        public Guid IdCanal { get; set; }
        public string Nome { get; set; }
        public string UrlLogo { get; set; }

        public static explicit operator CanalResponse(Entities.Canal v)
        {
            return new CanalResponse()
            {
                IdCanal = v.Id,
                Nome = v.Nome,
                UrlLogo = v.UrlLogo
            };
        }
    }
}
