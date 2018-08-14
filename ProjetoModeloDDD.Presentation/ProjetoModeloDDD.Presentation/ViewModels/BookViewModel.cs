using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.Presentation.ViewModels
{
    public class BookViewModel
    {
        [Key]
        public int BookId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Título")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteristicas")]
        [DisplayName("Título")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Preencha o campo Autor")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteristicas")]
        [DisplayName("Autor")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Preencha o campo ISBN do livro")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###-##-###-####-#}")]
        [DisplayName("ISBN")]
        public string Isbn { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedAt { get; set; }

        [ScaffoldColumn(false)]
        public bool Active { get; set; } = true;
    }
}