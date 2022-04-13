using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LEAR_NOTE.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(200)]
        [EmailAddress]
        public string Email { get; set; }
        public string Senha { get; set; }
        public virtual ICollection<UsuarioPerfil>
        UsuarioPerfil
        { get; set; }

    }
}