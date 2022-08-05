using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AppAutenticacao.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }

        [Required]
        [MaxLength(100)]
        public string UsuarioNome { get; set; }

        [Required]
        [MaxLength (50)]
        public string Login { get; set; }

        [Required]
        [MaxLength (50)]
        public string Senha { get; set; }   
    }
}