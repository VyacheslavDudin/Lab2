using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyLab2.Models
{
    public class Subsidiaries
    {
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Назва")]
        public string Name { get; set; }
        [Display(Name = "К-сть працівників")]
        public int EmployeesNumber { get; set; }
        [Display(Name = "Дата заснування")]
        public DateTime FoundDate { get; set; }
        [Display(Name = "Місце знах.")]
        public string Location { get; set; }
        [Display(Name = "Статус")]
        public string Status { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public int DevelopmentStudioID { get; set; }

        public virtual DevelopmentStudio DevelopmentStudio { get; set; }
    }
}
