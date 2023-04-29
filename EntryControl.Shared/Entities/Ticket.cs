using EntryControl.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace EntryControl.Shared.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        [Display(Name = "Id Boleta")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string IdTicket { get; set; } = null!;

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        [Display(Name = "Fecha de Uso")]
        public DateTime? UseDate { get; set; } = null;

        [Display(Name = "Fue Usada")]
        public bool WasUsed { get; set; }

        [Display(Name = "Entrada")]
        public EntranceType? EntranceType { get; set; } = null;
    }
}
