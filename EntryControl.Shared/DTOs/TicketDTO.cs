using EntryControl.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace EntryControl.Shared.DTOs
{
    public class TicketDTO
    {
        public int Id { get; set; }

        [Display(Name = "Id Boleta")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string IdTicket { get; set; } = null!;

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        [Display(Name = "Fecha de Uso")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public DateTime UseDate { get; set; } = DateTime.Now;

        [Display(Name = "Fue Usada")]
        public bool WasUsed { get; set; } = false;

        [Display(Name = "Porteria")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar una porteria")]
        public EntranceType EntranceType { get; set; }

    }
}
