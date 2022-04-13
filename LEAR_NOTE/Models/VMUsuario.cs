using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LEAR_NOTE.Models
{
    public class VMUsuario
    {
        public class Cadastro
        {
            [Required]
            [MaxLength(255)]
            public string Nome { get; set; }
            [Required]
            [EmailAddress]
            public string Email { get; set; }
            [DataType(DataType.Password)]
            [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{6,12})", ErrorMessage = "A senha deve conter aos menos uma letra maiúscula, minúscula e um número.Deve ser no mínimo 6 caracteres")]
            public string Senha { get; set; }
            [DataType(DataType.Password)]
            [Compare("Senha")]
            [Display(Name = "Confirma Senha")]
            public string ConfirmaSenha { get; set; }
        }
        public class Acesso
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }
            [DataType(DataType.Password)]
            [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{6,12})", ErrorMessage = "A senha deve conter aos menos uma letra maiúscula, minúscula e um número.Deve ser no mínimo 6 caracteres")]
            public string Senha { get; set; }
        }
    }
}