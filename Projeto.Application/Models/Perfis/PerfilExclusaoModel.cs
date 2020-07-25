using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Application.Models.Perfis
{
    public class PerfilExclusaoModel
    {
        [Required(ErrorMessage = "Informe o id do perfil.")]
        public string IdPerfil { get; set; }
    }
}
