using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyPaste.Infra.DataTransfer
{
    public class PersonDataTransfer
    {
        [Required(ErrorMessage = "O campo Id é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O campo Id deve ser maior que zero.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo Email deve ser um endereço de email válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Data e Hora é obrigatório.")]
        [DataType(DataType.DateTime, ErrorMessage = "O campo Data e Hora deve ser uma data e hora válida.")]
        public DateTime DataHora { get; set; }
    }
}
