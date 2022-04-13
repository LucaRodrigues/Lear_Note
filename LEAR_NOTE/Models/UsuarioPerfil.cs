using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LEAR_NOTE.Models
{
    public class UsuarioPerfil
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int PerfilId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Perfil Perfil { get; set; }

    }
}