using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Card:IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "boş bırakılamaz")]
        public string ImagePath { get; set; }
    }
}
