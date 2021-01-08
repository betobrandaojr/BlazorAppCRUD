using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorAppCRUD.Shared.Models {
    public class Pessoa {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O peso é obrigatório")]
        public int Peso { get; set; }
    }
}
