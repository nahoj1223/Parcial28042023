using EntryControl.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public DateTime UseDate { get; set; }

        [Display(Name = "Fue Usada")]
        public bool WasUsed { get; set; }

        [Display(Name = "Entrada")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar una {0}.")]
        public EntranceType EntranceType { get; set; }
    }
}
