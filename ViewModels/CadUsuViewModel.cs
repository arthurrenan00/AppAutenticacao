using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using CompareAttribute = System.ComponentModel.DataAnnotations.CompareAttribute;

namespace AppAutenticacao.ViewModels
{
    public class CadUsuViewModel
    {
        [Display(Name ="Nome")]
        [Required(ErrorMessage ="Informe seu nome")]
        [MaxLength(100, ErrorMessage ="O nome deve conter no máximo 100 caracteres")]
        public string UsuNome { get; set; }

        [Required(ErrorMessage ="Informe o Login")]
        [MaxLength(50, ErrorMessage ="O login deve conter no máximo 50 caracteres")]
        [Remote("Action","Autenticacao", ErrorMessage ="O login já existe")]
        public string Login { get; set; }

        [Required(ErrorMessage ="Informe a senha")]
        [MaxLength(50, ErrorMessage ="A senha deve conter no máximo 50 caracteres")]
        [MinLength(6, ErrorMessage = "A senha deve conter no mínimo 6 caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage ="Confirme a senha")]
        [Display(Name ="Senha")]
        [DataType(DataType.Password)]
        [Compare(nameof(Senha), ErrorMessage ="As senhas são diferentes")]
        public string ConfirmarSenha { get; set; }
    }
}