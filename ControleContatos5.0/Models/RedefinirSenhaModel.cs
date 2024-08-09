using System.ComponentModel.DataAnnotations;

namespace ControleContatos5._0.Models
{
    public class RedefinirSenhaModel
    {


        [Required(ErrorMessage = "Digite o login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o Email")]
        public string Email { get; set; }

    }
}
