using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.webApi.ViewModels
{
    public class LoginViewModels
    {
        [Required(ErrorMessage = "Informe o e-mail do usuario!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o e-mail do usuario!")]
        public string Senha { get; set; }

    }
}
