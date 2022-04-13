using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LEAR_NOTE.Models
{
    public class Perfil
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public virtual
        ICollection<UsuarioPerfil> UsuarioPerfil
        { get; set; }
    }
}