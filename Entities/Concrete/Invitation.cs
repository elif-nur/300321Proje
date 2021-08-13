using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Invitation:IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Başlık TR")]
        public string TitleTR { get; set; }
        [Display(Name = "Başlık EN")]
        public string TitleEN { get; set; }
        [Display(Name = "Başlık AR")]
        public string TitleAR { get; set; }
        [Display(Name = "İçerik TR")]
        [Required(ErrorMessage = "Boş bırakılamaz")]
        public string DescriptionTR { get; set; }
        [Display(Name = "İçerik EN")]
        [Required(ErrorMessage = "Boş bırakılamaz")]
        public string DescriptionEN { get; set; }
        [Display(Name = "İçerik AR")]
        [Required(ErrorMessage = "Boş bırakılamaz")]
        public string DescriptionAR { get; set; }
    }
}
