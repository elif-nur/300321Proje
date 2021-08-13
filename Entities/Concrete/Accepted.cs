using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Accepted:IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Ad TR")]
        public string NameTR { get; set; }
        [Display(Name = "Soyad TR")]
        public string SurnameTR { get; set; }
        [Display(Name = "Ad AR")]
        public string NameAR { get; set; }
        [Display(Name = "Soyad AR")]
        public string SurnameAR { get; set; }
        [Display(Name = "Ad EN")]
        public string NameEN { get; set; }
        [Display(Name = "Soyad EN")]
        public string SurnameEN { get; set; }
    }
}
