using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace MyLab2.Models
{
    public class DevelopmentStudio
    {
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Назва")]
        public string Name { get; set; }
        [Display(Name = "Головний офіс")]
        public string MainOffice { get; set; }
        [Display(Name = "Місце знах. гол. офісу")]
        public string MainOfficeLocation { get; set; }
        public virtual ICollection<Subsidiaries> Subsidiaries { get; set; }

    }
}
