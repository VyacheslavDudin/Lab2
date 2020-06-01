using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyLab2.Models
{
    public class ComputerGames
    {
        public ComputerGames()
        {
            DevelopingGames = new List<DevelopingGames>();
            ComputerGameOnPlatform = new List<ComputerGameOnPlatform>(); 
        }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Назва")]
        public string Name { get; set; }
        [Display(Name = "Вікові обмеження")]
        public int AgeRestrictions { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Наявність онлайну")]
        public bool IsOnline { get; set; }
        [Display(Name = "Опис")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Жанр")]
        public int GenreID { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Платформа")]
        public int ComputerGameOnPlatformID { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Студія-розробник")]
        public int DevelopingGamesID { get; set; }

        public virtual ICollection<ComputerGameOnPlatform> ComputerGameOnPlatform { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual ICollection<DevelopingGames> DevelopingGames {get;set;} 
    }
}
