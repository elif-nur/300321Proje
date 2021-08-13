using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User:IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "boş bırakılamaz")]
        public string Username { get; set; }
        [Required(ErrorMessage = "boş bırakılamaz")]
        public string Password { get; set; }
    }
}
